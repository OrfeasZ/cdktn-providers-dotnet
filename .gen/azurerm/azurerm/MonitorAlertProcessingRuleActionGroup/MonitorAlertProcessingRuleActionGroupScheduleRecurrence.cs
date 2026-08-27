using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleActionGroup
{
    [JsiiByValue(fqn: "azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupScheduleRecurrence")]
    public class MonitorAlertProcessingRuleActionGroupScheduleRecurrence : azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrence
    {
        private object? _daily;

        /// <summary>daily block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_alert_processing_rule_action_group#daily MonitorAlertProcessingRuleActionGroup#daily}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceDaily" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "daily", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupScheduleRecurrenceDaily\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Daily
        {
            get => _daily;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceDaily[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceDaily).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _daily = value;
            }
        }

        private object? _monthly;

        /// <summary>monthly block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_alert_processing_rule_action_group#monthly MonitorAlertProcessingRuleActionGroup#monthly}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceMonthly" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monthly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupScheduleRecurrenceMonthly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Monthly
        {
            get => _monthly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceMonthly[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceMonthly).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _monthly = value;
            }
        }

        private object? _weekly;

        /// <summary>weekly block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_alert_processing_rule_action_group#weekly MonitorAlertProcessingRuleActionGroup#weekly}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceWeekly" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "weekly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupScheduleRecurrenceWeekly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Weekly
        {
            get => _weekly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceWeekly[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrenceWeekly).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _weekly = value;
            }
        }
    }
}
