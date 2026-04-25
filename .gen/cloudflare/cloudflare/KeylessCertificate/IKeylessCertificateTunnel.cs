using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.KeylessCertificate
{
    [JsiiInterface(nativeType: typeof(IKeylessCertificateTunnel), fullyQualifiedName: "cloudflare.keylessCertificate.KeylessCertificateTunnel")]
    public interface IKeylessCertificateTunnel
    {
        /// <summary>Private IP of the Key Server Host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/keyless_certificate#private_ip KeylessCertificate#private_ip}
        /// </remarks>
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateIp
        {
            get;
        }

        /// <summary>Cloudflare Tunnel Virtual Network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/keyless_certificate#vnet_id KeylessCertificate#vnet_id}
        /// </remarks>
        [JsiiProperty(name: "vnetId", typeJson: "{\"primitive\":\"string\"}")]
        string VnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKeylessCertificateTunnel), fullyQualifiedName: "cloudflare.keylessCertificate.KeylessCertificateTunnel")]
        internal sealed class _Proxy : DeputyBase, cloudflare.KeylessCertificate.IKeylessCertificateTunnel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Private IP of the Key Server Host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/keyless_certificate#private_ip KeylessCertificate#private_ip}
            /// </remarks>
            [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateIp
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Cloudflare Tunnel Virtual Network ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/keyless_certificate#vnet_id KeylessCertificate#vnet_id}
            /// </remarks>
            [JsiiProperty(name: "vnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string VnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
