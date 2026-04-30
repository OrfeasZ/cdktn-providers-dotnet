using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue")]
    public interface IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#exact EcsService#exact}.</summary>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
        string Exact
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_service#exact EcsService#exact}.</summary>
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
            public string Exact
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
