using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceIndexMethod), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceIndexMethod")]
    public interface IAiSearchInstanceIndexMethod
    {
        /// <summary>Enable keyword (BM25) storage backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#keyword AiSearchInstance#keyword}
        /// </remarks>
        [JsiiProperty(name: "keyword", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Keyword
        {
            get;
        }

        /// <summary>Enable vector (embedding) storage backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#vector AiSearchInstance#vector}
        /// </remarks>
        [JsiiProperty(name: "vector", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Vector
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceIndexMethod), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceIndexMethod")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceIndexMethod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enable keyword (BM25) storage backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#keyword AiSearchInstance#keyword}
            /// </remarks>
            [JsiiProperty(name: "keyword", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Keyword
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Enable vector (embedding) storage backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#vector AiSearchInstance#vector}
            /// </remarks>
            [JsiiProperty(name: "vector", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Vector
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
