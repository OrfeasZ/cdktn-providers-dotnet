using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig")]
    public class SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig : aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#annotation_consolidation_lambda_arn SagemakerLabelingJob#annotation_consolidation_lambda_arn}.</summary>
        [JsiiProperty(name: "annotationConsolidationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AnnotationConsolidationLambdaArn
        {
            get;
            set;
        }
    }
}
