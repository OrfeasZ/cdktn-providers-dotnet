using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionJobsDependencies), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionJobsDependencies")]
    public interface IBuildDefinitionJobsDependencies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#scope BuildDefinition#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionJobsDependencies), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionJobsDependencies")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionJobsDependencies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/build_definition#scope BuildDefinition#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
