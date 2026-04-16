using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig")]
    public interface ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#accept_eula SagemakerAlgorithm#accept_eula}.</summary>
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AcceptEula
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmValidationSpecificationValidationProfilesTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#accept_eula SagemakerAlgorithm#accept_eula}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AcceptEula
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
