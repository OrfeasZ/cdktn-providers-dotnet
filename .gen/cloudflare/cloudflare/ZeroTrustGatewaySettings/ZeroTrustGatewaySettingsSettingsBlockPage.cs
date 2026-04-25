using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage")]
    public class ZeroTrustGatewaySettingsSettingsBlockPage : cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage
    {
        /// <summary>Specify the block page background color in `#rrggbb` format when the mode is customized_block_page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#background_color ZeroTrustGatewaySettings#background_color}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackgroundColor
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Specify whether to enable the custom block page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#enabled ZeroTrustGatewaySettings#enabled}
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

        /// <summary>Specify the block page footer text when the mode is customized_block_page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#footer_text ZeroTrustGatewaySettings#footer_text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FooterText
        {
            get;
            set;
        }

        /// <summary>Specify the block page header text when the mode is customized_block_page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#header_text ZeroTrustGatewaySettings#header_text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderText
        {
            get;
            set;
        }

        private object? _includeContext;

        /// <summary>Specify whether to append context to target_uri as query parameters. This applies only when the mode is redirect_uri.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#include_context ZeroTrustGatewaySettings#include_context}
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

        /// <summary>Specify the full URL to the logo file when the mode is customized_block_page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#logo_path ZeroTrustGatewaySettings#logo_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logoPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoPath
        {
            get;
            set;
        }

        /// <summary>Specify the admin email for users to contact when the mode is customized_block_page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#mailto_address ZeroTrustGatewaySettings#mailto_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mailtoAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MailtoAddress
        {
            get;
            set;
        }

        /// <summary>Specify the subject line for emails created from the block page when the mode is customized_block_page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#mailto_subject ZeroTrustGatewaySettings#mailto_subject}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mailtoSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MailtoSubject
        {
            get;
            set;
        }

        /// <summary>Specify whether to redirect users to a Cloudflare-hosted block page or a customer-provided URI. Available values: "", "customized_block_page", "redirect_uri".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#mode ZeroTrustGatewaySettings#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Specify the block page title when the mode is customized_block_page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#name ZeroTrustGatewaySettings#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        private object? _readOnly;

        /// <summary>Indicate that this setting was shared via the Orgs API and read only for the current account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#read_only ZeroTrustGatewaySettings#read_only}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReadOnly
        {
            get => _readOnly;
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
                _readOnly = value;
            }
        }

        /// <summary>Indicate the account tag of the account that shared this setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#source_account ZeroTrustGatewaySettings#source_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceAccount
        {
            get;
            set;
        }

        private object? _suppressFooter;

        /// <summary>Specify whether to suppress detailed information at the bottom of the block page when the mode is customized_block_page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#suppress_footer ZeroTrustGatewaySettings#suppress_footer}
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

        /// <summary>Specify the URI to redirect users to when the mode is redirect_uri.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#target_uri ZeroTrustGatewaySettings#target_uri}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetUri
        {
            get;
            set;
        }

        /// <summary>Indicate the version number of the setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_settings#version ZeroTrustGatewaySettings#version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Version
        {
            get;
            set;
        }
    }
}
