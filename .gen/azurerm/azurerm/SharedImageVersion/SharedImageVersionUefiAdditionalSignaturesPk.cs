using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPk")]
    public class SharedImageVersionUefiAdditionalSignaturesPk : azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/resources/shared_image_version#type SharedImageVersion#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/resources/shared_image_version#values_base64 SharedImageVersion#values_base64}.</summary>
        [JsiiProperty(name: "valuesBase64", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ValuesBase64
        {
            get;
            set;
        }
    }
}
