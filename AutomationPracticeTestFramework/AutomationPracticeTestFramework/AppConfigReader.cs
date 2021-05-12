﻿using System;
using System.Configuration;

namespace AutomationPracticeTestFramework
{
    class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["signinpage_url"];
    }
}
