using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiInterface(nativeType: typeof(ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy")]
    public interface ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#wait_interval_in_seconds SagemakerInferenceComponent#wait_interval_in_seconds}.</summary>
        [JsiiProperty(name: "waitIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double WaitIntervalInSeconds
        {
            get;
        }

        /// <summary>maximum_batch_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#maximum_batch_size SagemakerInferenceComponent#maximum_batch_size}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "maximumBatchSize", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MaximumBatchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#maximum_execution_timeout_in_seconds SagemakerInferenceComponent#maximum_execution_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumExecutionTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>rollback_maximum_batch_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#rollback_maximum_batch_size SagemakerInferenceComponent#rollback_maximum_batch_size}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rollbackMaximumBatchSize", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RollbackMaximumBatchSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#wait_interval_in_seconds SagemakerInferenceComponent#wait_interval_in_seconds}.</summary>
            [JsiiProperty(name: "waitIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double WaitIntervalInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>maximum_batch_size block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#maximum_batch_size SagemakerInferenceComponent#maximum_batch_size}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumBatchSize", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyMaximumBatchSize\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MaximumBatchSize
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#maximum_execution_timeout_in_seconds SagemakerInferenceComponent#maximum_execution_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumExecutionTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>rollback_maximum_batch_size block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#rollback_maximum_batch_size SagemakerInferenceComponent#rollback_maximum_batch_size}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollbackMaximumBatchSize", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RollbackMaximumBatchSize
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
