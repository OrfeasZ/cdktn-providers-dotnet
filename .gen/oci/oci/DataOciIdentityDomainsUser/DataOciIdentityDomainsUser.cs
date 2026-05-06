using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_user oci_identity_domains_user}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUser), fullyQualifiedName: "oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserConfig\"}}]")]
    public class DataOciIdentityDomainsUser : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_user oci_identity_domains_user} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsUser(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsUser.IDataOciIdentityDomainsUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsUser.IDataOciIdentityDomainsUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsUser resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsUser to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributeSets")]
        public virtual void ResetAttributeSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUser))!;

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "addresses", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserAddressesList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserAddressesList Addresses
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserAddressesList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emails", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserEmailsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserEmailsList Emails
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserEmailsList>()!;
        }

        [JsiiProperty(name: "entitlements", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserEntitlementsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserEntitlementsList Entitlements
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserEntitlementsList>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forceDelete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ForceDelete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "groups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserGroupsList Groups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserGroupsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ims", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserImsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserImsList Ims
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserImsList>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserNameList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserNameList Name
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserNameList>()!;
        }

        [JsiiProperty(name: "nickName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NickName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneNumbers", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserPhoneNumbersList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserPhoneNumbersList PhoneNumbers
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserPhoneNumbersList>()!;
        }

        [JsiiProperty(name: "photos", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserPhotosList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserPhotosList Photos
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserPhotosList>()!;
        }

        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredLanguage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserRolesList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserRolesList Roles
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserRolesList>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasextensionenterprise20User", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserList Urnietfparamsscimschemasextensionenterprise20User
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionadaptiveUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserList UrnietfparamsscimschemasoracleidcsextensionadaptiveUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensioncapabilitiesUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUserList UrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbCredentialsUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUserList UrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbUserUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbUserUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbUserUserList UrnietfparamsscimschemasoracleidcsextensiondbUserUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiondbUserUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosUserUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserList UrnietfparamsscimschemasoracleidcsextensionkerberosUserUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmfaUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserList UrnietfparamsscimschemasoracleidcsextensionmfaUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsList UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionOciTagsList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionpasswordlessUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserList UrnietfparamsscimschemasoracleidcsextensionpasswordlessUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionpasswordStateUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordStateUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordStateUserList UrnietfparamsscimschemasoracleidcsextensionpasswordStateUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionpasswordStateUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionposixUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUserList UrnietfparamsscimschemasoracleidcsextensionposixUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionposixUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserList UrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfChangeUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUserList UrnietfparamsscimschemasoracleidcsextensionselfChangeUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfChangeUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfRegistrationUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserList UrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsffUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUserList UrnietfparamsscimschemasoracleidcsextensionsffUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsffUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialAccountUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserList UrnietfparamsscimschemasoracleidcsextensionsocialAccountUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiontermsOfUseUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserList UrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserCredentialsUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserList UrnietfparamsscimschemasoracleidcsextensionuserCredentialsUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserStateUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserList UrnietfparamsscimschemasoracleidcsextensionuserStateUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserList UrnietfparamsscimschemasoracleidcsextensionuserUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserList>()!;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "x509Certificates", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserX509CertificatesList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserX509CertificatesList X509Certificates
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserX509CertificatesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttributeSetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
