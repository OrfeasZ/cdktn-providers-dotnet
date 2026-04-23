using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules")]
    public class EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules : aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRules
    {
        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#header EcsService#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader\"}", isOptional: true)]
        public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader? Header
        {
            get;
            set;
        }
    }
}
