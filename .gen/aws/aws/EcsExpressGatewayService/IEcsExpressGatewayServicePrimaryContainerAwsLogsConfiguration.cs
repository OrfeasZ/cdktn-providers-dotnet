using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    [JsiiInterface(nativeType: typeof(IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration")]
    public interface IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#log_group EcsExpressGatewayService#log_group}.</summary>
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#log_stream_prefix EcsExpressGatewayService#log_stream_prefix}.</summary>
        [JsiiProperty(name: "logStreamPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogStreamPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#log_group EcsExpressGatewayService#log_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#log_stream_prefix EcsExpressGatewayService#log_stream_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logStreamPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogStreamPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
