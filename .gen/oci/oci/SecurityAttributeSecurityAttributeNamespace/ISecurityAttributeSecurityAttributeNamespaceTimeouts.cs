using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SecurityAttributeSecurityAttributeNamespace
{
    [JsiiInterface(nativeType: typeof(ISecurityAttributeSecurityAttributeNamespaceTimeouts), fullyQualifiedName: "oci.securityAttributeSecurityAttributeNamespace.SecurityAttributeSecurityAttributeNamespaceTimeouts")]
    public interface ISecurityAttributeSecurityAttributeNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#create SecurityAttributeSecurityAttributeNamespace#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#delete SecurityAttributeSecurityAttributeNamespace#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#update SecurityAttributeSecurityAttributeNamespace#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityAttributeSecurityAttributeNamespaceTimeouts), fullyQualifiedName: "oci.securityAttributeSecurityAttributeNamespace.SecurityAttributeSecurityAttributeNamespaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.SecurityAttributeSecurityAttributeNamespace.ISecurityAttributeSecurityAttributeNamespaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#create SecurityAttributeSecurityAttributeNamespace#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#delete SecurityAttributeSecurityAttributeNamespace#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute_namespace#update SecurityAttributeSecurityAttributeNamespace#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
