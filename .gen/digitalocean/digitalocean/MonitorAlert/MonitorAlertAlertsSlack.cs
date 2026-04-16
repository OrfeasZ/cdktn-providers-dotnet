using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.MonitorAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.monitorAlert.MonitorAlertAlertsSlack")]
    public class MonitorAlertAlertsSlack : digitalocean.MonitorAlert.IMonitorAlertAlertsSlack
    {
        /// <summary>The Slack channel to send alerts to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/monitor_alert#channel MonitorAlert#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public string Channel
        {
            get;
            set;
        }

        /// <summary>The webhook URL for Slack.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/monitor_alert#url MonitorAlert#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }
    }
}
