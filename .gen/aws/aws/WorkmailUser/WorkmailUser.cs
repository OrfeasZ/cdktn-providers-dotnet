using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkmailUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user aws_workmail_user}.</summary>
    [JsiiClass(nativeType: typeof(aws.WorkmailUser.WorkmailUser), fullyQualifiedName: "aws.workmailUser.WorkmailUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.workmailUser.WorkmailUserConfig\"}}]")]
    public class WorkmailUser : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user aws_workmail_user} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WorkmailUser(Constructs.Construct scope, string id, aws.WorkmailUser.IWorkmailUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.WorkmailUser.IWorkmailUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkmailUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkmailUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a WorkmailUser resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WorkmailUser to import.</param>
        /// <param name="importFromId">The id of the existing WorkmailUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WorkmailUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WorkmailUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workmail_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WorkmailUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WorkmailUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.WorkmailUser.WorkmailUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetCity")]
        public virtual void ResetCity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompany")]
        public virtual void ResetCompany()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCountry")]
        public virtual void ResetCountry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDepartment")]
        public virtual void ResetDepartment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstName")]
        public virtual void ResetFirstName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHiddenFromGlobalAddressList")]
        public virtual void ResetHiddenFromGlobalAddressList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityProviderUserId")]
        public virtual void ResetIdentityProviderUserId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitials")]
        public virtual void ResetInitials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobTitle")]
        public virtual void ResetJobTitle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastName")]
        public virtual void ResetLastName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOffice")]
        public virtual void ResetOffice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreet")]
        public virtual void ResetStreet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTelephone")]
        public virtual void ResetTelephone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserRole")]
        public virtual void ResetUserRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZipCode")]
        public virtual void ResetZipCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.WorkmailUser.WorkmailUser))!;

        [JsiiProperty(name: "disabledDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisabledDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabledDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnabledDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityProviderIdentityStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProviderIdentityStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mailboxDeprovisionedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailboxDeprovisionedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mailboxProvisionedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailboxProvisionedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "companyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompanyInput
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
        [JsiiProperty(name: "departmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DepartmentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "firstNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hiddenFromGlobalAddressListInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HiddenFromGlobalAddressListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProviderUserIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityProviderUserIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitialsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobTitleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobTitleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "officeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OfficeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "organizationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrganizationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "telephoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TelephoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zipCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZipCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "company", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Company
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

        [JsiiProperty(name: "department", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Department
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hiddenFromGlobalAddressList", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object HiddenFromGlobalAddressList
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

        [JsiiProperty(name: "identityProviderUserId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProviderUserId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initials", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Initials
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobTitle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "office", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Office
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "street", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Street
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "telephone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Telephone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zipCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZipCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
