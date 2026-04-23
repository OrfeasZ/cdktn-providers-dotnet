using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceClientAlias), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias")]
    public interface IEcsServiceServiceConnectConfigurationServiceClientAlias
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#port EcsService#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#dns_name EcsService#dns_name}.</summary>
        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsName
        {
            get
            {
                return null;
            }
        }

        /// <summary>test_traffic_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#test_traffic_rules EcsService#test_traffic_rules}
        /// </remarks>
        [JsiiProperty(name: "testTrafficRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TestTrafficRules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceClientAlias), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#port EcsService#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#dns_name EcsService#dns_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>test_traffic_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#test_traffic_rules EcsService#test_traffic_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "testTrafficRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TestTrafficRules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
