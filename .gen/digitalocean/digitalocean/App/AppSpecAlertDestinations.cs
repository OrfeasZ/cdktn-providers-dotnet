using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecAlertDestinations")]
    public class AppSpecAlertDestinations : digitalocean.App.IAppSpecAlertDestinations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#emails App#emails}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Emails
        {
            get;
            set;
        }

        private object? _slackWebhooks;

        /// <summary>slack_webhooks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#slack_webhooks App#slack_webhooks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slackWebhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecAlertDestinationsSlackWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SlackWebhooks
        {
            get => _slackWebhooks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecAlertDestinationsSlackWebhooks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecAlertDestinationsSlackWebhooks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slackWebhooks = value;
            }
        }
    }
}
