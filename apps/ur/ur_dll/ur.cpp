#include "ur.h"
#include "freeglut.h"

#define _USE_MATH_DEFINES // for C++
#include <cmath>

#define _USE_MATH_DEFINES // for C
#include <math.h>

#define BASESHIFT      0.086
#define BASERADIUS     0.09
#define BASEHEIGHT     0.123
#define ELBOWRADIUS    0.075
#define ELBOWHEIGHT    0.10755
#define WRISTRADIUS    0.063
#define WRISTHEIGHT    0.09448
#define JOINT1HEIGHT   0.16
#define JOINT2HEIGHT   0.136
#define TOOLHEIGHT     0.031

static int base_x, base_y, base_z;
static float ang_x, ang_y, ang_z;
static float d1, d2, a2, a3, d3, d4, d5, d6, d7;
static float alpha[6], d[6], a[6], theta[6];
static double theta_base, theta_shoulder, theta_elbow, theta_wrist1, theta_wrist2, theta_wrist3;


void initilize()
{
    theta_base = 0;
    theta_shoulder = -90;
    theta_elbow = 0;
    theta_wrist1 = -90;
    theta_wrist2 = 0;
    theta_wrist3 = 0;

    d1 = (BASEHEIGHT / 2 + BASESHIFT) * 2;
    d2 = (BASERADIUS / 2 + BASEHEIGHT / 2) * 2;
    a2 = (BASERADIUS / 2 + JOINT1HEIGHT + ELBOWRADIUS / 2) * 2;
    a3 = (JOINT2HEIGHT + ELBOWRADIUS / 2 + WRISTRADIUS/2) * 2;
    d4 = (ELBOWHEIGHT / 2 + 0.074/2) * 2;
    d5 = (WRISTHEIGHT / 2 + WRISTRADIUS/2) * 2;
    d6 = d5;
    d7 = (TOOLHEIGHT + WRISTHEIGHT / 2) * 2;
}


void solidSphere(GLdouble radius, GLint slices, GLint stacks)
{
    GLUquadricObj *quadricObj = gluNewQuadric();
    gluQuadricDrawStyle(quadricObj, GLU_FILL);
    gluSphere(quadricObj, radius, slices, stacks);
    gluDeleteQuadric(quadricObj);
}


void DrawUnitCylinder(int numSegs, float topSize, float bottomSize)
{

    int i;
    float *Px = new float[numSegs];
    float *Py = new float[numSegs];
    float AngIncr = (2.0f * M_PI) / (float)numSegs;
    float Ang = AngIncr;
    Px[0] = 1;
    Py[0] = 0;
    for (i = 1; i < numSegs; i++, Ang += AngIncr)
    {
        Px[i] = (float)cos(Ang);
        Py[i] = (float)sin(Ang);
    }
    glMatrixMode(GL_MODELVIEW);
    glPushMatrix();
    // Top
    glNormal3f(0, 1, 0);
    glBegin(GL_TRIANGLE_FAN);
    glVertex3f(0, 1, 0);
    for (i = 0; i < numSegs; i++)
        glVertex3f(topSize * Px[i], 1, -topSize * Py[i]);
    glVertex3f(topSize * Px[0], 1, -topSize * Py[0]);
    glEnd();
    // Bottom
    glNormal3f(0, -1, 0);
    glBegin(GL_TRIANGLE_FAN);
    glVertex3f(0, -1, 0);
    for (i = 0; i < numSegs; i++)
        glVertex3f(bottomSize * Px[i], -1, bottomSize * Py[i]);
    glVertex3f(bottomSize * Px[0], -1, bottomSize * Py[0]);
    glEnd();
    // Sides
    glBegin(GL_QUAD_STRIP);
    for (i = 0; i < numSegs; i++)
    {
        glNormal3f(Px[i], 0, -Py[i]);
        glVertex3f(topSize * Px[i], 1, -topSize * Py[i]);
        glVertex3f(bottomSize * Px[i], -1, -bottomSize * Py[i]);
    }
    glNormal3f(Px[0], 0, -Py[0]);
    glVertex3f(topSize * Px[0], 1, -topSize * Py[0]);
    glVertex3f(bottomSize * Px[0], -1, -bottomSize * Py[0]);
    glEnd();
    glPopMatrix();

}

