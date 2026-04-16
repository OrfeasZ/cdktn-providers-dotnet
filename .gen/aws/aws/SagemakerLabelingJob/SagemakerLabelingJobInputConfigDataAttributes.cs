using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataAttributes")]
    public class SagemakerLabelingJobInputConfigDataAttributes : aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#content_classifiers SagemakerLabelingJob#content_classifiers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentClassifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ContentClassifiers
        {
            get;
            set;
        }
    }
}
