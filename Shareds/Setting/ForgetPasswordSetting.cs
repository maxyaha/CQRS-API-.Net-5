﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Net.Sockets;

namespace Shareds.Setting
{
    public class ForgetPasswordSetting
    {
        public string Url { get; set; }

    }
    public static class ForgetPasswordService
    {
        static IServiceProvider services = null;

        /// <summary>
        /// Provides static access to the framework's services provider
        /// </summary>
        public static IServiceProvider Services { get { return services; } set { services = services is null ? value : throw new Exception("Can't set once a value has already been set."); } }
        /// <summary>
        /// Provides static access to the current HttpContext
        /// </summary>
        public static HttpContext Context { get { return (services.GetService(typeof(IHttpContextAccessor)) as IHttpContextAccessor)?.HttpContext; } }
        /// <summary>
        /// 
        /// </summary>
        public static IHostingEnvironment HostingEnvironment { get { return services.GetService(typeof(IHostingEnvironment)) as IHostingEnvironment; } }
        /// <summary>
        /// Configuration settings from appsetting.json.
        /// </summary>
        public static ForgetPasswordSetting Config { get { return (services.GetService(typeof(IOptionsMonitor<ForgetPasswordSetting>)) as IOptionsMonitor<ForgetPasswordSetting>).CurrentValue; } }

    }
}
