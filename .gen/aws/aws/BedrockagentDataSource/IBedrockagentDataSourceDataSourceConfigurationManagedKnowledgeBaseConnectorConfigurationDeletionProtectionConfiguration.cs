using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiInterface(nativeType: typeof(IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration")]
    public interface IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/bedrockagent_data_source#deletion_protection_status BedrockagentDataSource#deletion_protection_status}.</summary>
        [JsiiProperty(name: "deletionProtectionStatus", typeJson: "{\"primitive\":\"string\"}")]
        string DeletionProtectionStatus
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/bedrockagent_data_source#deletion_protection_threshold BedrockagentDataSource#deletion_protection_threshold}.</summary>
        [JsiiProperty(name: "deletionProtectionThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeletionProtectionThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationManagedKnowledgeBaseConnectorConfigurationDeletionProtectionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/bedrockagent_data_source#deletion_protection_status BedrockagentDataSource#deletion_protection_status}.</summary>
            [JsiiProperty(name: "deletionProtectionStatus", typeJson: "{\"primitive\":\"string\"}")]
            public string DeletionProtectionStatus
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/bedrockagent_data_source#deletion_protection_threshold BedrockagentDataSource#deletion_protection_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deletionProtectionThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeletionProtectionThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
