using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockModelInvocationJobVpcConfig), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobVpcConfig")]
    public interface IBedrockModelInvocationJobVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#security_group_ids BedrockModelInvocationJob#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#subnet_ids BedrockModelInvocationJob#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockModelInvocationJobVpcConfig), fullyQualifiedName: "aws.bedrockModelInvocationJob.BedrockModelInvocationJobVpcConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockModelInvocationJob.IBedrockModelInvocationJobVpcConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#security_group_ids BedrockModelInvocationJob#security_group_ids}.</summary>
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrock_model_invocation_job#subnet_ids BedrockModelInvocationJob#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
