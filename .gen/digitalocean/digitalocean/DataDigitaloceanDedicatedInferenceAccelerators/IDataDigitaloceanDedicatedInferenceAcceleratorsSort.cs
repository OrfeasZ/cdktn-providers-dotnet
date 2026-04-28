using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanDedicatedInferenceAccelerators
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanDedicatedInferenceAcceleratorsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanDedicatedInferenceAccelerators.DataDigitaloceanDedicatedInferenceAcceleratorsSort")]
    public interface IDataDigitaloceanDedicatedInferenceAcceleratorsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inference_accelerators#key DataDigitaloceanDedicatedInferenceAccelerators#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inference_accelerators#direction DataDigitaloceanDedicatedInferenceAccelerators#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanDedicatedInferenceAcceleratorsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanDedicatedInferenceAccelerators.DataDigitaloceanDedicatedInferenceAcceleratorsSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanDedicatedInferenceAccelerators.IDataDigitaloceanDedicatedInferenceAcceleratorsSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inference_accelerators#key DataDigitaloceanDedicatedInferenceAccelerators#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inference_accelerators#direction DataDigitaloceanDedicatedInferenceAccelerators#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
