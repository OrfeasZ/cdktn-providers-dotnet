using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage")]
    public class ZeroTrustGatewaySettingsSettingsBlockPage : cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage
    {
        /// <summary>If mode is customized_block_page: block page background color in #rrggbb format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#background_color ZeroTrustGatewaySettings#background_color}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackgroundColor
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Enable only cipher suites and TLS versions compliant with FIPS 140-2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#enabled ZeroTrustGatewaySettings#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>If mode is customized_block_page: block page footer text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#footer_text ZeroTrustGatewaySettings#footer_text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FooterText
        {
            get;
            set;
        }

        /// <summary>If mode is customized_block_page: block page header text.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#header_text ZeroTrustGatewaySettings#header_text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderText
        {
            get;
            set;
        }

        private object? _includeContext;

        /// <summary>If mode is redirect_uri: when enabled, context will be appended to target_uri as query parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#include_context ZeroTrustGatewaySettings#include_context}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeContext
        {
            get => _includeContext;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includeContext = value;
            }
        }

        /// <summary>If mode is customized_block_page: full URL to the logo file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#logo_path ZeroTrustGatewaySettings#logo_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logoPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoPath
        {
            get;
            set;
        }

        /// <summary>If mode is customized_block_page: admin email for users to contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mailto_address ZeroTrustGatewaySettings#mailto_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mailtoAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MailtoAddress
        {
            get;
            set;
        }

        /// <summary>If mode is customized_block_page: subject line for emails created from block page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mailto_subject ZeroTrustGatewaySettings#mailto_subject}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mailtoSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MailtoSubject
        {
            get;
            set;
        }

        /// <summary>Controls whether the user is redirected to a Cloudflare-hosted block page or to a customer-provided URI. Available values: "customized_block_page", "redirect_uri".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#mode ZeroTrustGatewaySettings#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>If mode is customized_block_page: block page title.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#name ZeroTrustGatewaySettings#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        private object? _suppressFooter;

        /// <summary>If mode is customized_block_page: suppress detailed info at the bottom of the block page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#suppress_footer ZeroTrustGatewaySettings#suppress_footer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suppressFooter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SuppressFooter
        {
            get => _suppressFooter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _suppressFooter = value;
            }
        }

        /// <summary>If mode is redirect_uri: URI to which the user should be redirected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_settings#target_uri ZeroTrustGatewaySettings#target_uri}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetUri
        {
            get;
            set;
        }
    }
}
