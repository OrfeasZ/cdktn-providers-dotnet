using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobInputConfigDataAttributes), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataAttributes")]
    public interface ISagemakerLabelingJobInputConfigDataAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#content_classifiers SagemakerLabelingJob#content_classifiers}.</summary>
        [JsiiProperty(name: "contentClassifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ContentClassifiers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobInputConfigDataAttributes), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobInputConfigDataAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobInputConfigDataAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#content_classifiers SagemakerLabelingJob#content_classifiers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentClassifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ContentClassifiers
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
