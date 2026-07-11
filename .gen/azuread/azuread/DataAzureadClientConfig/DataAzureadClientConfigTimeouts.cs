using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadClientConfig
{
    [JsiiByValue(fqn: "azuread.dataAzureadClientConfig.DataAzureadClientConfigTimeouts")]
    public class DataAzureadClientConfigTimeouts : azuread.DataAzureadClientConfig.IDataAzureadClientConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/client_config#read DataAzureadClientConfig#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
