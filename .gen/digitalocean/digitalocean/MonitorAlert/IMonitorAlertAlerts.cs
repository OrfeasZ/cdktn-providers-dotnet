using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.MonitorAlert
{
    [JsiiInterface(nativeType: typeof(IMonitorAlertAlerts), fullyQualifiedName: "digitalocean.monitorAlert.MonitorAlertAlerts")]
    public interface IMonitorAlertAlerts
    {
        /// <summary>List of email addresses to sent notifications to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/monitor_alert#email MonitorAlert#email}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/monitor_alert#slack MonitorAlert#slack}
        /// </remarks>
        [JsiiProperty(name: "slack", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.monitorAlert.MonitorAlertAlertsSlack\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Slack
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAlertAlerts), fullyQualifiedName: "digitalocean.monitorAlert.MonitorAlertAlerts")]
        internal sealed class _Proxy : DeputyBase, digitalocean.MonitorAlert.IMonitorAlertAlerts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of email addresses to sent notifications to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/monitor_alert#email MonitorAlert#email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Email
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>slack block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/monitor_alert#slack MonitorAlert#slack}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slack", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.monitorAlert.MonitorAlertAlertsSlack\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Slack
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
