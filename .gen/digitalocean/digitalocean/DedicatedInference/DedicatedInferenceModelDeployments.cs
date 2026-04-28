using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DedicatedInference
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dedicatedInference.DedicatedInferenceModelDeployments")]
    public class DedicatedInferenceModelDeployments : digitalocean.DedicatedInference.IDedicatedInferenceModelDeployments
    {
        private object _accelerators;

        /// <summary>accelerators block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#accelerators DedicatedInference#accelerators}
        /// </remarks>
        [JsiiProperty(name: "accelerators", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dedicatedInference.DedicatedInferenceModelDeploymentsAccelerators\"},\"kind\":\"array\"}}]}}")]
        public object Accelerators
        {
            get => _accelerators;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DedicatedInference.IDedicatedInferenceModelDeploymentsAccelerators[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DedicatedInference.IDedicatedInferenceModelDeploymentsAccelerators).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DedicatedInference.IDedicatedInferenceModelDeploymentsAccelerators).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accelerators = value;
            }
        }

        /// <summary>The provider of the model (e.g. 'modelcatalog', 'hugging_face').</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_provider DedicatedInference#model_provider}
        /// </remarks>
        [JsiiProperty(name: "modelProvider", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelProvider
        {
            get;
            set;
        }

        /// <summary>The slug identifier for the model to deploy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_slug DedicatedInference#model_slug}
        /// </remarks>
        [JsiiProperty(name: "modelSlug", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelSlug
        {
            get;
            set;
        }

        /// <summary>The unique ID of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#model_id DedicatedInference#model_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }

        /// <summary>The provider-specific model ID. Required when model_provider is 'hugging_face', optional for 'modelcatalog'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#provider_model_id DedicatedInference#provider_model_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "providerModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProviderModelId
        {
            get;
            set;
        }
    }
}
