using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanDedicatedInferenceAccelerators
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanDedicatedInferenceAccelerators.DataDigitaloceanDedicatedInferenceAcceleratorsSort")]
    public class DataDigitaloceanDedicatedInferenceAcceleratorsSort : digitalocean.DataDigitaloceanDedicatedInferenceAccelerators.IDataDigitaloceanDedicatedInferenceAcceleratorsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inference_accelerators#key DataDigitaloceanDedicatedInferenceAccelerators#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inference_accelerators#direction DataDigitaloceanDedicatedInferenceAccelerators#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}
