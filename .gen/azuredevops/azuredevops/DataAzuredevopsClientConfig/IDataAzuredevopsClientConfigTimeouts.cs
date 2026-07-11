using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsClientConfig
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsClientConfigTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsClientConfig.DataAzuredevopsClientConfigTimeouts")]
    public interface IDataAzuredevopsClientConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/client_config#read DataAzuredevopsClientConfig#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsClientConfigTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsClientConfig.DataAzuredevopsClientConfigTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsClientConfig.IDataAzuredevopsClientConfigTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/client_config#read DataAzuredevopsClientConfig#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
