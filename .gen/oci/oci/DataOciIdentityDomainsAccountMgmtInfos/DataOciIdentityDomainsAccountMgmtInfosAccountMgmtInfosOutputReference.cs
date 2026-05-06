using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsAccountMgmtInfos
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountMgmtInfoId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountMgmtInfoId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "app", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosAppList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosAppList App
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosAppList>()!;
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

        [JsiiProperty(name: "compositeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompositeKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "doNotBackFillGrants", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DoNotBackFillGrants
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "doNotPerformActionOnTarget", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DoNotPerformActionOnTarget
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "favorite", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Favorite
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "isAccount", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccount
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastAccessed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastAccessed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "matchingOwners", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosMatchingOwnersList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosMatchingOwnersList MatchingOwners
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosMatchingOwnersList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectClass", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosObjectClassList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosObjectClassList ObjectClass
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosObjectClassList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationContext", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationContext
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOwnerList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOwnerList Owner
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosOwnerList>()!;
        }

        [JsiiProperty(name: "previewOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PreviewOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosResourceTypeList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosResourceTypeList ResourceType
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosResourceTypeList>()!;
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "syncResponse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncResponse
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "syncSituation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncSituation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "syncTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userWalletArtifact", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosUserWalletArtifactList\"}")]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosUserWalletArtifactList UserWalletArtifact
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfosUserWalletArtifactList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsAccountMgmtInfos.DataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfos\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsAccountMgmtInfos.IDataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfos? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsAccountMgmtInfos.IDataOciIdentityDomainsAccountMgmtInfosAccountMgmtInfos?>();
            set => SetInstanceProperty(value);
        }
    }
}
