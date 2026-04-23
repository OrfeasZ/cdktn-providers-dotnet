using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentFlow.BedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3")]
    public class BedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3 : aws.BedrockagentFlow.IBedrockagentFlowDefinitionNodeConfigurationRetrievalServiceConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_flow#bucket_name BedrockagentFlow#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }
    }
}
