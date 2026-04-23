using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue")]
    public class EcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue : aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_service#exact EcsService#exact}.</summary>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
        public string Exact
        {
            get;
            set;
        }
    }
}
