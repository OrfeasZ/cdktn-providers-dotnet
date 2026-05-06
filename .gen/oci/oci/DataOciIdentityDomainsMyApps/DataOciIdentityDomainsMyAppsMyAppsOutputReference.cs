using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyApps
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyAppsMyAppsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyAppsMyAppsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyAppsMyAppsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyAppsMyAppsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "app", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsAppList\"}")]
        public virtual oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsAppList App
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsAppList>()!;
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

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "launchUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsOwnerList\"}")]
        public virtual oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsOwnerList Owner
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsOwnerList>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsTagsList>()!;
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

        [JsiiProperty(name: "userWalletArtifact", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsUserWalletArtifactList\"}")]
        public virtual oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsUserWalletArtifactList UserWalletArtifact
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyAppsUserWalletArtifactList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyApps.DataOciIdentityDomainsMyAppsMyApps\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyApps.IDataOciIdentityDomainsMyAppsMyApps? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyApps.IDataOciIdentityDomainsMyAppsMyApps?>();
            set => SetInstanceProperty(value);
        }
    }
}
