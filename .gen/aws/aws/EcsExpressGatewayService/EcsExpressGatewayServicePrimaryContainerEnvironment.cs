using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerEnvironment")]
    public class EcsExpressGatewayServicePrimaryContainerEnvironment : aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerEnvironment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#name EcsExpressGatewayService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#value EcsExpressGatewayService#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
