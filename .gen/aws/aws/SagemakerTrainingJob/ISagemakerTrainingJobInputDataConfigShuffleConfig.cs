using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobInputDataConfigShuffleConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigShuffleConfig")]
    public interface ISagemakerTrainingJobInputDataConfigShuffleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#seed SagemakerTrainingJob#seed}.</summary>
        [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Seed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobInputDataConfigShuffleConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigShuffleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigShuffleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#seed SagemakerTrainingJob#seed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Seed
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
