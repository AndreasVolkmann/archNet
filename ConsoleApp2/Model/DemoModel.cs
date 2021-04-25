// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------------

namespace ConsoleApp2.Model
{
    using ConsoleApp2.Controller;

    public class DemoModel
    {
        public void Run()
        {
            var controller = new DemoController();

            controller.Run();
        }
    }
}
