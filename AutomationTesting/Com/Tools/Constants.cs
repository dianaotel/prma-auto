﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Com.Tools
{
    class Constants
    {

        public static String ReportPath = @"";
        //public static String ReportPath = @"C:\Users\oik\ExtentReports\";
        public static String ExtentReportFile = ReportPath + @"ExtentReport.html";
        public static String PICTURE_NAME = "SS";
        public static double WAIT_TIME_DEFAULT = 20;
        public static int WAIT_TIME = 20;

        public static int PAGE_LOAD_MAX_RETRY = 30;
    }
}
