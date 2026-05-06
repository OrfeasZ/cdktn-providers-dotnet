using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGroup
{
    [JsiiByValue(fqn: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags")]
    public class IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags : oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags
    {
        private object? _definedTags;

        /// <summary>defined_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#defined_tags IdentityDomainsGroup#defined_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DefinedTags
        {
            get => _definedTags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _definedTags = value;
            }
        }

        private object? _freeformTags;

        /// <summary>freeform_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#freeform_tags IdentityDomainsGroup#freeform_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FreeformTags
        {
            get => _freeformTags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _freeformTags = value;
            }
        }
    }
}
