// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------------

namespace ConsoleApp2.Repository
{
    using ConsoleApp2.Controller;
    using ConsoleApp2.Entity;

    /// <inheritdoc />
    public class DemoRepository : IDemoRepository
    {
        private readonly DemoController controller; // violates architecture controller / persistence rule

        public DemoRepository(DemoController controller)
        {
            this.controller = controller;
        }

        /// <inheritdoc/>
        public DemoEntity Get(string id) => new ();
    }
}
