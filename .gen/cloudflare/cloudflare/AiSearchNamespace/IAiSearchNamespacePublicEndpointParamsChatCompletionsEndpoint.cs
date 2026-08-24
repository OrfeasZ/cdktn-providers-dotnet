using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchNamespace
{
    [JsiiInterface(nativeType: typeof(IAiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint), fullyQualifiedName: "cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint")]
    public interface IAiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint
    {
        /// <summary>Disable chat completions endpoint for this public endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#disabled AiSearchNamespace#disabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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

        [JsiiTypeProxy(nativeType: typeof(IAiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint), fullyQualifiedName: "cloudflare.aiSearchNamespace.AiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchNamespace.IAiSearchNamespacePublicEndpointParamsChatCompletionsEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Disable chat completions endpoint for this public endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/ai_search_namespace#disabled AiSearchNamespace#disabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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
