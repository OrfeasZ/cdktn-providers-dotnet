using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Provider
{
    [JsiiByValue(fqn: "cloudflare.provider.CloudflareProviderConfig")]
    public class CloudflareProviderConfig : cloudflare.Provider.ICloudflareProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs#alias CloudflareProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>The API key for operations.</summary>
        /// <remarks>
        /// Alternatively, can be configured using the <c>CLOUDFLARE_API_KEY</c> environment variable. API keys are <a href="https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations">now considered legacy by Cloudflare</a>, API tokens should be used instead. Must provide only one of <c>api_key</c>, <c>api_token</c>, <c>api_user_service_key</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs#api_key CloudflareProvider#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiKey
        {
            get;
            set;
        }

        /// <summary>The API Token for operations.</summary>
        /// <remarks>
        /// Alternatively, can be configured using the <c>CLOUDFLARE_API_TOKEN</c> environment variable. Must provide only one of <c>api_key</c>, <c>api_token</c>, <c>api_user_service_key</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs#api_token CloudflareProvider#api_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiToken
        {
            get;
            set;
        }

        /// <summary>A special Cloudflare API key good for a restricted set of endpoints.</summary>
        /// <remarks>
        /// Alternatively, can be configured using the <c>CLOUDFLARE_API_USER_SERVICE_KEY</c> environment variable. Must provide only one of <c>api_key</c>, <c>api_token</c>, <c>api_user_service_key</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs#api_user_service_key CloudflareProvider#api_user_service_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiUserServiceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiUserServiceKey
        {
            get;
            set;
        }

        /// <summary>Value to override the default HTTP client base URL. Alternatively, can be configured using the `base_url` environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs#base_url CloudflareProvider#base_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseUrl
        {
            get;
            set;
        }

        /// <summary>A registered Cloudflare email address.</summary>
        /// <remarks>
        /// Alternatively, can be configured using the <c>CLOUDFLARE_EMAIL</c> environment variable. Required when using <c>api_key</c>. Conflicts with <c>api_token</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs#email CloudflareProvider#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        /// <summary>A value to append to the HTTP User Agent for all API calls.</summary>
        /// <remarks>
        /// This value is not something most users need to modify however, if you are using a non-standard provider or operator configuration, this is recommended to assist in uniquely identifying your traffic. <strong>Setting this value will remove the Terraform version from the HTTP User Agent string and may have unintended consequences</strong>. Alternatively, can be configured using the <c>CLOUDFLARE_USER_AGENT_OPERATOR_SUFFIX</c> environment variable.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs#user_agent_operator_suffix CloudflareProvider#user_agent_operator_suffix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAgentOperatorSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAgentOperatorSuffix
        {
            get;
            set;
        }
    }
}