void DrawWrist3(int numSegs)
{
    glMatrixMode(GL_MODELVIEW);

    glPushMatrix();
    glScalef(WRISTRADIUS + 0.001, WRISTHEIGHT / 10.8, WRISTRADIUS + 0.001);
    glTranslatef(-0, 10, -0);
    glColor3f(0, 0.255, 0.45);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(WRISTRADIUS, WRISTHEIGHT, WRISTRADIUS);
    glTranslatef(-0, 0, -0);
    glColor3f(0.3, 0.3, 0.3);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(WRISTRADIUS + 0.001, WRISTHEIGHT / 11, WRISTRADIUS + 0.001);
    glTranslatef(-0, -10, -0);
    glColor3f(0.2, 0.2, 0.2);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glTranslatef(-0, -WRISTHEIGHT - TOOLHEIGHT, -0);
    glScalef(WRISTRADIUS + 0.001, TOOLHEIGHT, WRISTRADIUS + 0.001);
    glColor3f(0.6, 0.6, 0.6);
    DrawUnitCylinder(numSegs, 1, 1);
    glPopMatrix();

    glPushMatrix();
    glRotatef(90, 0 , 0, 90);
    glTranslatef(-WRISTHEIGHT - TOOLHEIGHT, WRISTRADIUS, -0);
    solidSphere(0.015,20,16);
    glPopMatrix();

    glPushMatrix();
    glRotatef(90, 0 , 0, 90);
    glColor3f(0, 0.255, 0.45);
    glTranslatef((-WRISTHEIGHT/2 - TOOLHEIGHT)*2, 0, -0);
    solidSphere(0.015,20,16);
    glPopMatrix();
}

void DrawWrist2(int numSegs)
{
    glMatrixMode(GL_MODELVIEW);

    glPushMatrix();
    glScalef(WRISTRADIUS + 0.001, WRISTHEIGHT / 10.8, WRISTRADIUS + 0.001);
    glTranslatef(-0, -10, -0);
    glColor3f(0, 0.255, 0.45);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(WRISTRADIUS, WRISTHEIGHT, WRISTRADIUS);
    glTranslatef(-0, 0, -0);
    glColor3f(0.3, 0.3, 0.3);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(WRISTRADIUS + 0.001, WRISTHEIGHT / 11, WRISTRADIUS + 0.001);
    glTranslatef(-0, 11, -0);
    glColor3f(0.2, 0.2, 0.2);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();
}

void DrawWrist1(int numSegs)
{
    glMatrixMode(GL_MODELVIEW);

    glPushMatrix();
    glScalef(WRISTRADIUS + 0.001, WRISTHEIGHT / 10.8, WRISTRADIUS + 0.001);
    glTranslatef(-0, 10, -0);
    glColor3f(0, 0.255, 0.45);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(WRISTRADIUS, WRISTHEIGHT, WRISTRADIUS);
    glTranslatef(-0, 0, -0);
    glColor3f(0.3, 0.3, 0.3);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(WRISTRADIUS + 0.001, WRISTHEIGHT / 11 + 0.0001, WRISTRADIUS + 0.001);
    glTranslatef(-0, -11, -0);
    glColor3f(0.2, 0.2, 0.2);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();
}

void DrawElbow(int numSegs)
{
    glMatrixMode(GL_MODELVIEW);

    glPushMatrix();
    glScalef(ELBOWRADIUS + 0.001, ELBOWHEIGHT / 10.8, ELBOWRADIUS + 0.001);
    glTranslatef(-0, 10, -0);
    glColor3f(0, 0.255, 0.45);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(ELBOWRADIUS, ELBOWHEIGHT, ELBOWRADIUS);
    glTranslatef(-0, 0, -0);
    glColor3f(0.3, 0.3, 0.3);
    DrawUnitCylinder(numSegs,1 ,1);
    glTranslatef(0, -1.3, -0);
    glColor3f(0.4, 0.4, 0.4);
    glColor3f(1, 1, 1);
    solidSphere(0.95, 20, 16);
    glPopMatrix();

    glPushMatrix();
    glScalef(ELBOWRADIUS + 0.001, ELBOWHEIGHT / 11, ELBOWRADIUS + 0.001);
    glTranslatef(-0, -10, -0);
    glColor3f(0.2, 0.2, 0.2);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glRotatef(-90, 0 , 0, 90);
    glTranslatef((ELBOWHEIGHT + ELBOWRADIUS), (JOINT2HEIGHT / 2 + ELBOWRADIUS / 2)*2, 0);
    glScalef(0.054f, 0.16f + 0.03, 0.054f);
    glColor3f(0.6, 0.6, 0.6);
    DrawUnitCylinder(numSegs, 1, 1);
    glPopMatrix();
}

