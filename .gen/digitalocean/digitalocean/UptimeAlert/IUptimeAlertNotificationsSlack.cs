using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.UptimeAlert
{
    [JsiiInterface(nativeType: typeof(IUptimeAlertNotificationsSlack), fullyQualifiedName: "digitalocean.uptimeAlert.UptimeAlertNotificationsSlack")]
    public interface IUptimeAlertNotificationsSlack
    {
        /// <summary>The Slack channel to send alerts to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#channel UptimeAlert#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        string Channel
        {
            get;
        }

        /// <summary>The webhook URL for Slack.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#url UptimeAlert#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IUptimeAlertNotificationsSlack), fullyQualifiedName: "digitalocean.uptimeAlert.UptimeAlertNotificationsSlack")]
        internal sealed class _Proxy : DeputyBase, digitalocean.UptimeAlert.IUptimeAlertNotificationsSlack
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Slack channel to send alerts to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#channel UptimeAlert#channel}
            /// </remarks>
            [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
            public string Channel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The webhook URL for Slack.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#url UptimeAlert#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
