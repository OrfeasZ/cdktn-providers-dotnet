using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentTemplateKnowledgeBasesLastIndexingJob")]
    public class DataDigitaloceanAgentPlatformAgentTemplateKnowledgeBasesLastIndexingJob : digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentTemplateKnowledgeBasesLastIndexingJob
    {
        /// <summary>Number of completed datasources in the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#completed_datasources DataDigitaloceanAgentPlatformAgent#completed_datasources}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#data_source_uuids DataDigitaloceanAgentPlatformAgent#data_source_uuids}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#phase DataDigitaloceanAgentPlatformAgent#phase}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#tokens DataDigitaloceanAgentPlatformAgent#tokens}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#total_datasources DataDigitaloceanAgentPlatformAgent#total_datasources}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#uuid DataDigitaloceanAgentPlatformAgent#uuid}
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
