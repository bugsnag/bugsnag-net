﻿using Bugsnag.Message.Core;
using Bugsnag.Message.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugsnag
{
    public class Configuration
    {
        public string ApiKey { get; private set; }

        public string AppVersion { get; set; }
        public string ReleaseStage { get; set; }

        public string UserId { get; private set; }
        public string UserEmail { get; private set; }
        public string UserName { get; private set; }
        
        public bool TrimFilenames { get; set; }

        public MetaData StaticData { get; private set; }

        public Configuration(string apiKey)
        {
            ApiKey = apiKey;
            AppVersion = "1.0.0";
            ReleaseStage = "Development";
            StaticData = new MetaData();
            TrimFilenames = true;
        }

        public void SetUser(string userId, string userEmail, string userName)
        {
            UserId = userId;
            UserEmail = userEmail;
            UserName = userName;
        }
    }
}
