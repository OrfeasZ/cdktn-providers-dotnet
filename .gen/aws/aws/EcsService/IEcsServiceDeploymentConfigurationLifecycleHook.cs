using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceDeploymentConfigurationLifecycleHook), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHook")]
    public interface IEcsServiceDeploymentConfigurationLifecycleHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#lifecycle_stages EcsService#lifecycle_stages}.</summary>
        [JsiiProperty(name: "lifecycleStages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LifecycleStages
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#hook_details EcsService#hook_details}.</summary>
        [JsiiProperty(name: "hookDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HookDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#hook_target_arn EcsService#hook_target_arn}.</summary>
        [JsiiProperty(name: "hookTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HookTargetArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#target_type EcsService#target_type}.</summary>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetType
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeout_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#timeout_configuration EcsService#timeout_configuration}
        /// </remarks>
        [JsiiProperty(name: "timeoutConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration? TimeoutConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceDeploymentConfigurationLifecycleHook), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHook")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#lifecycle_stages EcsService#lifecycle_stages}.</summary>
            [JsiiProperty(name: "lifecycleStages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LifecycleStages
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#hook_details EcsService#hook_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hookDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HookDetails
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#hook_target_arn EcsService#hook_target_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hookTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HookTargetArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#target_type EcsService#target_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeout_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#timeout_configuration EcsService#timeout_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration\"}", isOptional: true)]
            public aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration? TimeoutConfiguration
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration?>();
            }
        }
    }
}
