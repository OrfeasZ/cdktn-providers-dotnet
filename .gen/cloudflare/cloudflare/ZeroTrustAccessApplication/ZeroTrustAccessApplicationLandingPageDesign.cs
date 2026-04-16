using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationLandingPageDesign")]
    public class ZeroTrustAccessApplicationLandingPageDesign : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationLandingPageDesign
    {
        /// <summary>The background color of the log in button on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#button_color ZeroTrustAccessApplication#button_color}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buttonColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ButtonColor
        {
            get;
            set;
        }

        /// <summary>The color of the text in the log in button on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#button_text_color ZeroTrustAccessApplication#button_text_color}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buttonTextColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ButtonTextColor
        {
            get;
            set;
        }

        /// <summary>The URL of the image shown on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#image_url ZeroTrustAccessApplication#image_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageUrl
        {
            get;
            set;
        }

        /// <summary>The message shown on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#message ZeroTrustAccessApplication#message}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>The title shown on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#title ZeroTrustAccessApplication#title}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Title
        {
            get;
            set;
        }
    }
}
