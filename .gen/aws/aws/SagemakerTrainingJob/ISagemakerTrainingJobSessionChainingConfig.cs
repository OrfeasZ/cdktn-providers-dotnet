using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobSessionChainingConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobSessionChainingConfig")]
    public interface ISagemakerTrainingJobSessionChainingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#enable_session_tag_chaining SagemakerTrainingJob#enable_session_tag_chaining}.</summary>
        [JsiiProperty(name: "enableSessionTagChaining", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableSessionTagChaining
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobSessionChainingConfig), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobSessionChainingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobSessionChainingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#enable_session_tag_chaining SagemakerTrainingJob#enable_session_tag_chaining}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableSessionTagChaining", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableSessionTagChaining
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
