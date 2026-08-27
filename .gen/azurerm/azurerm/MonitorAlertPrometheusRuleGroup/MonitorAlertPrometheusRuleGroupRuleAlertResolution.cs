using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertPrometheusRuleGroup
{
    [JsiiByValue(fqn: "azurerm.monitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroupRuleAlertResolution")]
    public class MonitorAlertPrometheusRuleGroupRuleAlertResolution : azurerm.MonitorAlertPrometheusRuleGroup.IMonitorAlertPrometheusRuleGroupRuleAlertResolution
    {
        private object? _autoResolved;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_alert_prometheus_rule_group#auto_resolved MonitorAlertPrometheusRuleGroup#auto_resolved}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoResolved", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutoResolved
        {
            get => _autoResolved;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autoResolved = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_alert_prometheus_rule_group#time_to_resolve MonitorAlertPrometheusRuleGroup#time_to_resolve}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeToResolve", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeToResolve
        {
            get;
            set;
        }
    }
}
