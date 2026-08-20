using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridNamespace
{
    [JsiiInterface(nativeType: typeof(IEventgridNamespaceInboundIpRule), fullyQualifiedName: "azurerm.eventgridNamespace.EventgridNamespaceInboundIpRule")]
    public interface IEventgridNamespaceInboundIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/eventgrid_namespace#ip_mask EventgridNamespace#ip_mask}.</summary>
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}")]
        string IpMask
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/eventgrid_namespace#action EventgridNamespace#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridNamespaceInboundIpRule), fullyQualifiedName: "azurerm.eventgridNamespace.EventgridNamespaceInboundIpRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridNamespace.IEventgridNamespaceInboundIpRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/eventgrid_namespace#ip_mask EventgridNamespace#ip_mask}.</summary>
            [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}")]
            public string IpMask
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/eventgrid_namespace#action EventgridNamespace#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
