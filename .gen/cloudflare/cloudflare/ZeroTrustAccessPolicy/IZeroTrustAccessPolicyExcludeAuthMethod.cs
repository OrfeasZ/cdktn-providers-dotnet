using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessPolicyExcludeAuthMethod), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAuthMethod")]
    public interface IZeroTrustAccessPolicyExcludeAuthMethod
    {
        /// <summary>The type of authentication method https://datatracker.ietf.org/doc/html/rfc8176#section-2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}
        /// </remarks>
        [JsiiProperty(name: "authMethod", typeJson: "{\"primitive\":\"string\"}")]
        string AuthMethod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessPolicyExcludeAuthMethod), fullyQualifiedName: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeAuthMethod")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeAuthMethod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of authentication method https://datatracker.ietf.org/doc/html/rfc8176#section-2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#auth_method ZeroTrustAccessPolicy#auth_method}
            /// </remarks>
            [JsiiProperty(name: "authMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthMethod
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
