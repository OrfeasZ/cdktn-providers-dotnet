using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanMicrodroplets
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanMicrodroplets.DataDigitaloceanMicrodropletsSort")]
    public class DataDigitaloceanMicrodropletsSort : digitalocean.DataDigitaloceanMicrodroplets.IDataDigitaloceanMicrodropletsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplets#key DataDigitaloceanMicrodroplets#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplets#direction DataDigitaloceanMicrodroplets#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}
