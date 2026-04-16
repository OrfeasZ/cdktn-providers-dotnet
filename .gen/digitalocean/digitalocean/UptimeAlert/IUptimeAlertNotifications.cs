using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.UptimeAlert
{
    [JsiiInterface(nativeType: typeof(IUptimeAlertNotifications), fullyQualifiedName: "digitalocean.uptimeAlert.UptimeAlertNotifications")]
    public interface IUptimeAlertNotifications
    {
        /// <summary>List of email addresses to sent notifications to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#email UptimeAlert#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>slack block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#slack UptimeAlert#slack}
        /// </remarks>
        [JsiiProperty(name: "slack", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.uptimeAlert.UptimeAlertNotificationsSlack\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Slack
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IUptimeAlertNotifications), fullyQualifiedName: "digitalocean.uptimeAlert.UptimeAlertNotifications")]
        internal sealed class _Proxy : DeputyBase, digitalocean.UptimeAlert.IUptimeAlertNotifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of email addresses to sent notifications to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#email UptimeAlert#email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Email
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>slack block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/uptime_alert#slack UptimeAlert#slack}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slack", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.uptimeAlert.UptimeAlertNotificationsSlack\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Slack
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
