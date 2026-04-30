using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig")]
    public class SagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig : aws.SagemakerLabelingJob.ISagemakerLabelingJobLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#security_group_ids SagemakerLabelingJob#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#subnets SagemakerLabelingJob#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Subnets
        {
            get;
            set;
        }
    }
}
