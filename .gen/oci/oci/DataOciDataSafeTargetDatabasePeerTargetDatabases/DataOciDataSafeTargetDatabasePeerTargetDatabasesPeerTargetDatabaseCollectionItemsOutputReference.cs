using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeTargetDatabasePeerTargetDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsDatabaseDetailsList\"}")]
        public virtual oci.DataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsDatabaseDetailsList DatabaseDetails
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsDatabaseDetailsList>()!;
        }

        [JsiiProperty(name: "databaseUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseUniqueName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataguardAssociationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataguardAssociationId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Key
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsTlsConfigList\"}")]
        public virtual oci.DataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsTlsConfigList TlsConfig
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItemsTlsConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabasePeerTargetDatabases.DataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeTargetDatabasePeerTargetDatabases.IDataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabasePeerTargetDatabases.IDataOciDataSafeTargetDatabasePeerTargetDatabasesPeerTargetDatabaseCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
