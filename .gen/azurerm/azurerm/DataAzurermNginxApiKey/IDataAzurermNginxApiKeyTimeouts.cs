using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNginxApiKey
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNginxApiKeyTimeouts), fullyQualifiedName: "azurerm.dataAzurermNginxApiKey.DataAzurermNginxApiKeyTimeouts")]
    public interface IDataAzurermNginxApiKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/nginx_api_key#read DataAzurermNginxApiKey#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNginxApiKeyTimeouts), fullyQualifiedName: "azurerm.dataAzurermNginxApiKey.DataAzurermNginxApiKeyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNginxApiKey.IDataAzurermNginxApiKeyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/nginx_api_key#read DataAzurermNginxApiKey#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
