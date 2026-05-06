using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalDetails
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "databaseStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseStatus
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

        [JsiiProperty(name: "dbmgmtFeatureConfigs", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsDbmgmtFeatureConfigsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsDbmgmtFeatureConfigsList DbmgmtFeatureConfigs
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsDbmgmtFeatureConfigsList>()!;
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
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

        [JsiiProperty(name: "isCluster", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCluster
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managedDatabaseGroups", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsManagedDatabaseGroupsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsManagedDatabaseGroupsList ManagedDatabaseGroups
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItemsManagedDatabaseGroupsList>()!;
        }

        [JsiiProperty(name: "managementOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementOption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentContainerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentContainerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageSystemId
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

        [JsiiProperty(name: "workloadType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabases.DataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedDatabases.IDataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabases.IDataOciDatabaseManagementManagedDatabasesManagedDatabaseCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
