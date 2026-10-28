using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiInterface(nativeType: typeof(ISagemakerInferenceComponentDeploymentConfig), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfig")]
    public interface ISagemakerInferenceComponentDeploymentConfig
    {
        /// <summary>auto_rollback_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#auto_rollback_configuration SagemakerInferenceComponent#auto_rollback_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoRollbackConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>rolling_update_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#rolling_update_policy SagemakerInferenceComponent#rolling_update_policy}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rollingUpdatePolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RollingUpdatePolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerInferenceComponentDeploymentConfig), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auto_rollback_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#auto_rollback_configuration SagemakerInferenceComponent#auto_rollback_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AutoRollbackConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rolling_update_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#rolling_update_policy SagemakerInferenceComponent#rolling_update_policy}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollingUpdatePolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RollingUpdatePolicy
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
