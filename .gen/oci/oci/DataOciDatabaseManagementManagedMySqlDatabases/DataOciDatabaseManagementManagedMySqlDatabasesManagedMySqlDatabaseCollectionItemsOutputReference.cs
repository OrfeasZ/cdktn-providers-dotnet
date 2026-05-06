using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabases.DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabases.DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "heatWaveClusterDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeatWaveClusterDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "heatWaveManagementType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeatWaveManagementType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "heatWaveMemorySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HeatWaveMemorySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "heatWaveNodes", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabases.DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsHeatWaveNodesList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabases.DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsHeatWaveNodesList HeatWaveNodes
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabases.DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItemsHeatWaveNodesList>()!;
        }

        [JsiiProperty(name: "heatWaveNodeShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeatWaveNodeShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isHeatWaveActive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHeatWaveActive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHeatWaveEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHeatWaveEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLakehouseEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLakehouseEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managementState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreatedHeatWave", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreatedHeatWave
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabases.DataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabases.IDataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabases.IDataOciDatabaseManagementManagedMySqlDatabasesManagedMySqlDatabaseCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
