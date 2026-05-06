using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementCloudDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cloudDbHomeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudDbHomeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databasePlatformName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabasePlatformName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseSubType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSubType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbManagementConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbManagementConfigList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbManagementConfigList DbManagementConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbManagementConfigList>()!;
        }

        [JsiiProperty(name: "dbmgmtFeatureConfigs", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbmgmtFeatureConfigsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbmgmtFeatureConfigsList DbmgmtFeatureConfigs
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbmgmtFeatureConfigsList>()!;
        }

        [JsiiProperty(name: "dbSystemInfo", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbSystemInfoList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbSystemInfoList DbSystemInfo
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsDbSystemInfoList>()!;
        }

        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUniqueName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "instanceDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsInstanceDetailsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsInstanceDetailsList InstanceDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItemsInstanceDetailsList>()!;
        }

        [JsiiProperty(name: "parentContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDatabases.DataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementCloudDatabases.IDataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDatabases.IDataOciDatabaseManagementCloudDatabasesCloudDatabaseCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
