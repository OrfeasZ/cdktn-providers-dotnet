using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SecurityAttributeSecurityAttribute
{
    [JsiiInterface(nativeType: typeof(ISecurityAttributeSecurityAttributeValidator), fullyQualifiedName: "oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeValidator")]
    public interface ISecurityAttributeSecurityAttributeValidator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#validator_type SecurityAttributeSecurityAttribute#validator_type}.</summary>
        [JsiiProperty(name: "validatorType", typeJson: "{\"primitive\":\"string\"}")]
        string ValidatorType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#values SecurityAttributeSecurityAttribute#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Values
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityAttributeSecurityAttributeValidator), fullyQualifiedName: "oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeValidator")]
        internal sealed class _Proxy : DeputyBase, oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeValidator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#validator_type SecurityAttributeSecurityAttribute#validator_type}.</summary>
            [JsiiProperty(name: "validatorType", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidatorType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#values SecurityAttributeSecurityAttribute#values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Values
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
