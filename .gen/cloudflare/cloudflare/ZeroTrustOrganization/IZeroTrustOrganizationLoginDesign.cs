using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustOrganization
{
    [JsiiInterface(nativeType: typeof(IZeroTrustOrganizationLoginDesign), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationLoginDesign")]
    public interface IZeroTrustOrganizationLoginDesign
    {
        /// <summary>The background color on your login page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#background_color ZeroTrustOrganization#background_color}
        /// </remarks>
        [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackgroundColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>The text at the bottom of your login page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#footer_text ZeroTrustOrganization#footer_text}
        /// </remarks>
        [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FooterText
        {
            get
            {
                return null;
            }
        }

        /// <summary>The text at the top of your login page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#header_text ZeroTrustOrganization#header_text}
        /// </remarks>
        [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeaderText
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL of the logo on your login page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#logo_path ZeroTrustOrganization#logo_path}
        /// </remarks>
        [JsiiProperty(name: "logoPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The text color on your login page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#text_color ZeroTrustOrganization#text_color}
        /// </remarks>
        [JsiiProperty(name: "textColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TextColor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustOrganizationLoginDesign), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationLoginDesign")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationLoginDesign
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The background color on your login page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#background_color ZeroTrustOrganization#background_color}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackgroundColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The text at the bottom of your login page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#footer_text ZeroTrustOrganization#footer_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FooterText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The text at the top of your login page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#header_text ZeroTrustOrganization#header_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The URL of the logo on your login page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#logo_path ZeroTrustOrganization#logo_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logoPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The text color on your login page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#text_color ZeroTrustOrganization#text_color}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "textColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TextColor
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
