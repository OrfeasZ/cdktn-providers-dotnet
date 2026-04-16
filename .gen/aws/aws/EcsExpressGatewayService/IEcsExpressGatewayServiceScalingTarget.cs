using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    [JsiiInterface(nativeType: typeof(IEcsExpressGatewayServiceScalingTarget), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServiceScalingTarget")]
    public interface IEcsExpressGatewayServiceScalingTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#auto_scaling_metric EcsExpressGatewayService#auto_scaling_metric}.</summary>
        [JsiiProperty(name: "autoScalingMetric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoScalingMetric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#auto_scaling_target_value EcsExpressGatewayService#auto_scaling_target_value}.</summary>
        [JsiiProperty(name: "autoScalingTargetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoScalingTargetValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#max_task_count EcsExpressGatewayService#max_task_count}.</summary>
        [JsiiProperty(name: "maxTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTaskCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#min_task_count EcsExpressGatewayService#min_task_count}.</summary>
        [JsiiProperty(name: "minTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinTaskCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsExpressGatewayServiceScalingTarget), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServiceScalingTarget")]
        internal sealed class _Proxy : DeputyBase, aws.EcsExpressGatewayService.IEcsExpressGatewayServiceScalingTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#auto_scaling_metric EcsExpressGatewayService#auto_scaling_metric}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoScalingMetric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoScalingMetric
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#auto_scaling_target_value EcsExpressGatewayService#auto_scaling_target_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoScalingTargetValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoScalingTargetValue
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#max_task_count EcsExpressGatewayService#max_task_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTaskCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_express_gateway_service#min_task_count EcsExpressGatewayService#min_task_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minTaskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinTaskCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
