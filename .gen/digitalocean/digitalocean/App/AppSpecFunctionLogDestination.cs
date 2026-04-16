using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecFunctionLogDestination")]
    public class AppSpecFunctionLogDestination : digitalocean.App.IAppSpecFunctionLogDestination
    {
        /// <summary>Name of the log destination.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>datadog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#datadog App#datadog}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationDatadog\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionLogDestinationDatadog? Datadog
        {
            get;
            set;
        }

        /// <summary>logtail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#logtail App#logtail}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationLogtail\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionLogDestinationLogtail? Logtail
        {
            get;
            set;
        }

        /// <summary>open_search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#open_search App#open_search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationOpenSearch\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionLogDestinationOpenSearch? OpenSearch
        {
            get;
            set;
        }

        /// <summary>papertrail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#papertrail App#papertrail}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationPapertrail\"}", isOptional: true)]
        public digitalocean.App.IAppSpecFunctionLogDestinationPapertrail? Papertrail
        {
            get;
            set;
        }
    }
}
