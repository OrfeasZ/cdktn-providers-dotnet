using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    [JsiiInterface(nativeType: typeof(IEcsExpressGatewayServicePrimaryContainerSecret), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerSecret")]
    public interface IEcsExpressGatewayServicePrimaryContainerSecret
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#name EcsExpressGatewayService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#value_from EcsExpressGatewayService#value_from}.</summary>
        [JsiiProperty(name: "valueFrom", typeJson: "{\"primitive\":\"string\"}")]
        string ValueFrom
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsExpressGatewayServicePrimaryContainerSecret), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerSecret")]
        internal sealed class _Proxy : DeputyBase, aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#name EcsExpressGatewayService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#value_from EcsExpressGatewayService#value_from}.</summary>
            [JsiiProperty(name: "valueFrom", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueFrom
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
