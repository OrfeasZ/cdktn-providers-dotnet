using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    [JsiiByValue(fqn: "aws.ecsExpressGatewayService.EcsExpressGatewayServiceScalingTarget")]
    public class EcsExpressGatewayServiceScalingTarget : aws.EcsExpressGatewayService.IEcsExpressGatewayServiceScalingTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#auto_scaling_metric EcsExpressGatewayService#auto_scaling_metric}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoScalingMetric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoScalingMetric
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#auto_scaling_target_value EcsExpressGatewayService#auto_scaling_target_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoScalingTargetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoScalingTargetValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#max_task_count EcsExpressGatewayService#max_task_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTaskCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#min_task_count EcsExpressGatewayService#min_task_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinTaskCount
        {
            get;
            set;
        }
    }
}
