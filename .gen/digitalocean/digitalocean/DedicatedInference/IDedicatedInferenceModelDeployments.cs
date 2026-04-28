using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DedicatedInference
{
    [JsiiInterface(nativeType: typeof(IDedicatedInferenceModelDeployments), fullyQualifiedName: "digitalocean.dedicatedInference.DedicatedInferenceModelDeployments")]
    public interface IDedicatedInferenceModelDeployments
    {
        /// <summary>accelerators block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#accelerators DedicatedInference#accelerators}
        /// </remarks>
        [JsiiProperty(name: "accelerators", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dedicatedInference.DedicatedInferenceModelDeploymentsAccelerators\"},\"kind\":\"array\"}}]}}")]
        object Accelerators
        {
            get;
        }

        /// <summary>The provider of the model (e.g. 'modelcatalog', 'hugging_face').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_provider DedicatedInference#model_provider}
        /// </remarks>
        [JsiiProperty(name: "modelProvider", typeJson: "{\"primitive\":\"string\"}")]
        string ModelProvider
        {
            get;
        }

        /// <summary>The slug identifier for the model to deploy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_slug DedicatedInference#model_slug}
        /// </remarks>
        [JsiiProperty(name: "modelSlug", typeJson: "{\"primitive\":\"string\"}")]
        string ModelSlug
        {
            get;
        }

        /// <summary>The unique ID of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_id DedicatedInference#model_id}
        /// </remarks>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The provider-specific model ID. Required when model_provider is 'hugging_face', optional for 'modelcatalog'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#provider_model_id DedicatedInference#provider_model_id}
        /// </remarks>
        [JsiiProperty(name: "providerModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProviderModelId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDedicatedInferenceModelDeployments), fullyQualifiedName: "digitalocean.dedicatedInference.DedicatedInferenceModelDeployments")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DedicatedInference.IDedicatedInferenceModelDeployments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>accelerators block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#accelerators DedicatedInference#accelerators}
            /// </remarks>
            [JsiiProperty(name: "accelerators", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dedicatedInference.DedicatedInferenceModelDeploymentsAccelerators\"},\"kind\":\"array\"}}]}}")]
            public object Accelerators
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The provider of the model (e.g. 'modelcatalog', 'hugging_face').</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_provider DedicatedInference#model_provider}
            /// </remarks>
            [JsiiProperty(name: "modelProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The slug identifier for the model to deploy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_slug DedicatedInference#model_slug}
            /// </remarks>
            [JsiiProperty(name: "modelSlug", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelSlug
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The unique ID of the model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_id DedicatedInference#model_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The provider-specific model ID. Required when model_provider is 'hugging_face', optional for 'modelcatalog'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#provider_model_id DedicatedInference#provider_model_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "providerModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProviderModelId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
