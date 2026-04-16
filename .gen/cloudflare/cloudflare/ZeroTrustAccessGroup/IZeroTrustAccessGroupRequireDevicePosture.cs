using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupRequireDevicePosture), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireDevicePosture")]
    public interface IZeroTrustAccessGroupRequireDevicePosture
    {
        /// <summary>The ID of a device posture integration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#integration_uid ZeroTrustAccessGroup#integration_uid}
        /// </remarks>
        [JsiiProperty(name: "integrationUid", typeJson: "{\"primitive\":\"string\"}")]
        string IntegrationUid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupRequireDevicePosture), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireDevicePosture")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireDevicePosture
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of a device posture integration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#integration_uid ZeroTrustAccessGroup#integration_uid}
            /// </remarks>
            [JsiiProperty(name: "integrationUid", typeJson: "{\"primitive\":\"string\"}")]
            public string IntegrationUid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
