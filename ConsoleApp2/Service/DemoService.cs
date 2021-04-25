// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------------

namespace ConsoleApp2.Service
{
    using System;
    using ConsoleApp2.Repository;

    public class DemoService : IDemoService
    {
        private readonly IDemoRepository demoRepository;

        public DemoService(IDemoRepository demoRepository)
        {
            this.demoRepository = demoRepository;
        }

        public void Run()
        {
            var entity = this.demoRepository.Get("test");
            Console.Out.WriteLine(entity.Name);
        }
    }
}
