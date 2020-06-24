﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace VodafoneBS_Branding
{
	public partial class Login_Recording
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Practitest()
			
		{
			RestSharp.RestClient client = new RestSharp.RestClient(new Uri("https://eu1-prod-api.practitest.app"));
			RestSharp.RestRequest request = new RestSharp.RestRequest("/api/v2/projects.json",RestSharp.Method.GET);
			request.AddHeader("PTToken","a076fa47503cc3080423c35a4857663c97260acc");
			RestSharp.IRestResponse response = client.ExecuteAsGet(request,"Get");
			Report.Log(ReportLevel.Info, "Website", "Ramya Test", new RecordItemIndex(0));
			
			// Your recording specific initialization code goes here.
		}
		
	}
}
