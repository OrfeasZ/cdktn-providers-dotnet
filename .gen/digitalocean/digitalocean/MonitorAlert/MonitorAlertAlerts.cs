using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.MonitorAlert
{
    [JsiiByValue(fqn: "digitalocean.monitorAlert.MonitorAlertAlerts")]
    public class MonitorAlertAlerts : digitalocean.MonitorAlert.IMonitorAlertAlerts
    {
        /// <summary>List of email addresses to sent notifications to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/monitor_alert#email MonitorAlert#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Email
        {
            get;
            set;
        }

        private object? _slack;

        /// <summary>slack block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/monitor_alert#slack MonitorAlert#slack}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slack", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.monitorAlert.MonitorAlertAlertsSlack\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Slack
        {
            get => _slack;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.MonitorAlert.IMonitorAlertAlertsSlack[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.MonitorAlert.IMonitorAlertAlertsSlack).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slack = value;
            }
        }
    }
}
