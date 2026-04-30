using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules")]
    public interface IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules
    {
        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#header EcsService#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader? Header
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#header EcsService#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader\"}", isOptional: true)]
            public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader? Header
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader?>();
            }
        }
    }
}
