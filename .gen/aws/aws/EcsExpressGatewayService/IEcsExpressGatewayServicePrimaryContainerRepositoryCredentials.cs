using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    [JsiiInterface(nativeType: typeof(IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentials")]
    public interface IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#credentials_parameter EcsExpressGatewayService#credentials_parameter}.</summary>
        [JsiiProperty(name: "credentialsParameter", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialsParameter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentials")]
        internal sealed class _Proxy : DeputyBase, aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#credentials_parameter EcsExpressGatewayService#credentials_parameter}.</summary>
            [JsiiProperty(name: "credentialsParameter", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialsParameter
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
