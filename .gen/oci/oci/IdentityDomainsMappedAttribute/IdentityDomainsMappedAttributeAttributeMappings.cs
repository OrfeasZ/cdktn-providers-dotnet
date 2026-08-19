using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMappedAttribute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeAttributeMappings")]
    public class IdentityDomainsMappedAttributeAttributeMappings : oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeAttributeMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_mapped_attribute#idcs_attribute_name IdentityDomainsMappedAttribute#idcs_attribute_name}.</summary>
        [JsiiProperty(name: "idcsAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public string IdcsAttributeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_mapped_attribute#managed_object_attribute_name IdentityDomainsMappedAttribute#managed_object_attribute_name}.</summary>
        [JsiiProperty(name: "managedObjectAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public string ManagedObjectAttributeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_mapped_attribute#applies_to_actions IdentityDomainsMappedAttribute#applies_to_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appliesToActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AppliesToActions
        {
            get;
            set;
        }

        private object? _required;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_mapped_attribute#required IdentityDomainsMappedAttribute#required}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Required
        {
            get => _required;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _required = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/identity_domains_mapped_attribute#saml_format IdentityDomainsMappedAttribute#saml_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "samlFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SamlFormat
        {
            get;
            set;
        }
    }
}
