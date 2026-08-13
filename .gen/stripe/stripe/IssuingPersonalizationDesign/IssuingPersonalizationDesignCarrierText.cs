using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingPersonalizationDesign
{
    [JsiiByValue(fqn: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignCarrierText")]
    public class IssuingPersonalizationDesignCarrierText : stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignCarrierText
    {
        /// <summary>The footer body text of the carrier letter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#footer_body IssuingPersonalizationDesign#footer_body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "footerBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FooterBody
        {
            get;
            set;
        }

        /// <summary>The footer title text of the carrier letter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#footer_title IssuingPersonalizationDesign#footer_title}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "footerTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FooterTitle
        {
            get;
            set;
        }

        /// <summary>The header body text of the carrier letter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#header_body IssuingPersonalizationDesign#header_body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderBody
        {
            get;
            set;
        }

        /// <summary>The header title text of the carrier letter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#header_title IssuingPersonalizationDesign#header_title}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderTitle
        {
            get;
            set;
        }
    }
}
