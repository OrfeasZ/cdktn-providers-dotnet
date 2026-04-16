using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessAiControlsMcpPortal
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServers")]
    public class ZeroTrustAccessAiControlsMcpPortalServers : cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServers
    {
        /// <summary>server id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_ai_controls_mcp_portal#server_id ZeroTrustAccessAiControlsMcpPortal#server_id}
        /// </remarks>
        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"string\"}")]
        public string ServerId
        {
            get;
            set;
        }

        private object? _defaultDisabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_ai_controls_mcp_portal#default_disabled ZeroTrustAccessAiControlsMcpPortal#default_disabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DefaultDisabled
        {
            get => _defaultDisabled;
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
                _defaultDisabled = value;
            }
        }

        private object? _onBehalf;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_ai_controls_mcp_portal#on_behalf ZeroTrustAccessAiControlsMcpPortal#on_behalf}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onBehalf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OnBehalf
        {
            get => _onBehalf;
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
                _onBehalf = value;
            }
        }

        private object? _updatedPrompts;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_ai_controls_mcp_portal#updated_prompts ZeroTrustAccessAiControlsMcpPortal#updated_prompts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updatedPrompts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedPrompts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UpdatedPrompts
        {
            get => _updatedPrompts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedPrompts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedPrompts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _updatedPrompts = value;
            }
        }

        private object? _updatedTools;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_ai_controls_mcp_portal#updated_tools ZeroTrustAccessAiControlsMcpPortal#updated_tools}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updatedTools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessAiControlsMcpPortal.ZeroTrustAccessAiControlsMcpPortalServersUpdatedTools\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UpdatedTools
        {
            get => _updatedTools;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedTools[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessAiControlsMcpPortal.IZeroTrustAccessAiControlsMcpPortalServersUpdatedTools).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _updatedTools = value;
            }
        }
    }
}
