﻿using Nancy;

namespace $safeprojectname$
{
    public class HomeModule : NancyModule
    {
        public HomeModule(IAppConfiguration appConfig)
        {
            Get("/", args => "Hello from Nancy running on CoreCLR");


        }
    }
}
