using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsEnvironment
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsEnvironmentTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsEnvironment.DataAzuredevopsEnvironmentTimeouts")]
    public interface IDataAzuredevopsEnvironmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/environment#read DataAzuredevopsEnvironment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsEnvironmentTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsEnvironment.DataAzuredevopsEnvironmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsEnvironment.IDataAzuredevopsEnvironmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/environment#read DataAzuredevopsEnvironment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
