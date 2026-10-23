using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sharedImageVersion.SharedImageVersionUefi")]
    public class SharedImageVersionUefi : azurerm.SharedImageVersion.ISharedImageVersionUefi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/resources/shared_image_version#signature_template_names SharedImageVersion#signature_template_names}.</summary>
        [JsiiProperty(name: "signatureTemplateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SignatureTemplateNames
        {
            get;
            set;
        }

        /// <summary>additional_signatures block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/resources/shared_image_version#additional_signatures SharedImageVersion#additional_signatures}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalSignatures", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures\"}", isOptional: true)]
        public azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures? AdditionalSignatures
        {
            get;
            set;
        }
    }
}
