using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader")]
    public interface IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#name EcsService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#value EcsService#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue\"}")]
        aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#name EcsService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#value EcsService#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue\"}")]
            public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue Value
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue>()!;
            }
        }
    }
}
