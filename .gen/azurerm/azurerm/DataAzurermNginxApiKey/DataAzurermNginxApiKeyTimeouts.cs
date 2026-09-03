using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNginxApiKey
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNginxApiKey.DataAzurermNginxApiKeyTimeouts")]
    public class DataAzurermNginxApiKeyTimeouts : azurerm.DataAzurermNginxApiKey.IDataAzurermNginxApiKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/nginx_api_key#read DataAzurermNginxApiKey#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
