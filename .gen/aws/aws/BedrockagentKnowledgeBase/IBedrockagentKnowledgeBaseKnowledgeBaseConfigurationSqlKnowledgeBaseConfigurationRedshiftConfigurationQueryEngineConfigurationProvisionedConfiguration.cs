using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration")]
    public interface IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#cluster_identifier BedrockagentKnowledgeBase#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterIdentifier
        {
            get;
        }

        /// <summary>auth_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#auth_configuration BedrockagentKnowledgeBase#auth_configuration}
        /// </remarks>
        [JsiiProperty(name: "authConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationAuthConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#cluster_identifier BedrockagentKnowledgeBase#cluster_identifier}.</summary>
            [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auth_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#auth_configuration BedrockagentKnowledgeBase#auth_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfigurationProvisionedConfigurationAuthConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuthConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
