using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserConfig")]
    public class IdentityDomainsUserConfig : oci.IdentityDomainsUser.IIdentityDomainsUserConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#idcs_endpoint IdentityDomainsUser#idcs_endpoint}.</summary>
        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string IdcsEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#schemas IdentityDomainsUser#schemas}.</summary>
        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Schemas
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_name IdentityDomainsUser#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }

        private object? _active;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#active IdentityDomainsUser#active}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Active
        {
            get => _active;
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
                _active = value;
            }
        }

        private object? _addresses;

        /// <summary>addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#addresses IdentityDomainsUser#addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Addresses
        {
            get => _addresses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserAddresses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserAddresses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _addresses = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#attributes IdentityDomainsUser#attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Attributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#attribute_sets IdentityDomainsUser#attribute_sets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AttributeSets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#authorization IdentityDomainsUser#authorization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Authorization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#description IdentityDomainsUser#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#display_name IdentityDomainsUser#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        private object? _emails;

        /// <summary>emails block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#emails IdentityDomainsUser#emails}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserEmails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Emails
        {
            get => _emails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserEmails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserEmails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _emails = value;
            }
        }

        private object? _entitlements;

        /// <summary>entitlements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#entitlements IdentityDomainsUser#entitlements}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entitlements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserEntitlements\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Entitlements
        {
            get => _entitlements;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserEntitlements[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserEntitlements).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _entitlements = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#external_id IdentityDomainsUser#external_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalId
        {
            get;
            set;
        }

        private object? _forceDelete;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#force_delete IdentityDomainsUser#force_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ForceDelete
        {
            get => _forceDelete;
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
                _forceDelete = value;
            }
        }

        private object? _ims;

        /// <summary>ims block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#ims IdentityDomainsUser#ims}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserIms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ims
        {
            get => _ims;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserIms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserIms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ims = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#locale IdentityDomainsUser#locale}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Locale
        {
            get;
            set;
        }

        /// <summary>name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#name IdentityDomainsUser#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserName\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserName? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#nick_name IdentityDomainsUser#nick_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nickName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NickName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#ocid IdentityDomainsUser#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#password IdentityDomainsUser#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        private object? _phoneNumbers;

        /// <summary>phone_numbers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#phone_numbers IdentityDomainsUser#phone_numbers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phoneNumbers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserPhoneNumbers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PhoneNumbers
        {
            get => _phoneNumbers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserPhoneNumbers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserPhoneNumbers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _phoneNumbers = value;
            }
        }

        private object? _photos;

        /// <summary>photos block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#photos IdentityDomainsUser#photos}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "photos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserPhotos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Photos
        {
            get => _photos;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserPhotos[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserPhotos).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _photos = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#preferred_language IdentityDomainsUser#preferred_language}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredLanguage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#profile_url IdentityDomainsUser#profile_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProfileUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#resource_type_schema_version IdentityDomainsUser#resource_type_schema_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceTypeSchemaVersion
        {
            get;
            set;
        }

        private object? _roles;

        /// <summary>roles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#roles IdentityDomainsUser#roles}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "roles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserRoles\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Roles
        {
            get => _roles;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserRoles[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserRoles).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _roles = value;
            }
        }

        private object? _tags;

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#tags IdentityDomainsUser#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tags
        {
            get => _tags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tags = value;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#timeouts IdentityDomainsUser#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserTimeouts\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#timezone IdentityDomainsUser#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#title IdentityDomainsUser#title}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Title
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasextensionenterprise20user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasextensionenterprise20user IdentityDomainsUser#urnietfparamsscimschemasextensionenterprise20user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasextensionenterprise20User", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User? Urnietfparamsscimschemasextensionenterprise20User
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionadaptive_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionadaptive_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionadaptive_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionadaptiveUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser? UrnietfparamsscimschemasoracleidcsextensionadaptiveUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensioncapabilities_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensioncapabilities_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensioncapabilities_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensioncapabilitiesUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser? UrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensiondb_credentials_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensiondb_credentials_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensiondb_credentials_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbCredentialsUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser? UrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionkerberos_user_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionkerberos_user_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionkerberos_user_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosUserUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUser? UrnietfparamsscimschemasoracleidcsextensionkerberosUserUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionmfa_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionmfa_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionmfa_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmfaUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUser? UrnietfparamsscimschemasoracleidcsextensionmfaUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextension_oci_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextension_oci_tags IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextension_oci_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTags? UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionpasswordless_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionpasswordless_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionpasswordless_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionpasswordlessUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUser? UrnietfparamsscimschemasoracleidcsextensionpasswordlessUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionposix_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionposix_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionposix_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionposixUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUser? UrnietfparamsscimschemasoracleidcsextensionposixUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsecurity_questions_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser? UrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionself_change_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionself_change_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionself_change_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfChangeUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUser? UrnietfparamsscimschemasoracleidcsextensionselfChangeUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionself_registration_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionself_registration_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionself_registration_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfRegistrationUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser? UrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsff_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsff_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsff_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsffUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUser? UrnietfparamsscimschemasoracleidcsextensionsffUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionsocial_account_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionsocial_account_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionsocial_account_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialAccountUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser? UrnietfparamsscimschemasoracleidcsextensionsocialAccountUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionterms_of_use_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionterms_of_use_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionterms_of_use_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiontermsOfUseUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser? UrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionuser_state_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionuser_state_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionuser_state_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserStateUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser? UrnietfparamsscimschemasoracleidcsextensionuserStateUser
        {
            get;
            set;
        }

        /// <summary>urnietfparamsscimschemasoracleidcsextensionuser_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#urnietfparamsscimschemasoracleidcsextensionuser_user IdentityDomainsUser#urnietfparamsscimschemasoracleidcsextensionuser_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserUser", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser? UrnietfparamsscimschemasoracleidcsextensionuserUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_type IdentityDomainsUser#user_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserType
        {
            get;
            set;
        }

        private object? _x509Certificates;

        /// <summary>x509certificates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#x509certificates IdentityDomainsUser#x509certificates}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "x509Certificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserX509Certificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? X509Certificates
        {
            get => _x509Certificates;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserX509Certificates[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserX509Certificates).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _x509Certificates = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
