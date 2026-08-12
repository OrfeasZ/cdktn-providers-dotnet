using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags
    {
        private object? _definedTags;

        /// <summary>defined_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_user#defined_tags IdentityDomainsUser#defined_tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _definedTags = value;
            }
        }

        private object? _freeformTags;

        /// <summary>freeform_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/identity_domains_user#freeform_tags IdentityDomainsUser#freeform_tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _freeformTags = value;
            }
        }
    }
}
