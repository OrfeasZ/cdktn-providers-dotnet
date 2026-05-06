using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewaySettingsSettingsBlockPage), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage")]
    public interface IZeroTrustGatewaySettingsSettingsBlockPage
    {
        /// <summary>If mode is customized_block_page: block page background color in #rrggbb format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#background_color ZeroTrustGatewaySettings#background_color}
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

        /// <summary>Enable only cipher suites and TLS versions compliant with FIPS 140-2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#enabled ZeroTrustGatewaySettings#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>If mode is customized_block_page: block page footer text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#footer_text ZeroTrustGatewaySettings#footer_text}
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

        /// <summary>If mode is customized_block_page: block page header text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#header_text ZeroTrustGatewaySettings#header_text}
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

        /// <summary>If mode is redirect_uri: when enabled, context will be appended to target_uri as query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#include_context ZeroTrustGatewaySettings#include_context}
        /// </remarks>
        [JsiiProperty(name: "includeContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>If mode is customized_block_page: full URL to the logo file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#logo_path ZeroTrustGatewaySettings#logo_path}
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

        /// <summary>If mode is customized_block_page: admin email for users to contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mailto_address ZeroTrustGatewaySettings#mailto_address}
        /// </remarks>
        [JsiiProperty(name: "mailtoAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MailtoAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>If mode is customized_block_page: subject line for emails created from block page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mailto_subject ZeroTrustGatewaySettings#mailto_subject}
        /// </remarks>
        [JsiiProperty(name: "mailtoSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MailtoSubject
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the user is redirected to a Cloudflare-hosted block page or to a customer-provided URI. Available values: "customized_block_page", "redirect_uri".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mode ZeroTrustGatewaySettings#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>If mode is customized_block_page: block page title.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#name ZeroTrustGatewaySettings#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>If mode is customized_block_page: suppress detailed info at the bottom of the block page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#suppress_footer ZeroTrustGatewaySettings#suppress_footer}
        /// </remarks>
        [JsiiProperty(name: "suppressFooter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SuppressFooter
        {
            get
            {
                return null;
            }
        }

        /// <summary>If mode is redirect_uri: URI to which the user should be redirected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#target_uri ZeroTrustGatewaySettings#target_uri}
        /// </remarks>
        [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewaySettingsSettingsBlockPage), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If mode is customized_block_page: block page background color in #rrggbb format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#background_color ZeroTrustGatewaySettings#background_color}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackgroundColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable only cipher suites and TLS versions compliant with FIPS 140-2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#enabled ZeroTrustGatewaySettings#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If mode is customized_block_page: block page footer text.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#footer_text ZeroTrustGatewaySettings#footer_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FooterText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If mode is customized_block_page: block page header text.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#header_text ZeroTrustGatewaySettings#header_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If mode is redirect_uri: when enabled, context will be appended to target_uri as query parameters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#include_context ZeroTrustGatewaySettings#include_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeContext
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If mode is customized_block_page: full URL to the logo file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#logo_path ZeroTrustGatewaySettings#logo_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logoPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If mode is customized_block_page: admin email for users to contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mailto_address ZeroTrustGatewaySettings#mailto_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mailtoAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MailtoAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If mode is customized_block_page: subject line for emails created from block page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mailto_subject ZeroTrustGatewaySettings#mailto_subject}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mailtoSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MailtoSubject
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the user is redirected to a Cloudflare-hosted block page or to a customer-provided URI. Available values: "customized_block_page", "redirect_uri".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mode ZeroTrustGatewaySettings#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If mode is customized_block_page: block page title.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#name ZeroTrustGatewaySettings#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If mode is customized_block_page: suppress detailed info at the bottom of the block page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#suppress_footer ZeroTrustGatewaySettings#suppress_footer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suppressFooter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SuppressFooter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If mode is redirect_uri: URI to which the user should be redirected.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#target_uri ZeroTrustGatewaySettings#target_uri}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetUri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
