using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchNamespace
{
    [JsiiByValue(fqn: "cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParams")]
    public class AiSearchNamespacePublicEndpointParams : cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#authorized_hosts AiSearchNamespace#authorized_hosts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AuthorizedHosts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#chat_completions_endpoint AiSearchNamespace#chat_completions_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint\"}", isOptional: true)]
        public cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint? ChatCompletionsEndpoint
        {
            get;
            set;
        }

        /// <summary>Custom domain hostnames that alias this public endpoint.</summary>
        /// <remarks>
        /// GET and create responses return the current set; on update (PUT) this field is only echoed back when supplied in the request body, otherwise it is null (omit it to leave domains unchanged).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#custom_domains AiSearchNamespace#custom_domains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomDomains
        {
            get;
            set;
        }

        private object? _defaultDomainEnabled;

        /// <summary>When false, the instance is reachable only via a registered custom domain and the default &lt;public_endpoint_id&gt;.search.ai.cloudflare.com host returns 404. Requires at least one custom domain. Defaults to true. public_endpoint_params is replaced wholesale on update, so resend default_domain_enabled on every update to keep the default host off — omitting it resets to true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#default_domain_enabled AiSearchNamespace#default_domain_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultDomainEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DefaultDomainEnabled
        {
            get => _defaultDomainEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultDomainEnabled = value;
            }
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#enabled AiSearchNamespace#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Instance IDs exposed through the namespace public endpoint.</summary>
        /// <remarks>
        /// Empty means nothing is searchable. Every ID must be an existing instance in this namespace, and the list cannot exceed the account's multi-instance search limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#instances_allowed AiSearchNamespace#instances_allowed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instancesAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InstancesAllowed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#mcp AiSearchNamespace#mcp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsMcp\"}", isOptional: true)]
        public cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsMcp? Mcp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#rate_limit AiSearchNamespace#rate_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsRateLimit\"}", isOptional: true)]
        public cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsRateLimit? RateLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#search_endpoint AiSearchNamespace#search_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsSearchEndpoint\"}", isOptional: true)]
        public cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsSearchEndpoint? SearchEndpoint
        {
            get;
            set;
        }
    }
}
