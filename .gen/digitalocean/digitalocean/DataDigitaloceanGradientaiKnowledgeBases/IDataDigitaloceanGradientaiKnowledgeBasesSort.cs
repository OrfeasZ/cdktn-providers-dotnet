using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiKnowledgeBases
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiKnowledgeBasesSort), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesSort")]
    public interface IDataDigitaloceanGradientaiKnowledgeBasesSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_bases#key DataDigitaloceanGradientaiKnowledgeBases#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_bases#direction DataDigitaloceanGradientaiKnowledgeBases#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiKnowledgeBasesSort), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_bases#key DataDigitaloceanGradientaiKnowledgeBases#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_bases#direction DataDigitaloceanGradientaiKnowledgeBases#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
