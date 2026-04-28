using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.app.AppSpecServiceLogDestinationOpenSearch")]
    public class AppSpecServiceLogDestinationOpenSearch : digitalocean.App.IAppSpecServiceLogDestinationOpenSearch
    {
        /// <summary>basic_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#basic_auth App#basic_auth}
        /// </remarks>
        [JsiiProperty(name: "basicAuth", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationOpenSearchBasicAuth\"}")]
        public digitalocean.App.IAppSpecServiceLogDestinationOpenSearchBasicAuth BasicAuth
        {
            get;
            set;
        }

        /// <summary>OpenSearch cluster name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cluster_name App#cluster_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterName
        {
            get;
            set;
        }

        /// <summary>OpenSearch endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#endpoint App#endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endpoint
        {
            get;
            set;
        }

        /// <summary>OpenSearch index name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#index_name App#index_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexName
        {
            get;
            set;
        }
    }
}
