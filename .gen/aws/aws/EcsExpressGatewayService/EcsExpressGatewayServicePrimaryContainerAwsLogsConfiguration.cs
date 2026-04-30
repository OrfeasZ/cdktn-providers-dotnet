using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    [JsiiByValue(fqn: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration")]
    public class EcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration : aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_express_gateway_service#log_group EcsExpressGatewayService#log_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_express_gateway_service#log_stream_prefix EcsExpressGatewayService#log_stream_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logStreamPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogStreamPrefix
        {
            get;
            set;
        }
    }
}
