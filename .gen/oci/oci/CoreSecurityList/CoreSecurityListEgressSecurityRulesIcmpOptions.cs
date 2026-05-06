using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptions")]
    public class CoreSecurityListEgressSecurityRulesIcmpOptions : oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#type CoreSecurityList#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}")]
        public double Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#code CoreSecurityList#code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Code
        {
            get;
            set;
        }
    }
}
