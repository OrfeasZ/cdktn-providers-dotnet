using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceModelAccessConfig")]
    public interface ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceModelAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#accept_eula SagemakerTrainingJob#accept_eula}.</summary>
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AcceptEula
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInputDataConfigDataSourceS3DataSourceModelAccessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobInputDataConfigDataSourceS3DataSourceModelAccessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#accept_eula SagemakerTrainingJob#accept_eula}.</summary>
            [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AcceptEula
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
