using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.EventsRule
{
    [JsiiInterface(nativeType: typeof(IEventsRuleConditionDetails), fullyQualifiedName: "oci.eventsRule.EventsRuleConditionDetails")]
    public interface IEventsRuleConditionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/events_rule#data EventsRule#data}.</summary>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Data
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/events_rule#event_types EventsRule#event_types}.</summary>
        [JsiiProperty(name: "eventTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EventTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventsRuleConditionDetails), fullyQualifiedName: "oci.eventsRule.EventsRuleConditionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.EventsRule.IEventsRuleConditionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/events_rule#data EventsRule#data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Data
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/events_rule#event_types EventsRule#event_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EventTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
