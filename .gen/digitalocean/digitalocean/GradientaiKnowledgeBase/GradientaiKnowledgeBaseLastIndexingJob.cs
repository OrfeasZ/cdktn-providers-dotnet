using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBase
{
    [JsiiByValue(fqn: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseLastIndexingJob")]
    public class GradientaiKnowledgeBaseLastIndexingJob : digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseLastIndexingJob
    {
        /// <summary>Number of completed datasources in the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#completed_datasources GradientaiKnowledgeBase#completed_datasources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "completedDatasources", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CompletedDatasources
        {
            get;
            set;
        }

        /// <summary>Datasource UUIDs for the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#data_source_uuids GradientaiKnowledgeBase#data_source_uuids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceUuids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DataSourceUuids
        {
            get;
            set;
        }

        /// <summary>Phase of the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#phase GradientaiKnowledgeBase#phase}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Phase
        {
            get;
            set;
        }

        /// <summary>Number of tokens processed in the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#tokens GradientaiKnowledgeBase#tokens}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Tokens
        {
            get;
            set;
        }

        /// <summary>Total number of datasources in the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#total_datasources GradientaiKnowledgeBase#total_datasources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "totalDatasources", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TotalDatasources
        {
            get;
            set;
        }

        /// <summary>UUID  of the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#uuid GradientaiKnowledgeBase#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }
    }
}
