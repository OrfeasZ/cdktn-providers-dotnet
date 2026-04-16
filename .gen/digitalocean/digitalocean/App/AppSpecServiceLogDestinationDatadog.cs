using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecServiceLogDestinationDatadog")]
    public class AppSpecServiceLogDestinationDatadog : digitalocean.App.IAppSpecServiceLogDestinationDatadog
    {
        /// <summary>Datadog API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#api_key App#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiKey
        {
            get;
            set;
        }

        /// <summary>Datadog HTTP log intake endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#endpoint App#endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endpoint
        {
            get;
            set;
        }
    }
}
