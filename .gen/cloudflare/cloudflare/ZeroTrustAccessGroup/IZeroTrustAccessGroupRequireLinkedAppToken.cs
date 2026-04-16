using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupRequireLinkedAppToken), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireLinkedAppToken")]
    public interface IZeroTrustAccessGroupRequireLinkedAppToken
    {
        /// <summary>The ID of an Access OIDC SaaS application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#app_uid ZeroTrustAccessGroup#app_uid}
        /// </remarks>
        [JsiiProperty(name: "appUid", typeJson: "{\"primitive\":\"string\"}")]
        string AppUid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupRequireLinkedAppToken), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireLinkedAppToken")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireLinkedAppToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of an Access OIDC SaaS application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#app_uid ZeroTrustAccessGroup#app_uid}
            /// </remarks>
            [JsiiProperty(name: "appUid", typeJson: "{\"primitive\":\"string\"}")]
            public string AppUid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
