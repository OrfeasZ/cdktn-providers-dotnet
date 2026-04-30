using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiByValue(fqn: "aws.ecsService.EcsServiceDeploymentConfiguration")]
    public class EcsServiceDeploymentConfiguration : aws.EcsService.IEcsServiceDeploymentConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#bake_time_in_minutes EcsService#bake_time_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BakeTimeInMinutes
        {
            get;
            set;
        }

        /// <summary>canary_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#canary_configuration EcsService#canary_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "canaryConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfiguration\"}", isOptional: true)]
        public aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration? CanaryConfiguration
        {
            get;
            set;
        }

        private object? _lifecycleHook;

        /// <summary>lifecycle_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#lifecycle_hook EcsService#lifecycle_hook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LifecycleHook
        {
            get => _lifecycleHook;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHook[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHook).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lifecycleHook = value;
            }
        }

        /// <summary>linear_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#linear_configuration EcsService#linear_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linearConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration\"}", isOptional: true)]
        public aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration? LinearConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#strategy EcsService#strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Strategy
        {
            get;
            set;
        }
    }
}
