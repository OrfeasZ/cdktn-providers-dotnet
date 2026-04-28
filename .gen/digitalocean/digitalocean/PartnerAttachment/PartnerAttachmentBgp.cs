using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.PartnerAttachment
{
    [JsiiByValue(fqn: "digitalocean.partnerAttachment.PartnerAttachmentBgp")]
    public class PartnerAttachmentBgp : digitalocean.PartnerAttachment.IPartnerAttachmentBgp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/partner_attachment#auth_key PartnerAttachment#auth_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/partner_attachment#local_router_ip PartnerAttachment#local_router_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localRouterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalRouterIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/partner_attachment#peer_router_asn PartnerAttachment#peer_router_asn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerRouterAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeerRouterAsn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/partner_attachment#peer_router_ip PartnerAttachment#peer_router_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerRouterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerRouterIp
        {
            get;
            set;
        }
    }
}
