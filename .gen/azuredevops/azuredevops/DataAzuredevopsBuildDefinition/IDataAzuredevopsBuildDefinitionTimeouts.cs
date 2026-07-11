using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsBuildDefinition
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsBuildDefinitionTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionTimeouts")]
    public interface IDataAzuredevopsBuildDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/build_definition#read DataAzuredevopsBuildDefinition#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsBuildDefinitionTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsBuildDefinition.IDataAzuredevopsBuildDefinitionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/build_definition#read DataAzuredevopsBuildDefinition#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
