#ifndef __UR_H__
#define __UR_H__
#ifdef __cplusplus
extern "C" 
{
#endif
    void initilize();
    void DrawUnitCylinder(int numSegs, float topSize, float bottomSize);
    void DrawWrist3(int numSegs);
    void DrawWrist2(int numSegs);
    void DrawWrist1(int numSegs);
    void DrawElbow(int numSegs);
    void DrawShoulder(int numSegs);
    void DrawBase(int numSegs);
    void setJointAngle(double *angle);
    void DrawRobotArm();
    void DrawGroundPlane();

#ifdef __cplusplus

}
#endif
#endif 
