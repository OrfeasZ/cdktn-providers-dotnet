using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserConfig), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserConfig")]
    public interface IIdentityDomainsUserConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#idcs_endpoint IdentityDomainsUser#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string IdcsEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#schemas IdentityDomainsUser#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Schemas
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_name IdentityDomainsUser#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#active IdentityDomainsUser#active}.</summary>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#addresses IdentityDomainsUser#addresses}
        /// </remarks>
        [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#attributes IdentityDomainsUser#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#attribute_sets IdentityDomainsUser#attribute_sets}.</summary>
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#authorization IdentityDomainsUser#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#description IdentityDomainsUser#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#display_name IdentityDomainsUser#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>emails block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#emails IdentityDomainsUser#emails}
        /// </remarks>
        [JsiiProperty(name: "emails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserEmails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Emails
        {
            get
            {
                return null;
            }
        }

        /// <summary>entitlements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#entitlements IdentityDomainsUser#entitlements}
        /// </remarks>
        [JsiiProperty(name: "entitlements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserEntitlements\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Entitlements
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#external_id IdentityDomainsUser#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#force_delete IdentityDomainsUser#force_delete}.</summary>
        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>ims block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#ims IdentityDomainsUser#ims}
        /// </remarks>
        [JsiiProperty(name: "ims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserIms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ims
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#locale IdentityDomainsUser#locale}.</summary>
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Locale
        {
            get
            {
                return null;
            }
        }

        /// <summary>name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#name IdentityDomainsUser#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserName? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#nick_name IdentityDomainsUser#nick_name}.</summary>
        [JsiiProperty(name: "nickName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NickName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#ocid IdentityDomainsUser#ocid}.</summary>
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#password IdentityDomainsUser#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>phone_numbers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#phone_numbers IdentityDomainsUser#phone_numbers}
        /// </remarks>
        [JsiiProperty(name: "phoneNumbers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserPhoneNumbers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PhoneNumbers
        {
            get
            {
                return null;
            }
        }

        /// <summary>photos block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#photos IdentityDomainsUser#photos}
        /// </remarks>
        [JsiiProperty(name: "photos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserPhotos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Photos
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_language IdentityDomainsUser#preferred_language}.</summary>
        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#profile_url IdentityDomainsUser#profile_url}.</summary>
        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#resource_type_schema_version IdentityDomainsUser#resource_type_schema_version}.</summary>
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTypeSchemaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>roles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#roles IdentityDomainsUser#roles}
        /// </remarks>
        [JsiiProperty(name: "roles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserRoles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Roles
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#tags IdentityDomainsUser#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#timeouts IdentityDomainsUser#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#timezone IdentityDomainsUser#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timezone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#title IdentityDomainsUser#title}.</summary>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Title
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasextensionenterprise20user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasextensionenterprise20user IdentityDomainsUser#urnietfparamsscimschemasextensionenterprise20user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasextensionenterprise20User", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User? Urnietfparamsscimschemasextensionenterprise20User
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionadaptive_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionadaptive_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionadaptive_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionadaptiveUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser? UrnietfparamsscimschemasoracleidcsextensionadaptiveUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensioncapabilities_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensioncapabilities_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensioncapabilities_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensioncapabilitiesUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser? UrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensiondb_credentials_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensiondb_credentials_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensiondb_credentials_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbCredentialsUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser? UrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionkerberos_user_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionkerberos_user_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionkerberos_user_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosUserUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser? UrnietfparamsscimschemasoracleidcsextensionkerberosUserUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionmfa_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionmfa_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionmfa_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmfaUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser? UrnietfparamsscimschemasoracleidcsextensionmfaUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextension_oci_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextension_oci_tags IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextension_oci_tags}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags? UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionpasswordless_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionpasswordless_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionpasswordless_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionpasswordlessUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser? UrnietfparamsscimschemasoracleidcsextensionpasswordlessUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionposix_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionposix_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionposix_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionposixUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser? UrnietfparamsscimschemasoracleidcsextensionposixUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser? UrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionself_change_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionself_change_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionself_change_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfChangeUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUser? UrnietfparamsscimschemasoracleidcsextensionselfChangeUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionself_registration_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionself_registration_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionself_registration_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfRegistrationUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser? UrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsff_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsff_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsff_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsffUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser? UrnietfparamsscimschemasoracleidcsextensionsffUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsocial_account_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsocial_account_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsocial_account_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialAccountUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser? UrnietfparamsscimschemasoracleidcsextensionsocialAccountUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionterms_of_use_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionterms_of_use_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionterms_of_use_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiontermsOfUseUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser? UrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionuser_state_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionuser_state_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionuser_state_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserStateUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser? UrnietfparamsscimschemasoracleidcsextensionuserStateUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionuser_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionuser_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionuser_user}
        /// </remarks>
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser? UrnietfparamsscimschemasoracleidcsextensionuserUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_type IdentityDomainsUser#user_type}.</summary>
        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserType
        {
            get
            {
                return null;
            }
        }

        /// <summary>x509certificates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#x509certificates IdentityDomainsUser#x509certificates}
        /// </remarks>
        [JsiiProperty(name: "x509Certificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserX509Certificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? X509Certificates
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserConfig), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#idcs_endpoint IdentityDomainsUser#idcs_endpoint}.</summary>
            [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcsEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#schemas IdentityDomainsUser#schemas}.</summary>
            [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Schemas
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_name IdentityDomainsUser#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#active IdentityDomainsUser#active}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>addresses block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#addresses IdentityDomainsUser#addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Addresses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#attributes IdentityDomainsUser#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#attribute_sets IdentityDomainsUser#attribute_sets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeSets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#authorization IdentityDomainsUser#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authorization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#description IdentityDomainsUser#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#display_name IdentityDomainsUser#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>emails block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#emails IdentityDomainsUser#emails}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserEmails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Emails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>entitlements block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#entitlements IdentityDomainsUser#entitlements}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entitlements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserEntitlements\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Entitlements
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#external_id IdentityDomainsUser#external_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#force_delete IdentityDomainsUser#force_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForceDelete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ims block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#ims IdentityDomainsUser#ims}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserIms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ims
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#locale IdentityDomainsUser#locale}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Locale
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#name IdentityDomainsUser#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserName\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserName? Name
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserName?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#nick_name IdentityDomainsUser#nick_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nickName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NickName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#ocid IdentityDomainsUser#ocid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#password IdentityDomainsUser#password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>phone_numbers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#phone_numbers IdentityDomainsUser#phone_numbers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumbers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserPhoneNumbers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PhoneNumbers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>photos block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#photos IdentityDomainsUser#photos}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "photos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserPhotos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Photos
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_language IdentityDomainsUser#preferred_language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#profile_url IdentityDomainsUser#profile_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#resource_type_schema_version IdentityDomainsUser#resource_type_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTypeSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>roles block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#roles IdentityDomainsUser#roles}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "roles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserRoles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Roles
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#tags IdentityDomainsUser#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#timeouts IdentityDomainsUser#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserTimeouts\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#timezone IdentityDomainsUser#timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timezone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#title IdentityDomainsUser#title}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Title
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>urnietfparamsscimschemasextensionenterprise20user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasextensionenterprise20user IdentityDomainsUser#urnietfparamsscimschemasextensionenterprise20user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasextensionenterprise20User", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User? Urnietfparamsscimschemasextensionenterprise20User
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionadaptive_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionadaptive_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionadaptive_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionadaptiveUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser? UrnietfparamsscimschemasoracleidcsextensionadaptiveUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensioncapabilities_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensioncapabilities_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensioncapabilities_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensioncapabilitiesUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser? UrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensiondb_credentials_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensiondb_credentials_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensiondb_credentials_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbCredentialsUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser? UrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionkerberos_user_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionkerberos_user_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionkerberos_user_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosUserUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser? UrnietfparamsscimschemasoracleidcsextensionkerberosUserUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionmfa_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionmfa_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionmfa_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmfaUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser? UrnietfparamsscimschemasoracleidcsextensionmfaUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextension_oci_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextension_oci_tags IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextension_oci_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags? UrnietfparamsscimschemasoracleidcsextensionOciTags
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionpasswordless_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionpasswordless_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionpasswordless_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionpasswordlessUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser? UrnietfparamsscimschemasoracleidcsextensionpasswordlessUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionposix_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionposix_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionposix_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionposixUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser? UrnietfparamsscimschemasoracleidcsextensionposixUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser? UrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionself_change_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionself_change_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionself_change_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfChangeUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUser? UrnietfparamsscimschemasoracleidcsextensionselfChangeUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionself_registration_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionself_registration_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionself_registration_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfRegistrationUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser? UrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionsff_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsff_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsff_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsffUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser? UrnietfparamsscimschemasoracleidcsextensionsffUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionsocial_account_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsocial_account_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsocial_account_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialAccountUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser? UrnietfparamsscimschemasoracleidcsextensionsocialAccountUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionterms_of_use_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionterms_of_use_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionterms_of_use_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiontermsOfUseUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser? UrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionuser_state_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionuser_state_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionuser_state_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserStateUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser? UrnietfparamsscimschemasoracleidcsextensionuserStateUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser?>();
            }

            /// <summary>urnietfparamsscimschemasoracleidcsextensionuser_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionuser_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionuser_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser? UrnietfparamsscimschemasoracleidcsextensionuserUser
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_type IdentityDomainsUser#user_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>x509certificates block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#x509certificates IdentityDomainsUser#x509certificates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "x509Certificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserX509Certificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? X509Certificates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