void DrawShoulder(int numSegs)
{
    glMatrixMode(GL_MODELVIEW);
    glPushMatrix();
    glScalef(BASERADIUS + 0.001, BASEHEIGHT / 10.8, BASERADIUS + 0.001);
    glTranslatef(-0, 10, -0);
    glColor3f(0, 0.255, 0.45);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(BASERADIUS, BASEHEIGHT, BASERADIUS);
    glTranslatef(-0, 0, -0);
    glColor3f(0.3, 0.3, 0.3);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(BASERADIUS + 0.001, BASEHEIGHT / 11, BASERADIUS + 0.001);
    glTranslatef(-0, -10, -0);
    glColor3f(0.2, 0.2, 0.2);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glTranslatef(-JOINT1HEIGHT - BASERADIUS, 0, -0);
    glScalef(0.2f, 0.066f, 0.066f);
    glRotatef(90, 0, 0, 90);

    glColor3f(0.6, 0.6, 0.6);
    DrawUnitCylinder(numSegs, 1, 1);
    glPopMatrix();
}

void DrawBase(int numSegs)
{
    glMatrixMode(GL_MODELVIEW);
    glPushMatrix();
    glScalef(BASERADIUS + 0.001, BASEHEIGHT / 10.8, BASERADIUS + 0.001);
    glTranslatef(-0, 10, -0);
    glColor3f(0, 0.255, 0.45);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(BASERADIUS, BASEHEIGHT, BASERADIUS);
    glTranslatef(-0, 0, -0);
    glColor3f(0.3, 0.3, 0.3);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glScalef(BASERADIUS + 0.001, BASEHEIGHT / 11, BASERADIUS + 0.001);
    glTranslatef(-0, -10, -0);
    glColor3f(0.2, 0.2, 0.2);
    DrawUnitCylinder(numSegs,1 ,1);
    glPopMatrix();

    glPushMatrix();
    glTranslatef(-0, -BASEHEIGHT * 2 + BASESHIFT / 2, -0);
    glScalef(BASERADIUS, BASESHIFT, BASERADIUS);
    glColor3f(0.6, 0.6, 0.6);
    DrawUnitCylinder(numSegs,1 ,1.5);
    glPopMatrix();
}

void DrawGroundPlane()
{
      glColor3f(0.7f, 0.7f, 0.7f);
    glBegin(GL_QUADS);
    glNormal3f(0, 0.2, 0);
    glVertex3f(-0.2, 0, 0.2);
    glVertex3f(0.2, 0, 0.2);
    glVertex3f(0.2, 0, -0.2);
    glVertex3f(-0.2, 0, -0.2);
    glEnd();



}

void setJointAngle(double *angle)
{
     theta_base     = angle[0]* 180 / M_PI;
    theta_shoulder = angle[1] * 180 / M_PI;
    theta_elbow    =angle[2] * 180 / M_PI;
    theta_wrist1   = angle[3] * 180 / M_PI;
    theta_wrist2   =angle[4] * 180 / M_PI;
    theta_wrist3   = angle[5] * 180 / M_PI;
}

void DrawRobotArm()
{


    glMatrixMode(GL_MODELVIEW);
    glPushMatrix();

    /*Draw Base*/
    glTranslatef(-0, BASESHIFT * 2 + BASEHEIGHT, 0);
    glRotatef(theta_base, 0, 360, 0);
    glPushMatrix();
    DrawBase(64);
    glPopMatrix();

    /*Draw Shoulder*/
    glTranslatef(-0.18, 0, 0);
    glRotatef(theta_shoulder + 90, -360, 0, 0);
    glPushMatrix();
    glRotatef(90, 0, 0, 90);
    glRotatef(-180, 0, 1, 0);
    DrawShoulder(64);
    glPopMatrix();

    /*Draw Elbow*/
    //glTranslatef(0, 0.16 + 0.09*2 + 0.075*2, 0);
    glTranslatef(0, a2, 0);
    glRotatef(theta_elbow, -360, 0, 0);
    glPushMatrix();
    glRotatef(90, 0, 0, 90);
    DrawElbow(64);
    glPopMatrix();

    /*Draw Wrist1*/
    //    glTranslatef(-0.0315 - 0.02 + 0.18, 0.075 + 0.136 + 0.063*2, 0);
    glTranslatef(d4, a3, 0);
    glRotatef(theta_wrist1 + 90, -360, 0, 0);
    glPushMatrix();
    glRotatef(90 + 180, 0, 0, 90);
    DrawWrist1(64);
    glPopMatrix();

    /*Draw Wrist2*/
    //    glTranslatef(-0.063*2, 0.02, 0);
    glTranslatef(-d5, 0, 0);
    glRotatef(theta_wrist2, 0, 360, 0);
    glPushMatrix();
    glRotatef(90 + 180 + 90, 0, 0, 90);
    DrawWrist2(64);
    glPopMatrix();

    /*Draw Wrist3*/
    //    glTranslatef(0, 0.063*2 + 0.01, 0)
    glTranslatef(0, d6, 0);;
    glRotatef(theta_wrist3, -360, 0, 0);
    glPushMatrix();
    glRotatef(90 + 180 + 90 - 90, 0, 0, 90);
    DrawWrist3(64);
    glPopMatrix();

}

