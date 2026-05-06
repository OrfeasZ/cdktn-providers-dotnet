using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreNetworkSecurityGroupSecurityRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleUdpOptionsSourcePortRange")]
    public class CoreNetworkSecurityGroupSecurityRuleUdpOptionsSourcePortRange : oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleUdpOptionsSourcePortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#max CoreNetworkSecurityGroupSecurityRule#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public double Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#min CoreNetworkSecurityGroupSecurityRule#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public double Min
        {
            get;
            set;
        }
    }
}
