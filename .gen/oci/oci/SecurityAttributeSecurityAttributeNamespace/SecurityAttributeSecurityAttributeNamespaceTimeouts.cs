using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SecurityAttributeSecurityAttributeNamespace
{
    [JsiiByValue(fqn: "oci.securityAttributeSecurityAttributeNamespace.SecurityAttributeSecurityAttributeNamespaceTimeouts")]
    public class SecurityAttributeSecurityAttributeNamespaceTimeouts : oci.SecurityAttributeSecurityAttributeNamespace.ISecurityAttributeSecurityAttributeNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#create SecurityAttributeSecurityAttributeNamespace#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#delete SecurityAttributeSecurityAttributeNamespace#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#update SecurityAttributeSecurityAttributeNamespace#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
