using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiOpenaiApiKeys
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiOpenaiApiKeys.DataDigitaloceanGradientaiOpenaiApiKeysSort")]
    public class DataDigitaloceanGradientaiOpenaiApiKeysSort : digitalocean.DataDigitaloceanGradientaiOpenaiApiKeys.IDataDigitaloceanGradientaiOpenaiApiKeysSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#key DataDigitaloceanGradientaiOpenaiApiKeys#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#direction DataDigitaloceanGradientaiOpenaiApiKeys#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}
