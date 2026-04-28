using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanDedicatedInferences
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanDedicatedInferencesSort), fullyQualifiedName: "digitalocean.dataDigitaloceanDedicatedInferences.DataDigitaloceanDedicatedInferencesSort")]
    public interface IDataDigitaloceanDedicatedInferencesSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inferences#key DataDigitaloceanDedicatedInferences#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inferences#direction DataDigitaloceanDedicatedInferences#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanDedicatedInferencesSort), fullyQualifiedName: "digitalocean.dataDigitaloceanDedicatedInferences.DataDigitaloceanDedicatedInferencesSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanDedicatedInferences.IDataDigitaloceanDedicatedInferencesSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inferences#key DataDigitaloceanDedicatedInferences#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/dedicated_inferences#direction DataDigitaloceanDedicatedInferences#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
