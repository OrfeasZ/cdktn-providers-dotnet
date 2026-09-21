using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration")]
    public interface IEcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#action EcsService#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#timeout_in_minutes EcsService#timeout_in_minutes}.</summary>
        [JsiiProperty(name: "timeoutInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#action EcsService#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#timeout_in_minutes EcsService#timeout_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeoutInMinutes
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
