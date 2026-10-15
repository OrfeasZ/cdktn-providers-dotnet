using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageVersion
{
    [JsiiInterface(nativeType: typeof(ISharedImageVersionUefi), fullyQualifiedName: "azurerm.sharedImageVersion.SharedImageVersionUefi")]
    public interface ISharedImageVersionUefi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.10.0/docs/resources/shared_image_version#signature_template_names SharedImageVersion#signature_template_names}.</summary>
        [JsiiProperty(name: "signatureTemplateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SignatureTemplateNames
        {
            get;
        }

        /// <summary>additional_signatures block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.10.0/docs/resources/shared_image_version#additional_signatures SharedImageVersion#additional_signatures}
        /// </remarks>
        [JsiiProperty(name: "additionalSignatures", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures? AdditionalSignatures
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISharedImageVersionUefi), fullyQualifiedName: "azurerm.sharedImageVersion.SharedImageVersionUefi")]
        internal sealed class _Proxy : DeputyBase, azurerm.SharedImageVersion.ISharedImageVersionUefi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.10.0/docs/resources/shared_image_version#signature_template_names SharedImageVersion#signature_template_names}.</summary>
            [JsiiProperty(name: "signatureTemplateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SignatureTemplateNames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>additional_signatures block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.10.0/docs/resources/shared_image_version#additional_signatures SharedImageVersion#additional_signatures}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalSignatures", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures\"}", isOptional: true)]
            public azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures? AdditionalSignatures
            {
                get => GetInstanceProperty<azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures?>();
            }
        }
    }
}
