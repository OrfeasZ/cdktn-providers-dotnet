using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorScheduledQueryRulesAlertV2
{
    [JsiiInterface(nativeType: typeof(IMonitorScheduledQueryRulesAlertV2Action), fullyQualifiedName: "azurerm.monitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2Action")]
    public interface IMonitorScheduledQueryRulesAlertV2Action
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_scheduled_query_rules_alert_v2#action_groups MonitorScheduledQueryRulesAlertV2#action_groups}.</summary>
        [JsiiProperty(name: "actionGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ActionGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_scheduled_query_rules_alert_v2#custom_properties MonitorScheduledQueryRulesAlertV2#custom_properties}.</summary>
        [JsiiProperty(name: "customProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CustomProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_scheduled_query_rules_alert_v2#email_subject MonitorScheduledQueryRulesAlertV2#email_subject}.</summary>
        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailSubject
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorScheduledQueryRulesAlertV2Action), fullyQualifiedName: "azurerm.monitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2Action")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorScheduledQueryRulesAlertV2.IMonitorScheduledQueryRulesAlertV2Action
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_scheduled_query_rules_alert_v2#action_groups MonitorScheduledQueryRulesAlertV2#action_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ActionGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_scheduled_query_rules_alert_v2#custom_properties MonitorScheduledQueryRulesAlertV2#custom_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CustomProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_scheduled_query_rules_alert_v2#email_subject MonitorScheduledQueryRulesAlertV2#email_subject}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailSubject
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
