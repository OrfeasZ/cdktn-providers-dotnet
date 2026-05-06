using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.EventsRule
{
    [JsiiInterface(nativeType: typeof(IEventsRuleActions), fullyQualifiedName: "oci.eventsRule.EventsRuleActions")]
    public interface IEventsRuleActions
    {
        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/events_rule#actions EventsRule#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.eventsRule.EventsRuleActionsActions\"},\"kind\":\"array\"}}]}}")]
        object Actions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventsRuleActions), fullyQualifiedName: "oci.eventsRule.EventsRuleActions")]
        internal sealed class _Proxy : DeputyBase, oci.EventsRule.IEventsRuleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>actions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/events_rule#actions EventsRule#actions}
            /// </remarks>
            [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.eventsRule.EventsRuleActionsActions\"},\"kind\":\"array\"}}]}}")]
            public object Actions
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
