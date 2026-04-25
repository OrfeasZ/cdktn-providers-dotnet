using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupIncludeServiceToken), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceToken")]
    public interface IZeroTrustAccessGroupIncludeServiceToken
    {
        /// <summary>The ID of a Service Token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#token_id ZeroTrustAccessGroup#token_id}
        /// </remarks>
        [JsiiProperty(name: "tokenId", typeJson: "{\"primitive\":\"string\"}")]
        string TokenId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupIncludeServiceToken), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceToken")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeServiceToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of a Service Token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#token_id ZeroTrustAccessGroup#token_id}
            /// </remarks>
            [JsiiProperty(name: "tokenId", typeJson: "{\"primitive\":\"string\"}")]
            public string TokenId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
