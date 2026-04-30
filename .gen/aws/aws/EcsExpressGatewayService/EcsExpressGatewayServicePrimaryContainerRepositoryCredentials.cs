using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentials")]
    public class EcsExpressGatewayServicePrimaryContainerRepositoryCredentials : aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_express_gateway_service#credentials_parameter EcsExpressGatewayService#credentials_parameter}.</summary>
        [JsiiProperty(name: "credentialsParameter", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialsParameter
        {
            get;
            set;
        }
    }
}
