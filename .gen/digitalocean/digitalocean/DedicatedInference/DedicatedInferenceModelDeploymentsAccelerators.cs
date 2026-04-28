using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DedicatedInference
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dedicatedInference.DedicatedInferenceModelDeploymentsAccelerators")]
    public class DedicatedInferenceModelDeploymentsAccelerators : digitalocean.DedicatedInference.IDedicatedInferenceModelDeploymentsAccelerators
    {
        /// <summary>The slug identifier for the GPU accelerator type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#accelerator_slug DedicatedInference#accelerator_slug}
        /// </remarks>
        [JsiiProperty(name: "acceleratorSlug", typeJson: "{\"primitive\":\"string\"}")]
        public string AcceleratorSlug
        {
            get;
            set;
        }

        /// <summary>The number of accelerator units to allocate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#scale DedicatedInference#scale}
        /// </remarks>
        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}")]
        public double Scale
        {
            get;
            set;
        }

        /// <summary>The accelerator type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/dedicated_inference#type DedicatedInference#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
