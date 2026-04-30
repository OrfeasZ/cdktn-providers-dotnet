using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    [JsiiByValue(fqn: "aws.ecsExpressGatewayService.EcsExpressGatewayServiceNetworkConfiguration")]
    public class EcsExpressGatewayServiceNetworkConfiguration : aws.EcsExpressGatewayService.IEcsExpressGatewayServiceNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_express_gateway_service#security_groups EcsExpressGatewayService#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_express_gateway_service#subnets EcsExpressGatewayService#subnets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Subnets
        {
            get;
            set;
        }
    }
}
