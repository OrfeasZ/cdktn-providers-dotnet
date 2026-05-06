using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultSecurityList
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptions")]
    public class CoreDefaultSecurityListEgressSecurityRulesIcmpOptions : oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#type CoreDefaultSecurityList#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}")]
        public double Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#code CoreDefaultSecurityList#code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Code
        {
            get;
            set;
        }
    }
}
