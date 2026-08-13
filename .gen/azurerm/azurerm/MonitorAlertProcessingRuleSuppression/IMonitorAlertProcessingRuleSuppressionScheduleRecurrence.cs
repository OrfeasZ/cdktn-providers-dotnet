using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleSuppression
{
    [JsiiInterface(nativeType: typeof(IMonitorAlertProcessingRuleSuppressionScheduleRecurrence), fullyQualifiedName: "azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrence")]
    public interface IMonitorAlertProcessingRuleSuppressionScheduleRecurrence
    {
        /// <summary>daily block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_alert_processing_rule_suppression#daily MonitorAlertProcessingRuleSuppression#daily}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "daily", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Daily
        {
            get
            {
                return null;
            }
        }

        /// <summary>monthly block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_alert_processing_rule_suppression#monthly MonitorAlertProcessingRuleSuppression#monthly}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "monthly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Monthly
        {
            get
            {
                return null;
            }
        }

        /// <summary>weekly block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_alert_processing_rule_suppression#weekly MonitorAlertProcessingRuleSuppression#weekly}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "weekly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Weekly
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAlertProcessingRuleSuppressionScheduleRecurrence), fullyQualifiedName: "azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrence")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>daily block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_alert_processing_rule_suppression#daily MonitorAlertProcessingRuleSuppression#daily}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "daily", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Daily
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>monthly block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_alert_processing_rule_suppression#monthly MonitorAlertProcessingRuleSuppression#monthly}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monthly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Monthly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>weekly block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_alert_processing_rule_suppression#weekly MonitorAlertProcessingRuleSuppression#weekly}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weekly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Weekly
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
