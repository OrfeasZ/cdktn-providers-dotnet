using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceModelAccessConfig")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceModelAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#accept_eula SagemakerHyperParameterTuningJob#accept_eula}.</summary>
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AcceptEula
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceModelAccessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceModelAccessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#accept_eula SagemakerHyperParameterTuningJob#accept_eula}.</summary>
            [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AcceptEula
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
