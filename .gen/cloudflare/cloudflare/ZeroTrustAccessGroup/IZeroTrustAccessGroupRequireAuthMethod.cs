using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupRequireAuthMethod), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireAuthMethod")]
    public interface IZeroTrustAccessGroupRequireAuthMethod
    {
        /// <summary>The type of authentication method https://datatracker.ietf.org/doc/html/rfc8176#section-2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#auth_method ZeroTrustAccessGroup#auth_method}
        /// </remarks>
        [JsiiProperty(name: "authMethod", typeJson: "{\"primitive\":\"string\"}")]
        string AuthMethod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupRequireAuthMethod), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireAuthMethod")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireAuthMethod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of authentication method https://datatracker.ietf.org/doc/html/rfc8176#section-2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#auth_method ZeroTrustAccessGroup#auth_method}
            /// </remarks>
            [JsiiProperty(name: "authMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthMethod
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
