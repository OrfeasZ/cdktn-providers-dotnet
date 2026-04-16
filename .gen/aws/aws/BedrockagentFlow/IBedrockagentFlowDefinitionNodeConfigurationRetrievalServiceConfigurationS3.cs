using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    [JsiiInterface(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3")]
    public interface IBedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#bucket_name BedrockagentFlow#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3), fullyQualifiedName: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_flow#bucket_name BedrockagentFlow#bucket_name}.</summary>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
