using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#seed SagemakerHyperParameterTuningJob#seed}.</summary>
        [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}")]
        double Seed
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigShuffleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#seed SagemakerHyperParameterTuningJob#seed}.</summary>
            [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"number\"}")]
            public double Seed
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
