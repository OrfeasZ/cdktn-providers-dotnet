using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanDedicatedInferenceTokens
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanDedicatedInferenceTokensSort), fullyQualifiedName: "digitalocean.dataDigitaloceanDedicatedInferenceTokens.DataDigitaloceanDedicatedInferenceTokensSort")]
    public interface IDataDigitaloceanDedicatedInferenceTokensSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/dedicated_inference_tokens#key DataDigitaloceanDedicatedInferenceTokens#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/dedicated_inference_tokens#direction DataDigitaloceanDedicatedInferenceTokens#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanDedicatedInferenceTokensSort), fullyQualifiedName: "digitalocean.dataDigitaloceanDedicatedInferenceTokens.DataDigitaloceanDedicatedInferenceTokensSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanDedicatedInferenceTokens.IDataDigitaloceanDedicatedInferenceTokensSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/dedicated_inference_tokens#key DataDigitaloceanDedicatedInferenceTokens#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/dedicated_inference_tokens#direction DataDigitaloceanDedicatedInferenceTokens#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
