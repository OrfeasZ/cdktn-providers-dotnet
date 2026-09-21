using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiByValue(fqn: "aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration")]
    public class EcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration : aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHookTimeoutConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#action EcsService#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ecs_service#timeout_in_minutes EcsService#timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeoutInMinutes
        {
            get;
            set;
        }
    }
}
