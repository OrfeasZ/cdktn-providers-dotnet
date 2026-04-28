using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DedicatedInference
{
    [JsiiInterface(nativeType: typeof(IDedicatedInferenceModelDeploymentsAccelerators), fullyQualifiedName: "digitalocean.dedicatedInference.DedicatedInferenceModelDeploymentsAccelerators")]
    public interface IDedicatedInferenceModelDeploymentsAccelerators
    {
        /// <summary>The slug identifier for the GPU accelerator type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#accelerator_slug DedicatedInference#accelerator_slug}
        /// </remarks>
        [JsiiProperty(name: "acceleratorSlug", typeJson: "{\"primitive\":\"string\"}")]
        string AcceleratorSlug
        {
            get;
        }

        /// <summary>The number of accelerator units to allocate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#scale DedicatedInference#scale}
        /// </remarks>
        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}")]
        double Scale
        {
            get;
        }

        /// <summary>The accelerator type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#type DedicatedInference#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDedicatedInferenceModelDeploymentsAccelerators), fullyQualifiedName: "digitalocean.dedicatedInference.DedicatedInferenceModelDeploymentsAccelerators")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DedicatedInference.IDedicatedInferenceModelDeploymentsAccelerators
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The slug identifier for the GPU accelerator type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#accelerator_slug DedicatedInference#accelerator_slug}
            /// </remarks>
            [JsiiProperty(name: "acceleratorSlug", typeJson: "{\"primitive\":\"string\"}")]
            public string AcceleratorSlug
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of accelerator units to allocate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#scale DedicatedInference#scale}
            /// </remarks>
            [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}")]
            public double Scale
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The accelerator type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#type DedicatedInference#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
