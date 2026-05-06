using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultSecurityList
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptionsSourcePortRange")]
    public class CoreDefaultSecurityListEgressSecurityRulesTcpOptionsSourcePortRange : oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptionsSourcePortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#max CoreDefaultSecurityList#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public double Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#min CoreDefaultSecurityList#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public double Min
        {
            get;
            set;
        }
    }
}
