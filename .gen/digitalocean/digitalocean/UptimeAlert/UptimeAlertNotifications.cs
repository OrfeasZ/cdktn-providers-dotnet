using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.UptimeAlert
{
    [JsiiByValue(fqn: "digitalocean.uptimeAlert.UptimeAlertNotifications")]
    public class UptimeAlertNotifications : digitalocean.UptimeAlert.IUptimeAlertNotifications
    {
        /// <summary>List of email addresses to sent notifications to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#email UptimeAlert#email}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#slack UptimeAlert#slack}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slack", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.uptimeAlert.UptimeAlertNotificationsSlack\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.UptimeAlert.IUptimeAlertNotificationsSlack[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.UptimeAlert.IUptimeAlertNotificationsSlack).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slack = value;
            }
        }
    }
}
