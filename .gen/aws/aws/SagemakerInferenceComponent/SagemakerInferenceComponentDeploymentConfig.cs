using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfig")]
    public class SagemakerInferenceComponentDeploymentConfig : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfig
    {
        private object? _autoRollbackConfiguration;

        /// <summary>auto_rollback_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#auto_rollback_configuration SagemakerInferenceComponent#auto_rollback_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AutoRollbackConfiguration
        {
            get => _autoRollbackConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autoRollbackConfiguration = value;
            }
        }

        private object? _rollingUpdatePolicy;

        /// <summary>rolling_update_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#rolling_update_policy SagemakerInferenceComponent#rolling_update_policy}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rollingUpdatePolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RollingUpdatePolicy
        {
            get => _rollingUpdatePolicy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigRollingUpdatePolicy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rollingUpdatePolicy = value;
            }
        }
    }
}
