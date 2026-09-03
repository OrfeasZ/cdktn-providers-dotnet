using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExtendedLocationCustomLocation
{
    [JsiiByValue(fqn: "azurerm.dataAzurermExtendedLocationCustomLocation.DataAzurermExtendedLocationCustomLocationTimeouts")]
    public class DataAzurermExtendedLocationCustomLocationTimeouts : azurerm.DataAzurermExtendedLocationCustomLocation.IDataAzurermExtendedLocationCustomLocationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/extended_location_custom_location#read DataAzurermExtendedLocationCustomLocation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
