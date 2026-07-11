using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.DataAzapiClientConfig
{
    [JsiiByValue(fqn: "azapi.dataAzapiClientConfig.DataAzapiClientConfigTimeouts")]
    public class DataAzapiClientConfigTimeouts : azapi.DataAzapiClientConfig.IDataAzapiClientConfigTimeouts
    {
        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.10.0/docs/data-sources/client_config#read DataAzapiClientConfig#read}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
