using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbPolicyActionsRemediationTypes), fullyQualifiedName: "cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsRemediationTypes")]
    public interface IZeroTrustCasbPolicyActionsRemediationTypes
    {
        /// <summary>The ID of the remediation type to execute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#remediation_type_id ZeroTrustCasbPolicy#remediation_type_id}
        /// </remarks>
        [JsiiProperty(name: "remediationTypeId", typeJson: "{\"primitive\":\"string\"}")]
        string RemediationTypeId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbPolicyActionsRemediationTypes), fullyQualifiedName: "cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsRemediationTypes")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsRemediationTypes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the remediation type to execute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#remediation_type_id ZeroTrustCasbPolicy#remediation_type_id}
            /// </remarks>
            [JsiiProperty(name: "remediationTypeId", typeJson: "{\"primitive\":\"string\"}")]
            public string RemediationTypeId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
