using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingPersonalizationDesign
{
    [JsiiInterface(nativeType: typeof(IIssuingPersonalizationDesignCarrierText), fullyQualifiedName: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignCarrierText")]
    public interface IIssuingPersonalizationDesignCarrierText
    {
        /// <summary>The footer body text of the carrier letter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#footer_body IssuingPersonalizationDesign#footer_body}
        /// </remarks>
        [JsiiProperty(name: "footerBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FooterBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>The footer title text of the carrier letter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#footer_title IssuingPersonalizationDesign#footer_title}
        /// </remarks>
        [JsiiProperty(name: "footerTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FooterTitle
        {
            get
            {
                return null;
            }
        }

        /// <summary>The header body text of the carrier letter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#header_body IssuingPersonalizationDesign#header_body}
        /// </remarks>
        [JsiiProperty(name: "headerBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeaderBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>The header title text of the carrier letter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#header_title IssuingPersonalizationDesign#header_title}
        /// </remarks>
        [JsiiProperty(name: "headerTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeaderTitle
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingPersonalizationDesignCarrierText), fullyQualifiedName: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignCarrierText")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignCarrierText
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The footer body text of the carrier letter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#footer_body IssuingPersonalizationDesign#footer_body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footerBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FooterBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The footer title text of the carrier letter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#footer_title IssuingPersonalizationDesign#footer_title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footerTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FooterTitle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The header body text of the carrier letter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#header_body IssuingPersonalizationDesign#header_body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The header title text of the carrier letter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#header_title IssuingPersonalizationDesign#header_title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderTitle
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
