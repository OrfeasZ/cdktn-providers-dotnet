using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.person.PersonConfig")]
    public class PersonConfig : stripe.Person.IPersonConfig
    {
        /// <summary>The account the person is associated with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#account Person#account}
        /// </remarks>
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}")]
        public string Account
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#additional_tos_acceptances Person#additional_tos_acceptances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalTosAcceptances", typeJson: "{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptances\"}", isOptional: true)]
        public stripe.Person.IPersonAdditionalTosAcceptances? AdditionalTosAcceptances
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#address Person#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.person.PersonAddress\"}", isOptional: true)]
        public stripe.Person.IPersonAddress? Address
        {
            get;
            set;
        }

        /// <summary>The Kana variation of the person's address (Japan only).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#address_kana Person#address_kana}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressKana", typeJson: "{\"fqn\":\"stripe.person.PersonAddressKana\"}", isOptional: true)]
        public stripe.Person.IPersonAddressKana? AddressKana
        {
            get;
            set;
        }

        /// <summary>The Kanji variation of the person's address (Japan only).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#address_kanji Person#address_kanji}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressKanji", typeJson: "{\"fqn\":\"stripe.person.PersonAddressKanji\"}", isOptional: true)]
        public stripe.Person.IPersonAddressKanji? AddressKanji
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#dob Person#dob}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.person.PersonDob\"}", isOptional: true)]
        public stripe.Person.IPersonDob? Dob
        {
            get;
            set;
        }

        /// <summary>Documents that may be submitted to satisfy various informational requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#documents Person#documents}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "documents", typeJson: "{\"fqn\":\"stripe.person.PersonDocuments\"}", isOptional: true)]
        public stripe.Person.IPersonDocuments? Documents
        {
            get;
            set;
        }

        /// <summary>The person's email address. Also available for accounts where [controller.requirement_collection](/api/accounts/object#account_object-controller-requirement_collection) is `stripe`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#email Person#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        /// <summary>The person's first name. Also available for accounts where [controller.requirement_collection](/api/accounts/object#account_object-controller-requirement_collection) is `stripe`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#first_name Person#first_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstName
        {
            get;
            set;
        }

        /// <summary>The Kana variation of the person's first name (Japan only). Also available for accounts where [controller.requirement_collection](/api/accounts/object#account_object-controller-requirement_collection) is `stripe`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#first_name_kana Person#first_name_kana}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstNameKana", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstNameKana
        {
            get;
            set;
        }

        /// <summary>The Kanji variation of the person's first name (Japan only). Also available for accounts where [controller.requirement_collection](/api/accounts/object#account_object-controller-requirement_collection) is `stripe`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#first_name_kanji Person#first_name_kanji}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstNameKanji", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstNameKanji
        {
            get;
            set;
        }

        /// <summary>A list of alternate names or aliases that the person is known by.</summary>
        /// <remarks>
        /// Also available for accounts where <a href="/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a> is <c>stripe</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#full_name_aliases Person#full_name_aliases}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fullNameAliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FullNameAliases
        {
            get;
            set;
        }

        /// <summary>The person's gender.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#gender Person#gender}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gender", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Gender
        {
            get;
            set;
        }

        /// <summary>The person's ID number, as appropriate for their country.</summary>
        /// <remarks>
        /// For example, a social security number in the U.S., social insurance number in Canada, etc. Instead of the number itself, you can also provide a <a href="https://docs.stripe.com/js/tokens/create_token?type=pii">PII token provided by Stripe.js</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#id_number Person#id_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdNumber
        {
            get;
            set;
        }

        /// <summary>The person's secondary ID number, as appropriate for their country, will be used for enhanced verification checks.</summary>
        /// <remarks>
        /// In Thailand, this would be the laser code found on the back of an ID card. Instead of the number itself, you can also provide a <a href="https://docs.stripe.com/js/tokens/create_token?type=pii">PII token provided by Stripe.js</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#id_number_secondary Person#id_number_secondary}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idNumberSecondary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdNumberSecondary
        {
            get;
            set;
        }

        /// <summary>The person's last name. Also available for accounts where [controller.requirement_collection](/api/accounts/object#account_object-controller-requirement_collection) is `stripe`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#last_name Person#last_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastName
        {
            get;
            set;
        }

        /// <summary>The Kana variation of the person's last name (Japan only). Also available for accounts where [controller.requirement_collection](/api/accounts/object#account_object-controller-requirement_collection) is `stripe`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#last_name_kana Person#last_name_kana}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastNameKana", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastNameKana
        {
            get;
            set;
        }

        /// <summary>The Kanji variation of the person's last name (Japan only). Also available for accounts where [controller.requirement_collection](/api/accounts/object#account_object-controller-requirement_collection) is `stripe`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#last_name_kanji Person#last_name_kanji}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastNameKanji", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastNameKanji
        {
            get;
            set;
        }

        /// <summary>The person's maiden name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#maiden_name Person#maiden_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maidenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaidenName
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#metadata Person#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>The country where the person is a national.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#nationality Person#nationality}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nationality", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Nationality
        {
            get;
            set;
        }

        /// <summary>A [person token](https://docs.stripe.com/connect/account-tokens), used to securely provide details to the person.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#person_token Person#person_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "personToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersonToken
        {
            get;
            set;
        }

        /// <summary>The person's phone number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#phone Person#phone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Phone
        {
            get;
            set;
        }

        /// <summary>Indicates if the person or any of their representatives, family members, or other closely related persons, declares that they hold or have held an important public job or function, in any jurisdiction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#political_exposure Person#political_exposure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "politicalExposure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PoliticalExposure
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#registered_address Person#registered_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.person.PersonRegisteredAddress\"}", isOptional: true)]
        public stripe.Person.IPersonRegisteredAddress? RegisteredAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#relationship Person#relationship}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relationship", typeJson: "{\"fqn\":\"stripe.person.PersonRelationship\"}", isOptional: true)]
        public stripe.Person.IPersonRelationship? Relationship
        {
            get;
            set;
        }

        /// <summary>The last four digits of the person's Social Security number (U.S. only).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ssn_last_4 Person#ssn_last_4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssnLast4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SsnLast4
        {
            get;
            set;
        }

        /// <summary>Demographic data related to the person.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#us_cfpb_data Person#us_cfpb_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usCfpbData", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbData\"}", isOptional: true)]
        public stripe.Person.IPersonUsCfpbData? UsCfpbData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#verification Person#verification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verification", typeJson: "{\"fqn\":\"stripe.person.PersonVerification\"}", isOptional: true)]
        public stripe.Person.IPersonVerification? Verification
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
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
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
