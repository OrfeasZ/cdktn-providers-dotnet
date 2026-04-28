using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Provider
{
    [JsiiByValue(fqn: "digitalocean.provider.DigitaloceanProviderConfig")]
    public class DigitaloceanProviderConfig : digitalocean.Provider.IDigitaloceanProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#alias DigitaloceanProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>The URL to use for the DigitalOcean API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#api_endpoint DigitaloceanProvider#api_endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiEndpoint
        {
            get;
            set;
        }

        /// <summary>The maximum number of retries on a failed API request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_max DigitaloceanProvider#http_retry_max}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRetryMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpRetryMax
        {
            get;
            set;
        }

        /// <summary>The maximum wait time (in seconds) between failed API requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_wait_max DigitaloceanProvider#http_retry_wait_max}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRetryWaitMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpRetryWaitMax
        {
            get;
            set;
        }

        /// <summary>The minimum wait time (in seconds) between failed API requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_wait_min DigitaloceanProvider#http_retry_wait_min}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRetryWaitMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpRetryWaitMin
        {
            get;
            set;
        }

        /// <summary>The rate of requests per second to limit the HTTP client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#requests_per_second DigitaloceanProvider#requests_per_second}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RequestsPerSecond
        {
            get;
            set;
        }

        /// <summary>The access key ID for Spaces API operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_access_id DigitaloceanProvider#spaces_access_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spacesAccessId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpacesAccessId
        {
            get;
            set;
        }

        /// <summary>The URL to use for the DigitalOcean Spaces API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_endpoint DigitaloceanProvider#spaces_endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spacesEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpacesEndpoint
        {
            get;
            set;
        }

        /// <summary>The secret access key for Spaces API operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_secret_key DigitaloceanProvider#spaces_secret_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spacesSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpacesSecretKey
        {
            get;
            set;
        }

        /// <summary>The token key for API operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#token DigitaloceanProvider#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }
    }
}
