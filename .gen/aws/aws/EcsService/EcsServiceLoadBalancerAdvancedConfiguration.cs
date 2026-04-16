using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceLoadBalancerAdvancedConfiguration")]
    public class EcsServiceLoadBalancerAdvancedConfiguration : aws.EcsService.IEcsServiceLoadBalancerAdvancedConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#alternate_target_group_arn EcsService#alternate_target_group_arn}.</summary>
        [JsiiProperty(name: "alternateTargetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AlternateTargetGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#production_listener_rule EcsService#production_listener_rule}.</summary>
        [JsiiProperty(name: "productionListenerRule", typeJson: "{\"primitive\":\"string\"}")]
        public string ProductionListenerRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#test_listener_rule EcsService#test_listener_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testListenerRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestListenerRule
        {
            get;
            set;
        }
    }
}
