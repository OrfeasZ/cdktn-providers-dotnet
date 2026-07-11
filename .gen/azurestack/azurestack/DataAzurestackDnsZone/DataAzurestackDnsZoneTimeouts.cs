using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackDnsZone
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackDnsZone.DataAzurestackDnsZoneTimeouts")]
    public class DataAzurestackDnsZoneTimeouts : azurestack.DataAzurestackDnsZone.IDataAzurestackDnsZoneTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/dns_zone#read DataAzurestackDnsZone#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
