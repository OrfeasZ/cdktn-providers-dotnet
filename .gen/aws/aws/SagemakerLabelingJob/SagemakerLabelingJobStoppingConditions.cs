using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobStoppingConditions")]
    public class SagemakerLabelingJobStoppingConditions : aws.SagemakerLabelingJob.ISagemakerLabelingJobStoppingConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#max_human_labeled_object_count SagemakerLabelingJob#max_human_labeled_object_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxHumanLabeledObjectCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxHumanLabeledObjectCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_labeling_job#max_percentage_of_input_dataset_labeled SagemakerLabelingJob#max_percentage_of_input_dataset_labeled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPercentageOfInputDatasetLabeled", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPercentageOfInputDatasetLabeled
        {
            get;
            set;
        }
    }
}
