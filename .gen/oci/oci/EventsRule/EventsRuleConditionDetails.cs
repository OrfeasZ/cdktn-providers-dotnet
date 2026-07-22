using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.EventsRule
{
    [JsiiByValue(fqn: "oci.eventsRule.EventsRuleConditionDetails")]
    public class EventsRuleConditionDetails : oci.EventsRule.IEventsRuleConditionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/events_rule#data EventsRule#data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Data
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/events_rule#event_types EventsRule#event_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EventTypes
        {
            get;
            set;
        }
    }
}
