using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.KeylessCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.keylessCertificate.KeylessCertificateTunnel")]
    public class KeylessCertificateTunnel : cloudflare.KeylessCertificate.IKeylessCertificateTunnel
    {
        /// <summary>Private IP of the Key Server Host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/keyless_certificate#private_ip KeylessCertificate#private_ip}
        /// </remarks>
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateIp
        {
            get;
            set;
        }

        /// <summary>Cloudflare Tunnel Virtual Network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/keyless_certificate#vnet_id KeylessCertificate#vnet_id}
        /// </remarks>
        [JsiiProperty(name: "vnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string VnetId
        {
            get;
            set;
        }
    }
}
