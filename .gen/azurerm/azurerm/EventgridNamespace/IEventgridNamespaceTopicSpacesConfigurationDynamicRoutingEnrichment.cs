using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridNamespace
{
    [JsiiInterface(nativeType: typeof(IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment), fullyQualifiedName: "azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment")]
    public interface IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventgrid_namespace#key EventgridNamespace#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventgrid_namespace#value EventgridNamespace#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment), fullyQualifiedName: "azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventgrid_namespace#key EventgridNamespace#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/eventgrid_namespace#value EventgridNamespace#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
