using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceDeploymentConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfiguration")]
    public interface IEcsServiceDeploymentConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#bake_time_in_minutes EcsService#bake_time_in_minutes}.</summary>
        [JsiiProperty(name: "bakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BakeTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>canary_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#canary_configuration EcsService#canary_configuration}
        /// </remarks>
        [JsiiProperty(name: "canaryConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration? CanaryConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>lifecycle_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#lifecycle_hook EcsService#lifecycle_hook}
        /// </remarks>
        [JsiiProperty(name: "lifecycleHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LifecycleHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>linear_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#linear_configuration EcsService#linear_configuration}
        /// </remarks>
        [JsiiProperty(name: "linearConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration? LinearConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#strategy EcsService#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Strategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceDeploymentConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceDeploymentConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#bake_time_in_minutes EcsService#bake_time_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BakeTimeInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>canary_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#canary_configuration EcsService#canary_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canaryConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfiguration\"}", isOptional: true)]
            public aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration? CanaryConfiguration
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration?>();
            }

            /// <summary>lifecycle_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#lifecycle_hook EcsService#lifecycle_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LifecycleHook
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>linear_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#linear_configuration EcsService#linear_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linearConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration\"}", isOptional: true)]
            public aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration? LinearConfiguration
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#strategy EcsService#strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Strategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
