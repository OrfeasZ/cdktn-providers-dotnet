using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridPartnerNamespace
{
    [JsiiInterface(nativeType: typeof(IEventgridPartnerNamespaceInboundIpRule), fullyQualifiedName: "azurerm.eventgridPartnerNamespace.EventgridPartnerNamespaceInboundIpRule")]
    public interface IEventgridPartnerNamespaceInboundIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/eventgrid_partner_namespace#ip_mask EventgridPartnerNamespace#ip_mask}.</summary>
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}")]
        string IpMask
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/eventgrid_partner_namespace#action EventgridPartnerNamespace#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridPartnerNamespaceInboundIpRule), fullyQualifiedName: "azurerm.eventgridPartnerNamespace.EventgridPartnerNamespaceInboundIpRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridPartnerNamespace.IEventgridPartnerNamespaceInboundIpRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/eventgrid_partner_namespace#ip_mask EventgridPartnerNamespace#ip_mask}.</summary>
            [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}")]
            public string IpMask
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/eventgrid_partner_namespace#action EventgridPartnerNamespace#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
