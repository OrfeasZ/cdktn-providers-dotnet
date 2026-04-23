using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHook")]
    public class EcsServiceDeploymentConfigurationLifecycleHook : aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#hook_target_arn EcsService#hook_target_arn}.</summary>
        [JsiiProperty(name: "hookTargetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string HookTargetArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#lifecycle_stages EcsService#lifecycle_stages}.</summary>
        [JsiiProperty(name: "lifecycleStages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] LifecycleStages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#hook_details EcsService#hook_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hookDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HookDetails
        {
            get;
            set;
        }
    }
}
