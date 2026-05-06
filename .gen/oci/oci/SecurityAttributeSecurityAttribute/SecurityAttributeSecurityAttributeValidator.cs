using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SecurityAttributeSecurityAttribute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeValidator")]
    public class SecurityAttributeSecurityAttributeValidator : oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeValidator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#validator_type SecurityAttributeSecurityAttribute#validator_type}.</summary>
        [JsiiProperty(name: "validatorType", typeJson: "{\"primitive\":\"string\"}")]
        public string ValidatorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#values SecurityAttributeSecurityAttribute#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
