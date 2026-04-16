using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSecurityGroupRules
{
    [JsiiByValue(fqn: "scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesTimeouts")]
    public class InstanceSecurityGroupRulesTimeouts : scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#default InstanceSecurityGroupRules#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
