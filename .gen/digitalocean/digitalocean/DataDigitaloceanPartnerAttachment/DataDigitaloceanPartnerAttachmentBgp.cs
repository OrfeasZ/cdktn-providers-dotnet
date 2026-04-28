using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanPartnerAttachment
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgp")]
    public class DataDigitaloceanPartnerAttachmentBgp : digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentBgp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/partner_attachment#local_router_ip DataDigitaloceanPartnerAttachment#local_router_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localRouterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalRouterIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/partner_attachment#peer_router_asn DataDigitaloceanPartnerAttachment#peer_router_asn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerRouterAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeerRouterAsn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/partner_attachment#peer_router_ip DataDigitaloceanPartnerAttachment#peer_router_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerRouterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerRouterIp
        {
            get;
            set;
        }
    }
}
