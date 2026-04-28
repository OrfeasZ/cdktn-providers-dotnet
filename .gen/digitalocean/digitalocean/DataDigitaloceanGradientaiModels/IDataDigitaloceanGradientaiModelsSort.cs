using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiModels
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiModelsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiModels.DataDigitaloceanGradientaiModelsSort")]
    public interface IDataDigitaloceanGradientaiModelsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_models#key DataDigitaloceanGradientaiModels#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_models#direction DataDigitaloceanGradientaiModels#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiModelsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiModels.DataDigitaloceanGradientaiModelsSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiModels.IDataDigitaloceanGradientaiModelsSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_models#key DataDigitaloceanGradientaiModels#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_models#direction DataDigitaloceanGradientaiModels#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
