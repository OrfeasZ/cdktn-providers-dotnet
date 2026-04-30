using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiByValue(fqn: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice")]
    public class SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice : aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPrice
    {
        private object? _amountInUsd;

        /// <summary>amount_in_usd block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_labeling_job#amount_in_usd SagemakerLabelingJob#amount_in_usd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountInUsd", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AmountInUsd
        {
            get => _amountInUsd;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _amountInUsd = value;
            }
        }
    }
}
