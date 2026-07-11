using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadNamedLocation
{
    [JsiiByValue(fqn: "azuread.dataAzureadNamedLocation.DataAzureadNamedLocationTimeouts")]
    public class DataAzureadNamedLocationTimeouts : azuread.DataAzureadNamedLocation.IDataAzureadNamedLocationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/named_location#read DataAzureadNamedLocation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
