// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------------

namespace TestProject1
{
    using ConsoleApp2.Controller;
    using ConsoleApp2.Repository;
    using ConsoleApp2.Service;
    using FakeItEasy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DemoTests
    {
        [TestMethod]
        public void DemoService_Run()
        {
            // Arrange
            var repository = A.Fake<IDemoRepository>();
            var demoService = new DemoService(repository);

            // Act
            demoService.Run();

            // Assert
        }

        [TestMethod]
        public void DemoController_Run()
        {
            // Arrange
            var service = A.Fake<IDemoService>();
            var controller = new DemoController(service);

            // Act
            controller.Run();

            // Assert
        }
    }
}
