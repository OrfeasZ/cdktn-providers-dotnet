using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackClientConfig
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackClientConfigTimeouts), fullyQualifiedName: "azurestack.dataAzurestackClientConfig.DataAzurestackClientConfigTimeouts")]
    public interface IDataAzurestackClientConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/client_config#read DataAzurestackClientConfig#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackClientConfigTimeouts), fullyQualifiedName: "azurestack.dataAzurestackClientConfig.DataAzurestackClientConfigTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackClientConfig.IDataAzurestackClientConfigTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/client_config#read DataAzurestackClientConfig#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
