using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobRetryStrategy), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobRetryStrategy")]
    public interface ISagemakerTrainingJobRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#maximum_retry_attempts SagemakerTrainingJob#maximum_retry_attempts}.</summary>
        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumRetryAttempts
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobRetryStrategy), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobRetryStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobRetryStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#maximum_retry_attempts SagemakerTrainingJob#maximum_retry_attempts}.</summary>
            [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumRetryAttempts
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
