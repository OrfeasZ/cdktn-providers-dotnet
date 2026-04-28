using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Provider
{
    [JsiiInterface(nativeType: typeof(IDigitaloceanProviderConfig), fullyQualifiedName: "digitalocean.provider.DigitaloceanProviderConfig")]
    public interface IDigitaloceanProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#alias DigitaloceanProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL to use for the DigitalOcean API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#api_endpoint DigitaloceanProvider#api_endpoint}
        /// </remarks>
        [JsiiProperty(name: "apiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of retries on a failed API request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_max DigitaloceanProvider#http_retry_max}
        /// </remarks>
        [JsiiProperty(name: "httpRetryMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpRetryMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum wait time (in seconds) between failed API requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_wait_max DigitaloceanProvider#http_retry_wait_max}
        /// </remarks>
        [JsiiProperty(name: "httpRetryWaitMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpRetryWaitMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum wait time (in seconds) between failed API requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_wait_min DigitaloceanProvider#http_retry_wait_min}
        /// </remarks>
        [JsiiProperty(name: "httpRetryWaitMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpRetryWaitMin
        {
            get
            {
                return null;
            }
        }

        /// <summary>The rate of requests per second to limit the HTTP client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#requests_per_second DigitaloceanProvider#requests_per_second}
        /// </remarks>
        [JsiiProperty(name: "requestsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RequestsPerSecond
        {
            get
            {
                return null;
            }
        }

        /// <summary>The access key ID for Spaces API operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_access_id DigitaloceanProvider#spaces_access_id}
        /// </remarks>
        [JsiiProperty(name: "spacesAccessId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpacesAccessId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL to use for the DigitalOcean Spaces API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_endpoint DigitaloceanProvider#spaces_endpoint}
        /// </remarks>
        [JsiiProperty(name: "spacesEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpacesEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The secret access key for Spaces API operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_secret_key DigitaloceanProvider#spaces_secret_key}
        /// </remarks>
        [JsiiProperty(name: "spacesSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpacesSecretKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The token key for API operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#token DigitaloceanProvider#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDigitaloceanProviderConfig), fullyQualifiedName: "digitalocean.provider.DigitaloceanProviderConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Provider.IDigitaloceanProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#alias DigitaloceanProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The URL to use for the DigitalOcean API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#api_endpoint DigitaloceanProvider#api_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The maximum number of retries on a failed API request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_max DigitaloceanProvider#http_retry_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRetryMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpRetryMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The maximum wait time (in seconds) between failed API requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_wait_max DigitaloceanProvider#http_retry_wait_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRetryWaitMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpRetryWaitMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum wait time (in seconds) between failed API requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#http_retry_wait_min DigitaloceanProvider#http_retry_wait_min}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRetryWaitMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpRetryWaitMin
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The rate of requests per second to limit the HTTP client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#requests_per_second DigitaloceanProvider#requests_per_second}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestsPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RequestsPerSecond
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The access key ID for Spaces API operations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_access_id DigitaloceanProvider#spaces_access_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spacesAccessId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpacesAccessId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The URL to use for the DigitalOcean Spaces API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_endpoint DigitaloceanProvider#spaces_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spacesEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpacesEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The secret access key for Spaces API operations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#spaces_secret_key DigitaloceanProvider#spaces_secret_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spacesSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpacesSecretKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The token key for API operations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs#token DigitaloceanProvider#token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
