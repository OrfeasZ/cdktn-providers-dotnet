using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsDatabaseToolsMcpServers
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessTokenExpiryInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessTokenExpiryInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "builtInRoles", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsBuiltInRolesList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsBuiltInRolesList BuiltInRoles
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsBuiltInRolesList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customRoles", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsCustomRolesList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsCustomRolesList CustomRoles
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsCustomRolesList>()!;
        }

        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsConnectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "domainAppId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainAppId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsEndpointsList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsEndpointsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsLocksList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsLocksList>()!;
        }

        [JsiiProperty(name: "refreshTokenExpiryInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefreshTokenExpiryInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "relatedResource", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsRelatedResourceList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsRelatedResourceList RelatedResource
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsRelatedResourceList>()!;
        }

        [JsiiProperty(name: "runtimeIdentity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeIdentity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsStorageList\"}")]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsStorageList Storage
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItemsStorageList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsDatabaseToolsMcpServers.DataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseToolsDatabaseToolsMcpServers.IDataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsDatabaseToolsMcpServers.IDataOciDatabaseToolsDatabaseToolsMcpServersDatabaseToolsMcpServerCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
