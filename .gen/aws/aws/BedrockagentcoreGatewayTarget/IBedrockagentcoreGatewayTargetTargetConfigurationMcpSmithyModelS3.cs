using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#bucket_owner_account_id BedrockagentcoreGatewayTarget#bucket_owner_account_id}.</summary>
        [JsiiProperty(name: "bucketOwnerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketOwnerAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#uri BedrockagentcoreGatewayTarget#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpSmithyModelS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#bucket_owner_account_id BedrockagentcoreGatewayTarget#bucket_owner_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketOwnerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketOwnerAccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway_target#uri BedrockagentcoreGatewayTarget#uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
