using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobInfraCheckConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInfraCheckConfig")]
    public interface ISagemakerTrainingJobInfraCheckConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#enable_infra_check SagemakerTrainingJob#enable_infra_check}.</summary>
        [JsiiProperty(name: "enableInfraCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableInfraCheck
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobInfraCheckConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobInfraCheckConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobInfraCheckConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#enable_infra_check SagemakerTrainingJob#enable_infra_check}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableInfraCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableInfraCheck
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
