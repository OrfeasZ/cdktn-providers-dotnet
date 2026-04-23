using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobStoppingConditions), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobStoppingConditions")]
    public interface ISagemakerLabelingJobStoppingConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#max_human_labeled_object_count SagemakerLabelingJob#max_human_labeled_object_count}.</summary>
        [JsiiProperty(name: "maxHumanLabeledObjectCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxHumanLabeledObjectCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#max_percentage_of_input_dataset_labeled SagemakerLabelingJob#max_percentage_of_input_dataset_labeled}.</summary>
        [JsiiProperty(name: "maxPercentageOfInputDatasetLabeled", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPercentageOfInputDatasetLabeled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobStoppingConditions), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobStoppingConditions")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobStoppingConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#max_human_labeled_object_count SagemakerLabelingJob#max_human_labeled_object_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxHumanLabeledObjectCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxHumanLabeledObjectCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#max_percentage_of_input_dataset_labeled SagemakerLabelingJob#max_percentage_of_input_dataset_labeled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPercentageOfInputDatasetLabeled", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPercentageOfInputDatasetLabeled
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
