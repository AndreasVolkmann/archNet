// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------------

namespace ConsoleApp2.Controller
{
    using ConsoleApp2.Service;

    public class DemoController
    {
        private readonly IDemoService demoService;

        public DemoController(IDemoService demoService)
        {
            this.demoService = demoService;
        }

        public void Run()
        {
            this.demoService.Run();
        }
    }
}
