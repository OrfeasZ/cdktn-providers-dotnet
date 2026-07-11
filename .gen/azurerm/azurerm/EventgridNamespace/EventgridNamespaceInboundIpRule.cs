using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridNamespace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridNamespace.EventgridNamespaceInboundIpRule")]
    public class EventgridNamespaceInboundIpRule : azurerm.EventgridNamespace.IEventgridNamespaceInboundIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventgrid_namespace#ip_mask EventgridNamespace#ip_mask}.</summary>
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}")]
        public string IpMask
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventgrid_namespace#action EventgridNamespace#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }
    }
}
