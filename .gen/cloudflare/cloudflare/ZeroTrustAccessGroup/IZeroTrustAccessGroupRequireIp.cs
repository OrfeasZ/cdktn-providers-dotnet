using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessGroupRequireIp), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireIp")]
    public interface IZeroTrustAccessGroupRequireIp
    {
        /// <summary>An IPv4 or IPv6 CIDR block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        string Ip
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessGroupRequireIp), fullyQualifiedName: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupRequireIp")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupRequireIp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An IPv4 or IPv6 CIDR block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_group#ip ZeroTrustAccessGroup#ip}
            /// </remarks>
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
            public string Ip
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
