using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParams")]
    public class AiSearchInstancePublicEndpointParams : cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#authorized_hosts AiSearchInstance#authorized_hosts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AuthorizedHosts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#chat_completions_endpoint AiSearchInstance#chat_completions_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpoint\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint? ChatCompletionsEndpoint
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#enabled AiSearchInstance#enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#mcp AiSearchInstance#mcp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsMcp\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsMcp? Mcp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#rate_limit AiSearchInstance#rate_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimit\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsRateLimit? RateLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#search_endpoint AiSearchInstance#search_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsSearchEndpoint\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsSearchEndpoint? SearchEndpoint
        {
            get;
            set;
        }
    }
}
