using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    [JsiiByValue(fqn: "oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptions")]
    public class CoreSecurityListIngressSecurityRulesUdpOptions : oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#max CoreSecurityList#max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#min CoreSecurityList#min}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Min
        {
            get;
            set;
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#source_port_range CoreSecurityList#source_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
        public oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange? SourcePortRange
        {
            get;
            set;
        }
    }
}
