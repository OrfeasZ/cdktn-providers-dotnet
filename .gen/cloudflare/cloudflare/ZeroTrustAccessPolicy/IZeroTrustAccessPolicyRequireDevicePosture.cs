using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyRequireDevicePosture), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireDevicePosture")]
    public interface IZeroTrustAccessPolicyRequireDevicePosture
    {
        /// <summary>The ID of a device posture integration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#integration_uid ZeroTrustAccessPolicy#integration_uid}
        /// </remarks>
        [JsiiProperty(name: "integrationUid", typeJson: "{\"primitive\":\"string\"}")]
        string IntegrationUid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyRequireDevicePosture), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireDevicePosture")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireDevicePosture
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of a device posture integration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#integration_uid ZeroTrustAccessPolicy#integration_uid}
            /// </remarks>
            [JsiiProperty(name: "integrationUid", typeJson: "{\"primitive\":\"string\"}")]
            public string IntegrationUid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
