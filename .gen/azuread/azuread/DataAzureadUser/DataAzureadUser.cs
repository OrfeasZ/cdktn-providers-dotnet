using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/user azuread_user}.</summary>
    [JsiiClass(nativeType: typeof(azuread.DataAzureadUser.DataAzureadUser), fullyQualifiedName: "azuread.dataAzureadUser.DataAzureadUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"azuread.dataAzureadUser.DataAzureadUserConfig\"}}]")]
    public class DataAzureadUser : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/user azuread_user} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzureadUser(Constructs.Construct scope, string id, azuread.DataAzureadUser.IDataAzureadUserConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.DataAzureadUser.IDataAzureadUserConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzureadUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzureadUser resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzureadUser to import.</param>
        /// <param name="importFromId">The id of the existing DataAzureadUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzureadUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzureadUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzureadUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzureadUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.DataAzureadUser.DataAzureadUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.dataAzureadUser.DataAzureadUserTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.DataAzureadUser.IDataAzureadUserTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.DataAzureadUser.IDataAzureadUserTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEmployeeId")]
        public virtual void ResetEmployeeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMail")]
        public virtual void ResetMail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMailNickname")]
        public virtual void ResetMailNickname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectId")]
        public virtual void ResetObjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPrincipalName")]
        public virtual void ResetUserPrincipalName()
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
        = GetStaticProperty<string>(typeof(azuread.DataAzureadUser.DataAzureadUser))!;

        [JsiiProperty(name: "accountEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ageGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgeGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "businessPhones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BusinessPhones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consentProvidedForMinor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsentProvidedForMinor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costCenter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostCenter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "department", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Department
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "division", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Division
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "employeeHireDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmployeeHireDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "employeeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmployeeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalUserState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalUserState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "faxNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaxNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GivenName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ImAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobTitle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mobilePhone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MobilePhone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "officeLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfficeLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesDistinguishedName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesDistinguishedName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesImmutableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesImmutableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesSamAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesSamAccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesSecurityIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesSecurityIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "onpremisesSyncEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OnpremisesSyncEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "onpremisesUserPrincipalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnpremisesUserPrincipalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "otherMails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OtherMails
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostalCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredLanguage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ProxyAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "showInAddressList", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShowInAddressList
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streetAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Surname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.dataAzureadUser.DataAzureadUserTimeoutsOutputReference\"}")]
        public virtual azuread.DataAzureadUser.DataAzureadUserTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.DataAzureadUser.DataAzureadUserTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "usageLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "employeeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmployeeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mailNicknameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MailNicknameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.DataAzureadUser.IDataAzureadUserTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.dataAzureadUser.DataAzureadUserTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPrincipalNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPrincipalNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "employeeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmployeeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mailNickname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailNickname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPrincipalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPrincipalName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
