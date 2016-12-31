/*
Copyright 2016 Open Robot Club

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;                                                                           //  引入System函式庫
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;                                                             //	引入System.Windows.Forms函式庫

namespace app
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()																//	Main主程式
		{																				//	進入Main主程式
			Application.EnableVisualStyles();											//	為應用程式啟用視覺化樣式
			Application.SetCompatibleTextRenderingDefault(false);						//	為部分控制項上定義的 UseCompatibleTextRendering 屬性設定應用程式範圍的預設值
			Application.Run(new FormMain());											//	執行FormMain
		}																				//	結束Main主程式
	}
}
