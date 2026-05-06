using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyGroups
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "appRoles", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupAppRolesList\"}")]
        public virtual oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupAppRolesList AppRoles
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupAppRolesList>()!;
        }

        [JsiiProperty(name: "creationMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grants", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupGrantsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupGrantsList Grants
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupGrantsList>()!;
        }

        [JsiiProperty(name: "owners", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOwnersList\"}")]
        public virtual oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOwnersList Owners
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupOwnersList>()!;
        }

        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupPasswordPolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupPasswordPolicyList PasswordPolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupPasswordPolicyList>()!;
        }

        [JsiiProperty(name: "syncedFromApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupSyncedFromAppList\"}")]
        public virtual oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupSyncedFromAppList SyncedFromApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupSyncedFromAppList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyGroups.DataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroup\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyGroups.IDataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroup? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyGroups.IDataOciIdentityDomainsMyGroupsMyGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroup?>();
            set => SetInstanceProperty(value);
        }
    }
}
