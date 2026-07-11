using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadClientConfig
{
    [JsiiInterface(nativeType: typeof(IDataAzureadClientConfigTimeouts), fullyQualifiedName: "azuread.dataAzureadClientConfig.DataAzureadClientConfigTimeouts")]
    public interface IDataAzureadClientConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/client_config#read DataAzureadClientConfig#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadClientConfigTimeouts), fullyQualifiedName: "azuread.dataAzureadClientConfig.DataAzureadClientConfigTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadClientConfig.IDataAzureadClientConfigTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/client_config#read DataAzureadClientConfig#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
