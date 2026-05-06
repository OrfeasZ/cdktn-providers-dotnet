using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsUser
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountRecoveryRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountRecoveryRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "accounts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserAccountsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserAccountsList Accounts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserAccountsList>()!;
        }

        [JsiiProperty(name: "applicableAuthenticationTargetApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserApplicableAuthenticationTargetAppList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserApplicableAuthenticationTargetAppList ApplicableAuthenticationTargetApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserApplicableAuthenticationTargetAppList>()!;
        }

        [JsiiProperty(name: "appRoles", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserAppRolesList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserAppRolesList AppRoles
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserAppRolesList>()!;
        }

        [JsiiProperty(name: "bypassNotification", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BypassNotification
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "creationMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "delegatedAuthenticationTargetApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetAppList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetAppList DelegatedAuthenticationTargetApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserDelegatedAuthenticationTargetAppList>()!;
        }

        [JsiiProperty(name: "doNotShowGettingStarted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DoNotShowGettingStarted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "grants", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserGrantsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserGrantsList Grants
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserGrantsList>()!;
        }

        [JsiiProperty(name: "groupMembershipLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupMembershipLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsAppRolesLimitedToGroups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserIdcsAppRolesLimitedToGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserIdcsAppRolesLimitedToGroupsList IdcsAppRolesLimitedToGroups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserIdcsAppRolesLimitedToGroupsList>()!;
        }

        [JsiiProperty(name: "isAccountRecoveryEnrolled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccountRecoveryEnrolled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isAuthenticationDelegated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAuthenticationDelegated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFederatedUser", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFederatedUser
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isGroupMembershipNormalized", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsGroupMembershipNormalized
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isGroupMembershipSyncedToUsersGroups", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsGroupMembershipSyncedToUsersGroups
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "notificationEmailTemplateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationEmailTemplateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredUiLandingPage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredUiLandingPage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceUser", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ServiceUser
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportAccounts", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSupportAccountsList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSupportAccountsList SupportAccounts
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSupportAccountsList>()!;
        }

        [JsiiProperty(name: "syncedFromApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromAppList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromAppList SyncedFromApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserSyncedFromAppList>()!;
        }

        [JsiiProperty(name: "userFlowControlledByExternalClient", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UserFlowControlledByExternalClient
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "userProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userToken", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserUserTokenList\"}")]
        public virtual oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserUserTokenList UserToken
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUserUserTokenList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsUser.DataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsUser.IDataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsUser.IDataOciIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
