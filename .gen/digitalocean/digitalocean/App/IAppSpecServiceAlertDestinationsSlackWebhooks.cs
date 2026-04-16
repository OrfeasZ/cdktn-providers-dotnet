using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceAlertDestinationsSlackWebhooks), fullyQualifiedName: "digitalocean.app.AppSpecServiceAlertDestinationsSlackWebhooks")]
    public interface IAppSpecServiceAlertDestinationsSlackWebhooks
    {
        /// <summary>The Slack channel to send notifications to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#channel App#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        string Channel
        {
            get;
        }

        /// <summary>The Slack webhook URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#url App#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceAlertDestinationsSlackWebhooks), fullyQualifiedName: "digitalocean.app.AppSpecServiceAlertDestinationsSlackWebhooks")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceAlertDestinationsSlackWebhooks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Slack channel to send notifications to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#channel App#channel}
            /// </remarks>
            [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
            public string Channel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Slack webhook URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#url App#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
