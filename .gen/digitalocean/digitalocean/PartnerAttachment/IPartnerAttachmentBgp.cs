using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.PartnerAttachment
{
    [JsiiInterface(nativeType: typeof(IPartnerAttachmentBgp), fullyQualifiedName: "digitalocean.partnerAttachment.PartnerAttachmentBgp")]
    public interface IPartnerAttachmentBgp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#auth_key PartnerAttachment#auth_key}.</summary>
        [JsiiProperty(name: "authKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#local_router_ip PartnerAttachment#local_router_ip}.</summary>
        [JsiiProperty(name: "localRouterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalRouterIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#peer_router_asn PartnerAttachment#peer_router_asn}.</summary>
        [JsiiProperty(name: "peerRouterAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeerRouterAsn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#peer_router_ip PartnerAttachment#peer_router_ip}.</summary>
        [JsiiProperty(name: "peerRouterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerRouterIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPartnerAttachmentBgp), fullyQualifiedName: "digitalocean.partnerAttachment.PartnerAttachmentBgp")]
        internal sealed class _Proxy : DeputyBase, digitalocean.PartnerAttachment.IPartnerAttachmentBgp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#auth_key PartnerAttachment#auth_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#local_router_ip PartnerAttachment#local_router_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localRouterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalRouterIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#peer_router_asn PartnerAttachment#peer_router_asn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerRouterAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeerRouterAsn
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/partner_attachment#peer_router_ip PartnerAttachment#peer_router_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerRouterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerRouterIp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
