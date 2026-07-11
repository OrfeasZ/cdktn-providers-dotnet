using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadDomains
{
    [JsiiByValue(fqn: "azuread.dataAzureadDomains.DataAzureadDomainsTimeouts")]
    public class DataAzureadDomainsTimeouts : azuread.DataAzureadDomains.IDataAzureadDomainsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/domains#read DataAzureadDomains#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
