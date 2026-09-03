using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridSystemTopicEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange), fullyQualifiedName: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange")]
    public interface IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/eventgrid_system_topic_event_subscription#key EventgridSystemTopicEventSubscription#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/eventgrid_system_topic_event_subscription#values EventgridSystemTopicEventSubscription#values}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or ((double)[])[]</para>
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}")]
        object Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange), fullyQualifiedName: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/eventgrid_system_topic_event_subscription#key EventgridSystemTopicEventSubscription#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/eventgrid_system_topic_event_subscription#values EventgridSystemTopicEventSubscription#values}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or ((double)[])[]</para>
            /// </remarks>
            [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}")]
            public object Values
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
