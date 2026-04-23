using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiByValue(fqn: "aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration")]
    public class EcsServiceDeploymentConfigurationLinearConfiguration : aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#step_bake_time_in_minutes EcsService#step_bake_time_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepBakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StepBakeTimeInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#step_percent EcsService#step_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StepPercent
        {
            get;
            set;
        }
    }
}
