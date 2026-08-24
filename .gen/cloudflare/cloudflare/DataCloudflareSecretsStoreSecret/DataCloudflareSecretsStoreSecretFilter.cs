using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSecretsStoreSecret
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareSecretsStoreSecret.DataCloudflareSecretsStoreSecretFilter")]
    public class DataCloudflareSecretsStoreSecretFilter : cloudflare.DataCloudflareSecretsStoreSecret.IDataCloudflareSecretsStoreSecretFilter
    {
        /// <summary>Direction to sort objects. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/secrets_store_secret#direction DataCloudflareSecretsStoreSecret#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Order secrets by values in the given field. Available values: "name", "comment", "created", "modified", "status".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/secrets_store_secret#order DataCloudflareSecretsStoreSecret#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }

        /// <summary>Only secrets with the given scopes will be returned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/secrets_store_secret#scopes DataCloudflareSecretsStoreSecret#scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Scopes
        {
            get;
            set;
        }

        /// <summary>Search secrets using a filter string, filtering across name and comment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/secrets_store_secret#search DataCloudflareSecretsStoreSecret#search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Search
        {
            get;
            set;
        }
    }
}
