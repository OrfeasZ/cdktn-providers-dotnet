using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobRemoteDebugConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobRemoteDebugConfig")]
    public interface ISagemakerTrainingJobRemoteDebugConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#enable_remote_debug SagemakerTrainingJob#enable_remote_debug}.</summary>
        [JsiiProperty(name: "enableRemoteDebug", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableRemoteDebug
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobRemoteDebugConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobRemoteDebugConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobRemoteDebugConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#enable_remote_debug SagemakerTrainingJob#enable_remote_debug}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableRemoteDebug", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableRemoteDebug
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
