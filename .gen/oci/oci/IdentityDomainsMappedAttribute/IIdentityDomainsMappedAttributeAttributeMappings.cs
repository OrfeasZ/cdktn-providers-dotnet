using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMappedAttribute
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsMappedAttributeAttributeMappings), fullyQualifiedName: "oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeAttributeMappings")]
    public interface IIdentityDomainsMappedAttributeAttributeMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#idcs_attribute_name IdentityDomainsMappedAttribute#idcs_attribute_name}.</summary>
        [JsiiProperty(name: "idcsAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsAttributeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#managed_object_attribute_name IdentityDomainsMappedAttribute#managed_object_attribute_name}.</summary>
        [JsiiProperty(name: "managedObjectAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedObjectAttributeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#applies_to_actions IdentityDomainsMappedAttribute#applies_to_actions}.</summary>
        [JsiiProperty(name: "appliesToActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AppliesToActions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#required IdentityDomainsMappedAttribute#required}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Required
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#saml_format IdentityDomainsMappedAttribute#saml_format}.</summary>
        [JsiiProperty(name: "samlFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SamlFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsMappedAttributeAttributeMappings), fullyQualifiedName: "oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeAttributeMappings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeAttributeMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#idcs_attribute_name IdentityDomainsMappedAttribute#idcs_attribute_name}.</summary>
            [JsiiProperty(name: "idcsAttributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsAttributeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#managed_object_attribute_name IdentityDomainsMappedAttribute#managed_object_attribute_name}.</summary>
            [JsiiProperty(name: "managedObjectAttributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedObjectAttributeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#applies_to_actions IdentityDomainsMappedAttribute#applies_to_actions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appliesToActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AppliesToActions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#required IdentityDomainsMappedAttribute#required}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Required
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#saml_format IdentityDomainsMappedAttribute#saml_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "samlFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SamlFormat
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
