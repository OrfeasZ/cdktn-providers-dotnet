using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AgentregistryRegistry
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.agentregistryRegistry.AgentregistryRegistryEncryptionConfiguration")]
    public class AgentregistryRegistryEncryptionConfiguration : aws.AgentregistryRegistry.IAgentregistryRegistryEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/agentregistry_registry#kms_key_arn AgentregistryRegistry#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyArn
        {
            get;
            set;
        }
    }
}
