using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiKnowledgeBases
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesSort")]
    public class DataDigitaloceanGradientaiKnowledgeBasesSort : digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_knowledge_bases#key DataDigitaloceanGradientaiKnowledgeBases#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_knowledge_bases#direction DataDigitaloceanGradientaiKnowledgeBases#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}
