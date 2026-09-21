using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AgentregistryRegistry
{
    [JsiiInterface(nativeType: typeof(IAgentregistryRegistryEncryptionConfiguration), fullyQualifiedName: "aws.agentregistryRegistry.AgentregistryRegistryEncryptionConfiguration")]
    public interface IAgentregistryRegistryEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/agentregistry_registry#kms_key_arn AgentregistryRegistry#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKeyArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAgentregistryRegistryEncryptionConfiguration), fullyQualifiedName: "aws.agentregistryRegistry.AgentregistryRegistryEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AgentregistryRegistry.IAgentregistryRegistryEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/agentregistry_registry#kms_key_arn AgentregistryRegistry#kms_key_arn}.</summary>
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKeyArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
