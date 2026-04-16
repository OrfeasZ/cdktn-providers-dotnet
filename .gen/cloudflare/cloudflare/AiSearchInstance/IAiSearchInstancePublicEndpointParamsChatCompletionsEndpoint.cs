using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpoint")]
    public interface IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint
    {
        /// <summary>Disable chat completions endpoint for this public endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#disabled AiSearchInstance#disabled}
        /// </remarks>
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Disabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstancePublicEndpointParamsChatCompletionsEndpoint")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstancePublicEndpointParamsChatCompletionsEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Disable chat completions endpoint for this public endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#disabled AiSearchInstance#disabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Disabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
