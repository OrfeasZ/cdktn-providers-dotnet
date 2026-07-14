using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridPartnerNamespace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridPartnerNamespace.EventgridPartnerNamespaceInboundIpRule")]
    public class EventgridPartnerNamespaceInboundIpRule : azurerm.EventgridPartnerNamespace.IEventgridPartnerNamespaceInboundIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_namespace#ip_mask EventgridPartnerNamespace#ip_mask}.</summary>
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}")]
        public string IpMask
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_namespace#action EventgridPartnerNamespace#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }
    }
}
