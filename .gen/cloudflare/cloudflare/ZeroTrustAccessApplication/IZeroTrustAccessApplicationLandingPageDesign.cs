using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationLandingPageDesign), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationLandingPageDesign")]
    public interface IZeroTrustAccessApplicationLandingPageDesign
    {
        /// <summary>The background color of the log in button on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#button_color ZeroTrustAccessApplication#button_color}
        /// </remarks>
        [JsiiProperty(name: "buttonColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ButtonColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>The color of the text in the log in button on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#button_text_color ZeroTrustAccessApplication#button_text_color}
        /// </remarks>
        [JsiiProperty(name: "buttonTextColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ButtonTextColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL of the image shown on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#image_url ZeroTrustAccessApplication#image_url}
        /// </remarks>
        [JsiiProperty(name: "imageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The message shown on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#message ZeroTrustAccessApplication#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>The title shown on the landing page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#title ZeroTrustAccessApplication#title}
        /// </remarks>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Title
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationLandingPageDesign), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationLandingPageDesign")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationLandingPageDesign
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The background color of the log in button on the landing page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#button_color ZeroTrustAccessApplication#button_color}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buttonColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ButtonColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The color of the text in the log in button on the landing page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#button_text_color ZeroTrustAccessApplication#button_text_color}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buttonTextColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ButtonTextColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The URL of the image shown on the landing page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#image_url ZeroTrustAccessApplication#image_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The message shown on the landing page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#message ZeroTrustAccessApplication#message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The title shown on the landing page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#title ZeroTrustAccessApplication#title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Title
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
