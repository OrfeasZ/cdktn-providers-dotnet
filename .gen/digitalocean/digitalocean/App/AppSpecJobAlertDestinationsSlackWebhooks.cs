using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecJobAlertDestinationsSlackWebhooks")]
    public class AppSpecJobAlertDestinationsSlackWebhooks : digitalocean.App.IAppSpecJobAlertDestinationsSlackWebhooks
    {
        /// <summary>The Slack channel to send notifications to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#channel App#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public string Channel
        {
            get;
            set;
        }

        /// <summary>The Slack webhook URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#url App#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }
    }
}
