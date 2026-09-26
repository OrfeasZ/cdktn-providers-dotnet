using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbPolicyActions), fullyQualifiedName: "cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActions")]
    public interface IZeroTrustCasbPolicyActions
    {
        /// <summary>Remediation actions to execute (at most one).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#remediation_types ZeroTrustCasbPolicy#remediation_types}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsRemediationTypes" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "remediationTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsRemediationTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RemediationTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Webhook actions to execute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#webhook_configs ZeroTrustCasbPolicy#webhook_configs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsWebhookConfigs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "webhookConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsWebhookConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebhookConfigs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbPolicyActions), fullyQualifiedName: "cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Remediation actions to execute (at most one).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#remediation_types ZeroTrustCasbPolicy#remediation_types}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsRemediationTypes" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remediationTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsRemediationTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RemediationTypes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Webhook actions to execute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#webhook_configs ZeroTrustCasbPolicy#webhook_configs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsWebhookConfigs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhookConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsWebhookConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WebhookConfigs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
