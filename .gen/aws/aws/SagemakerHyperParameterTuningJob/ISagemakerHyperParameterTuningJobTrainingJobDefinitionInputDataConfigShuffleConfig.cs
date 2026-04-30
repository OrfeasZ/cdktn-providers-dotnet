using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#seed SagemakerHyperParameterTuningJob#seed}.</summary>
        [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}")]
        double Seed
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionInputDataConfigShuffleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#seed SagemakerHyperParameterTuningJob#seed}.</summary>
            [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}")]
            public double Seed
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
