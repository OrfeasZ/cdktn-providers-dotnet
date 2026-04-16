using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiInterface(nativeType: typeof(IAiSearchInstanceMetadata), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceMetadata")]
    public interface IAiSearchInstanceMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#created_from_aisearch_wizard AiSearchInstance#created_from_aisearch_wizard}.</summary>
        [JsiiProperty(name: "createdFromAisearchWizard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreatedFromAisearchWizard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#worker_domain AiSearchInstance#worker_domain}.</summary>
        [JsiiProperty(name: "workerDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkerDomain
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiSearchInstanceMetadata), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceMetadata")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiSearchInstance.IAiSearchInstanceMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#created_from_aisearch_wizard AiSearchInstance#created_from_aisearch_wizard}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createdFromAisearchWizard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CreatedFromAisearchWizard
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/ai_search_instance#worker_domain AiSearchInstance#worker_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workerDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkerDomain
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
