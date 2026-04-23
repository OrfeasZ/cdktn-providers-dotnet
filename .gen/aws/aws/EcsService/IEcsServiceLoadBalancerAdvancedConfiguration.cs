using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceLoadBalancerAdvancedConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceLoadBalancerAdvancedConfiguration")]
    public interface IEcsServiceLoadBalancerAdvancedConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#alternate_target_group_arn EcsService#alternate_target_group_arn}.</summary>
        [JsiiProperty(name: "alternateTargetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string AlternateTargetGroupArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#production_listener_rule EcsService#production_listener_rule}.</summary>
        [JsiiProperty(name: "productionListenerRule", typeJson: "{\"primitive\":\"string\"}")]
        string ProductionListenerRule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#test_listener_rule EcsService#test_listener_rule}.</summary>
        [JsiiProperty(name: "testListenerRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TestListenerRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceLoadBalancerAdvancedConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceLoadBalancerAdvancedConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceLoadBalancerAdvancedConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#alternate_target_group_arn EcsService#alternate_target_group_arn}.</summary>
            [JsiiProperty(name: "alternateTargetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AlternateTargetGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#production_listener_rule EcsService#production_listener_rule}.</summary>
            [JsiiProperty(name: "productionListenerRule", typeJson: "{\"primitive\":\"string\"}")]
            public string ProductionListenerRule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#test_listener_rule EcsService#test_listener_rule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "testListenerRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TestListenerRule
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
