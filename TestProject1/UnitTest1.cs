namespace TestProject1
{
    using ArchUnitNET.Domain;
    using ArchUnitNET.Fluent;
    using ArchUnitNET.Loader;
    using ConsoleApp2;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using static ArchUnitNET.Fluent.ArchRuleDefinition;

    [TestClass]
    public class UnitTest1
    {
        private const string Controller = ".Controller";
        private const string Service = ".Service";
        private const string Persistence = ".Repository";
        private static readonly Architecture Architecture = new ArchLoader().LoadAssemblies(typeof(Demo).Assembly).Build();

        private readonly IObjectProvider<IType> controllerLayer = Types().That().ResideInNamespace(Controller);
        private readonly IObjectProvider<IType> serviceLayer = Types().That().ResideInNamespace(Service);
        private readonly IObjectProvider<IType> peristenceLayer = Types().That().ResideInNamespace(Persistence);

        [TestMethod]
        public void LayeredArch_Controller()
        {
            var rule = Types().That().AreNot(this.controllerLayer)
                .Should().NotDependOnAny(this.controllerLayer);

            rule.Check(Architecture);
        }

        [TestMethod]
        public void LayeredArch_Service()
        {
            var rule = Types().That().Are(this.peristenceLayer)
                .Should().NotDependOnAny(this.serviceLayer);

            rule.Check(Architecture);
        }

        [TestMethod]
        public void LayeredArch_Persistence()
        {
            var rule = Types().That().AreNot(this.serviceLayer)
                .Should().NotDependOnAny(this.peristenceLayer);

            rule.Check(Architecture);
        }
    }
}
