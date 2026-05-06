using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsGroup
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "appRoles", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupAppRolesList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupAppRolesList AppRoles
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupAppRolesList>()!;
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

        [JsiiProperty(name: "grants", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupGrantsList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupGrantsList Grants
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupGrantsList>()!;
        }

        [JsiiProperty(name: "owners", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOwnersList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOwnersList Owners
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupOwnersList>()!;
        }

        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupPasswordPolicyList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupPasswordPolicyList PasswordPolicy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupPasswordPolicyList>()!;
        }

        [JsiiProperty(name: "syncedFromApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupSyncedFromAppList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupSyncedFromAppList SyncedFromApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupSyncedFromAppList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroup\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsGroup.IDataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroup? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.IDataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroup?>();
            set => SetInstanceProperty(value);
        }
    }
}
