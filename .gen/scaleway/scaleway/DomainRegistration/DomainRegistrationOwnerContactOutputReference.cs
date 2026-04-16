using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRegistration.DomainRegistrationOwnerContactOutputReference), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainRegistrationOwnerContactOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainRegistrationOwnerContactOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationOwnerContactOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRegistrationOwnerContactOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExtensionEu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu\"}}]")]
        public virtual void PutExtensionEu(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtensionFr", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr\"}}]")]
        public virtual void PutExtensionFr(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddressLine2")]
        public virtual void ResetAddressLine2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompanyName")]
        public virtual void ResetCompanyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailAlt")]
        public virtual void ResetEmailAlt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtensionEu")]
        public virtual void ResetExtensionEu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtensionFr")]
        public virtual void ResetExtensionFr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtensionNl")]
        public virtual void ResetExtensionNl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFaxNumber")]
        public virtual void ResetFaxNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLang")]
        public virtual void ResetLang()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResale")]
        public virtual void ResetResale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWhoisOptIn")]
        public virtual void ResetWhoisOptIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "extensionEu", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEuOutputReference\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionEuOutputReference ExtensionEu
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionEuOutputReference>()!;
        }

        [JsiiProperty(name: "extensionFr", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrOutputReference\"}")]
        public virtual scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrOutputReference ExtensionFr
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.DomainRegistrationOwnerContactExtensionFrOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressLine1Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AddressLine1Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressLine2Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AddressLine2Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "companyIdentificationCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompanyIdentificationCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "companyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompanyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "countryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CountryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailAltInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailAltInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionEuInput", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu? ExtensionEuInput
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionFrInput", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr? ExtensionFrInput
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionNlInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExtensionNlInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "faxNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FaxNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "langInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LangInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "legalFormInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LegalFormInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resaleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ResaleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vatIdentificationCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VatIdentificationCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "whoisOptInInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WhoisOptInInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zipInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZipInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "addressLine1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine1
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "addressLine2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine2
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "companyIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyIdentificationCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailAlt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAlt
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extensionNl", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExtensionNl
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "faxNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaxNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firstname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Firstname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lang", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Lang
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Lastname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "legalForm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LegalForm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resale", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Resale
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vatIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VatIdentificationCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "whoisOptIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object WhoisOptIn
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "zip", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zip
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContact\"}", isOptional: true)]
        public virtual scaleway.DomainRegistration.IDomainRegistrationOwnerContact? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContact?>();
            set => SetInstanceProperty(value);
        }
    }
}
