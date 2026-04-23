using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd")]
    public class SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd : aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#cents SagemakerLabelingJob#cents}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cents", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Cents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#dollars SagemakerLabelingJob#dollars}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dollars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Dollars
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#tenth_fractions_of_a_cent SagemakerLabelingJob#tenth_fractions_of_a_cent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenthFractionsOfACent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TenthFractionsOfACent
        {
            get;
            set;
        }
    }
}
