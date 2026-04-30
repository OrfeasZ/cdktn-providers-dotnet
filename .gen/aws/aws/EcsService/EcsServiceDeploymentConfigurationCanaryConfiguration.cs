using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiByValue(fqn: "aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfiguration")]
    public class EcsServiceDeploymentConfigurationCanaryConfiguration : aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#canary_bake_time_in_minutes EcsService#canary_bake_time_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "canaryBakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CanaryBakeTimeInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#canary_percent EcsService#canary_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "canaryPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CanaryPercent
        {
            get;
            set;
        }
    }
}
