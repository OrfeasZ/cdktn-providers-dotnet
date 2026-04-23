using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig")]
    public interface ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#annotation_consolidation_lambda_arn SagemakerLabelingJob#annotation_consolidation_lambda_arn}.</summary>
        [JsiiProperty(name: "annotationConsolidationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        string AnnotationConsolidationLambdaArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigAnnotationConsolidationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#annotation_consolidation_lambda_arn SagemakerLabelingJob#annotation_consolidation_lambda_arn}.</summary>
            [JsiiProperty(name: "annotationConsolidationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AnnotationConsolidationLambdaArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
