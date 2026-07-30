using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleScheduled
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncident")]
    public class SentinelAlertRuleScheduledIncident : azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncident
    {
        private object _createIncidentEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/sentinel_alert_rule_scheduled#create_incident_enabled SentinelAlertRuleScheduled#create_incident_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "createIncidentEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object CreateIncidentEnabled
        {
            get => _createIncidentEnabled;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createIncidentEnabled = value;
            }
        }

        /// <summary>grouping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/sentinel_alert_rule_scheduled#grouping SentinelAlertRuleScheduled#grouping}
        /// </remarks>
        [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentGrouping\"}")]
        public azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncidentGrouping Grouping
        {
            get;
            set;
        }
    }
}
