using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#name SagemakerHyperParameterTuningJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#regex SagemakerHyperParameterTuningJob#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        string Regex
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#name SagemakerHyperParameterTuningJob#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#regex SagemakerHyperParameterTuningJob#regex}.</summary>
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
            public string Regex
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
