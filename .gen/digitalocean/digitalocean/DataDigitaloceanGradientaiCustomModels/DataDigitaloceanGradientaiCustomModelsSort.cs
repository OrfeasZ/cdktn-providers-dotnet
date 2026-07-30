using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiCustomModels
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiCustomModels.DataDigitaloceanGradientaiCustomModelsSort")]
    public class DataDigitaloceanGradientaiCustomModelsSort : digitalocean.DataDigitaloceanGradientaiCustomModels.IDataDigitaloceanGradientaiCustomModelsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/gradientai_custom_models#key DataDigitaloceanGradientaiCustomModels#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/gradientai_custom_models#direction DataDigitaloceanGradientaiCustomModels#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}
