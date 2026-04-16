using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.UptimeAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.uptimeAlert.UptimeAlertNotificationsSlack")]
    public class UptimeAlertNotificationsSlack : digitalocean.UptimeAlert.IUptimeAlertNotificationsSlack
    {
        /// <summary>The Slack channel to send alerts to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#channel UptimeAlert#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public string Channel
        {
            get;
            set;
        }

        /// <summary>The webhook URL for Slack.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#url UptimeAlert#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }
    }
}
