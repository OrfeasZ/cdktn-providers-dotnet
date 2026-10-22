using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration")]
    public class SagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfiguration
    {
        private object? _alarms;

        /// <summary>alarms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#alarms SagemakerInferenceComponent#alarms}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfigurationAlarms" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Alarms
        {
            get => _alarms;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfigurationAlarms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentDeploymentConfigAutoRollbackConfigurationAlarms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _alarms = value;
            }
        }
    }
}
