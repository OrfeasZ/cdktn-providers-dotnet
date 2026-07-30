using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExtendedLocationCustomLocation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.extendedLocationCustomLocation.ExtendedLocationCustomLocationAuthentication")]
    public class ExtendedLocationCustomLocationAuthentication : azurerm.ExtendedLocationCustomLocation.IExtendedLocationCustomLocationAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/extended_location_custom_location#value ExtendedLocationCustomLocation#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/extended_location_custom_location#type ExtendedLocationCustomLocation#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
