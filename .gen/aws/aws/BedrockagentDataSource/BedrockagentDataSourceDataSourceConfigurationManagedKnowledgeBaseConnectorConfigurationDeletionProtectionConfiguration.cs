using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration")]
    public class BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagent_data_source#deletion_protection_status BedrockagentDataSource#deletion_protection_status}.</summary>
        [JsiiProperty(name: "deletionProtectionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public string DeletionProtectionStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagent_data_source#deletion_protection_threshold BedrockagentDataSource#deletion_protection_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deletionProtectionThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeletionProtectionThreshold
        {
            get;
            set;
        }
    }
}
