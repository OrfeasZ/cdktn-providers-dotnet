using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias")]
    public class EcsServiceServiceConnectConfigurationServiceClientAlias : aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#port EcsService#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#dns_name EcsService#dns_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsName
        {
            get;
            set;
        }

        private object? _testTrafficRules;

        /// <summary>test_traffic_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_service#test_traffic_rules EcsService#test_traffic_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "testTrafficRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TestTrafficRules
        {
            get => _testTrafficRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _testTrafficRules = value;
            }
        }
    }
}
