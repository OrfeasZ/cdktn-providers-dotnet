using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyRequestableGroups
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "members", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsMembersList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsMembersList Members
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsMembersList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsMetaList>()!;
        }

        [JsiiProperty(name: "nonUniqueDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NonUniqueDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiongroupGroup", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupList UrnietfparamsscimschemasoracleidcsextensiongroupGroup
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsUrnietfparamsscimschemasoracleidcsextensiongroupGroupList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionrequestableGroup", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsUrnietfparamsscimschemasoracleidcsextensionrequestableGroupList\"}")]
        public virtual oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsUrnietfparamsscimschemasoracleidcsextensionrequestableGroupList UrnietfparamsscimschemasoracleidcsextensionrequestableGroup
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroupsUrnietfparamsscimschemasoracleidcsextensionrequestableGroupList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyRequestableGroups.DataOciIdentityDomainsMyRequestableGroupsMyRequestableGroups\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyRequestableGroups.IDataOciIdentityDomainsMyRequestableGroupsMyRequestableGroups? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyRequestableGroups.IDataOciIdentityDomainsMyRequestableGroupsMyRequestableGroups?>();
            set => SetInstanceProperty(value);
        }
    }
}
