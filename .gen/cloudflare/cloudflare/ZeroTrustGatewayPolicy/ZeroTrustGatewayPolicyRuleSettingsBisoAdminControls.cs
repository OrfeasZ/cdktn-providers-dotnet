using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControls")]
    public class ZeroTrustGatewayPolicyRuleSettingsBisoAdminControls : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls
    {
        /// <summary>Configure whether copy is enabled or not.</summary>
        /// <remarks>
        /// When set with "remote_only", copying isolated content from the remote browser to the user's local clipboard is disabled. When absent, copy is enabled. Only applies when <c>version == "v2"</c>.
        /// Available values: "enabled", "disabled", "remote_only".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#copy ZeroTrustGatewayPolicy#copy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "copy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Copy
        {
            get;
            set;
        }

        private object? _dcp;

        /// <summary>Set to false to enable copy-pasting. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#dcp ZeroTrustGatewayPolicy#dcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dcp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Dcp
        {
            get => _dcp;
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
                _dcp = value;
            }
        }

        private object? _dd;

        /// <summary>Set to false to enable downloading. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#dd ZeroTrustGatewayPolicy#dd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Dd
        {
            get => _dd;
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
                _dd = value;
            }
        }

        private object? _dk;

        /// <summary>Set to false to enable keyboard usage. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#dk ZeroTrustGatewayPolicy#dk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dk", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Dk
        {
            get => _dk;
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
                _dk = value;
            }
        }

        /// <summary>Configure whether downloading enabled or not.</summary>
        /// <remarks>
        /// When set with "remote_only", downloads are only available for viewing. Only applies when <c>version == "v2"</c>.
        /// Available values: "enabled", "disabled", "remote_only".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#download ZeroTrustGatewayPolicy#download}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "download", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Download
        {
            get;
            set;
        }

        private object? _dp;

        /// <summary>Set to false to enable printing. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#dp ZeroTrustGatewayPolicy#dp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Dp
        {
            get => _dp;
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
                _dp = value;
            }
        }

        private object? _du;

        /// <summary>Set to false to enable uploading. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#du ZeroTrustGatewayPolicy#du}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "du", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Du
        {
            get => _du;
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
                _du = value;
            }
        }

        /// <summary>Configure whether keyboard usage is enabled or not.</summary>
        /// <remarks>
        /// When absent, keyboard usage is enabled. Only applies when <c>version == "v2"</c>.
        /// Available values: "enabled", "disabled".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#keyboard ZeroTrustGatewayPolicy#keyboard}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyboard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Keyboard
        {
            get;
            set;
        }

        /// <summary>Configure whether pasting is enabled or not.</summary>
        /// <remarks>
        /// When set with "remote_only", pasting content from the user's local clipboard into isolated pages is disabled. When absent, paste is enabled. Only applies when <c>version == "v2"</c>.
        /// Available values: "enabled", "disabled", "remote_only".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#paste ZeroTrustGatewayPolicy#paste}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paste", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Paste
        {
            get;
            set;
        }

        /// <summary>Configure whether printing is enabled or not.</summary>
        /// <remarks>
        /// When absent, printing is enabled. Only applies when <c>version == "v2"</c>.
        /// Available values: "enabled", "disabled".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#printing ZeroTrustGatewayPolicy#printing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "printing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Printing
        {
            get;
            set;
        }

        /// <summary>Configure whether uploading is enabled or not.</summary>
        /// <remarks>
        /// When absent, uploading is enabled. Only applies when <c>version == "v2"</c>.
        /// Available values: "enabled", "disabled".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#upload ZeroTrustGatewayPolicy#upload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Upload
        {
            get;
            set;
        }

        /// <summary>Indicates which version of the browser isolation controls should apply. Available values: "v1", "v2".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#version ZeroTrustGatewayPolicy#version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
