using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsUsers
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsUsersUsersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsUsersUsersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUsersUsersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUsersUsersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "addresses", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersAddressesList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersAddressesList Addresses
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersAddressesList>()!;
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "emails", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersEmailsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersEmailsList Emails
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersEmailsList>()!;
        }

        [JsiiProperty(name: "entitlements", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersEntitlementsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersEntitlementsList Entitlements
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersEntitlementsList>()!;
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

        [JsiiProperty(name: "groups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersGroupsList Groups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersGroupsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "ims", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersImsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersImsList Ims
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersImsList>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersNameList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersNameList Name
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersNameList>()!;
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

        [JsiiProperty(name: "phoneNumbers", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersPhoneNumbersList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersPhoneNumbersList PhoneNumbers
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersPhoneNumbersList>()!;
        }

        [JsiiProperty(name: "photos", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersPhotosList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersPhotosList Photos
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersPhotosList>()!;
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

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersRolesList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersRolesList Roles
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersRolesList>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersTagsList>()!;
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

        [JsiiProperty(name: "urnietfparamsscimschemasextensionenterprise20User", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasextensionenterprise20UserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasextensionenterprise20UserList Urnietfparamsscimschemasextensionenterprise20User
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasextensionenterprise20UserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionadaptiveUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionadaptiveUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionadaptiveUserList UrnietfparamsscimschemasoracleidcsextensionadaptiveUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionadaptiveUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensioncapabilitiesUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUserList UrnietfparamsscimschemasoracleidcsextensioncapabilitiesUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensioncapabilitiesUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbCredentialsUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUserList UrnietfparamsscimschemasoracleidcsextensiondbCredentialsUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiondbCredentialsUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbUserUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiondbUserUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiondbUserUserList UrnietfparamsscimschemasoracleidcsextensiondbUserUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiondbUserUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosUserUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserList UrnietfparamsscimschemasoracleidcsextensionkerberosUserUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionkerberosUserUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmfaUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserList UrnietfparamsscimschemasoracleidcsextensionmfaUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionmfaUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionOciTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionOciTagsList UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionOciTagsList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionpasswordlessUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserList UrnietfparamsscimschemasoracleidcsextensionpasswordlessUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionpasswordlessUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionpasswordStateUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionpasswordStateUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionpasswordStateUserList UrnietfparamsscimschemasoracleidcsextensionpasswordStateUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionpasswordStateUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionposixUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionposixUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionposixUserList UrnietfparamsscimschemasoracleidcsextensionposixUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionposixUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserList UrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsecurityQuestionsUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfChangeUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionselfChangeUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionselfChangeUserList UrnietfparamsscimschemasoracleidcsextensionselfChangeUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionselfChangeUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfRegistrationUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserList UrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsffUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsffUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsffUserList UrnietfparamsscimschemasoracleidcsextensionsffUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsffUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialAccountUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserList UrnietfparamsscimschemasoracleidcsextensionsocialAccountUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiontermsOfUseUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserList UrnietfparamsscimschemasoracleidcsextensiontermsOfUseUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensiontermsOfUseUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserCredentialsUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserList UrnietfparamsscimschemasoracleidcsextensionuserCredentialsUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserCredentialsUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserStateUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserList UrnietfparamsscimschemasoracleidcsextensionuserStateUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserStateUserList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionuserUser", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserUserList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserUserList UrnietfparamsscimschemasoracleidcsextensionuserUser
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersUrnietfparamsscimschemasoracleidcsextensionuserUserList>()!;
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

        [JsiiProperty(name: "x509Certificates", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersX509CertificatesList\"}")]
        public virtual oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersX509CertificatesList X509Certificates
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsersX509CertificatesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUsers.DataOciIdentityDomainsUsersUsers\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsUsers.IDataOciIdentityDomainsUsersUsers? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUsers.IDataOciIdentityDomainsUsersUsers?>();
            set => SetInstanceProperty(value);
        }
    }
}
