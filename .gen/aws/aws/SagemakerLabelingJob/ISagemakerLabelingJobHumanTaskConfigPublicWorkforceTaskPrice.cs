using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice")]
    public interface ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice
    {
        /// <summary>amount_in_usd block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#amount_in_usd SagemakerLabelingJob#amount_in_usd}
        /// </remarks>
        [JsiiProperty(name: "amountInUsd", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AmountInUsd
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amount_in_usd block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#amount_in_usd SagemakerLabelingJob#amount_in_usd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountInUsd", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AmountInUsd
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
