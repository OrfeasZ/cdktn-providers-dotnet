using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActions")]
    public class ZeroTrustCasbPolicyActions : cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActions
    {
        private object? _remediationTypes;

        /// <summary>Remediation actions to execute (at most one).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#remediation_types ZeroTrustCasbPolicy#remediation_types}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsRemediationTypes" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remediationTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsRemediationTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RemediationTypes
        {
            get => _remediationTypes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsRemediationTypes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsRemediationTypes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _remediationTypes = value;
            }
        }

        private object? _webhookConfigs;

        /// <summary>Webhook actions to execute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#webhook_configs ZeroTrustCasbPolicy#webhook_configs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsWebhookConfigs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webhookConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsWebhookConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WebhookConfigs
        {
            get => _webhookConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsWebhookConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsWebhookConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _webhookConfigs = value;
            }
        }
    }
}
