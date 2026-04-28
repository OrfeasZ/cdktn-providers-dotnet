using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecJobAlertDestinations), fullyQualifiedName: "digitalocean.app.AppSpecJobAlertDestinations")]
    public interface IAppSpecJobAlertDestinations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#emails App#emails}.</summary>
        [JsiiProperty(name: "emails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Emails
        {
            get
            {
                return null;
            }
        }

        /// <summary>slack_webhooks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#slack_webhooks App#slack_webhooks}
        /// </remarks>
        [JsiiProperty(name: "slackWebhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecJobAlertDestinationsSlackWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SlackWebhooks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecJobAlertDestinations), fullyQualifiedName: "digitalocean.app.AppSpecJobAlertDestinations")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecJobAlertDestinations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#emails App#emails}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Emails
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>slack_webhooks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#slack_webhooks App#slack_webhooks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slackWebhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecJobAlertDestinationsSlackWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SlackWebhooks
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
