using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultSecurityList
{
    [JsiiByValue(fqn: "oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesTcpOptions")]
    public class CoreDefaultSecurityListIngressSecurityRulesTcpOptions : oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesTcpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#max CoreDefaultSecurityList#max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#min CoreDefaultSecurityList#min}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Min
        {
            get;
            set;
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#source_port_range CoreDefaultSecurityList#source_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListIngressSecurityRulesTcpOptionsSourcePortRange\"}", isOptional: true)]
        public oci.CoreDefaultSecurityList.ICoreDefaultSecurityListIngressSecurityRulesTcpOptionsSourcePortRange? SourcePortRange
        {
            get;
            set;
        }
    }
}
