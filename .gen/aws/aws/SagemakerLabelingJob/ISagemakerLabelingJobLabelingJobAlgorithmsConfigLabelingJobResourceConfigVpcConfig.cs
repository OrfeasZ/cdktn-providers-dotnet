using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig")]
    public interface ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#security_group_ids SagemakerLabelingJob#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#subnets SagemakerLabelingJob#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Subnets
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#security_group_ids SagemakerLabelingJob#security_group_ids}.</summary>
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#subnets SagemakerLabelingJob#subnets}.</summary>
            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Subnets
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
