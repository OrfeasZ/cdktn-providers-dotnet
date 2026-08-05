using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstancePublicEndpointParams), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParams")]
    public interface IAiSearchInstancePublicEndpointParams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#authorized_hosts AiSearchInstance#authorized_hosts}.</summary>
        [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AuthorizedHosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#chat_completions_endpoint AiSearchInstance#chat_completions_endpoint}.</summary>
        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpoint\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint? ChatCompletionsEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Custom domain hostnames that alias this public endpoint.</summary>
        /// <remarks>
        /// GET and create responses return the current set; on update (PUT) this field is only echoed back when supplied in the request body, otherwise it is null (omit it to leave domains unchanged).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#custom_domains AiSearchInstance#custom_domains}
        /// </remarks>
        [JsiiProperty(name: "customDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomDomains
        {
            get
            {
                return null;
            }
        }

        /// <summary>When false, the instance is reachable only via a registered custom domain and the default &lt;public_endpoint_id&gt;.search.ai.cloudflare.com host returns 404. Requires at least one custom domain. Defaults to true. public_endpoint_params is replaced wholesale on update, so resend default_domain_enabled on every update to keep the default host off — omitting it resets to true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#default_domain_enabled AiSearchInstance#default_domain_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "defaultDomainEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultDomainEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#enabled AiSearchInstance#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#mcp AiSearchInstance#mcp}.</summary>
        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsMcp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsMcp? Mcp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#rate_limit AiSearchInstance#rate_limit}.</summary>
        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsRateLimit? RateLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#search_endpoint AiSearchInstance#search_endpoint}.</summary>
        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsSearchEndpoint\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsSearchEndpoint? SearchEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstancePublicEndpointParams), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParams")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#authorized_hosts AiSearchInstance#authorized_hosts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AuthorizedHosts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#chat_completions_endpoint AiSearchInstance#chat_completions_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpoint\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint? ChatCompletionsEndpoint
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint?>();
            }

            /// <summary>Custom domain hostnames that alias this public endpoint.</summary>
            /// <remarks>
            /// GET and create responses return the current set; on update (PUT) this field is only echoed back when supplied in the request body, otherwise it is null (omit it to leave domains unchanged).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#custom_domains AiSearchInstance#custom_domains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomDomains
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>When false, the instance is reachable only via a registered custom domain and the default &lt;public_endpoint_id&gt;.search.ai.cloudflare.com host returns 404. Requires at least one custom domain. Defaults to true. public_endpoint_params is replaced wholesale on update, so resend default_domain_enabled on every update to keep the default host off — omitting it resets to true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#default_domain_enabled AiSearchInstance#default_domain_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultDomainEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DefaultDomainEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#enabled AiSearchInstance#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#mcp AiSearchInstance#mcp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsMcp\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsMcp? Mcp
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsMcp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#rate_limit AiSearchInstance#rate_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsRateLimit\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsRateLimit? RateLimit
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsRateLimit?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/ai_search_instance#search_endpoint AiSearchInstance#search_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsSearchEndpoint\"}", isOptional: true)]
            public cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsSearchEndpoint? SearchEndpoint
            {
                get => GetInstanceProperty<cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsSearchEndpoint?>();
            }
        }
    }
}
