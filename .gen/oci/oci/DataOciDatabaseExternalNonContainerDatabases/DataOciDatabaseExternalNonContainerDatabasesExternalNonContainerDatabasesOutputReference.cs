using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseExternalNonContainerDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseEdition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseEdition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseManagementConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesDatabaseManagementConfigList\"}")]
        public virtual oci.DataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesDatabaseManagementConfigList DatabaseManagementConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesDatabaseManagementConfigList>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbPacks", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbPacks
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NcharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationsInsightsConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOperationsInsightsConfigList\"}")]
        public virtual oci.DataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOperationsInsightsConfigList OperationsInsightsConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesOperationsInsightsConfigList>()!;
        }

        [JsiiProperty(name: "stackMonitoringConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesStackMonitoringConfigList\"}")]
        public virtual oci.DataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesStackMonitoringConfigList StackMonitoringConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabasesStackMonitoringConfigList>()!;
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

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExternalNonContainerDatabases.DataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabases\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseExternalNonContainerDatabases.IDataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabases? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExternalNonContainerDatabases.IDataOciDatabaseExternalNonContainerDatabasesExternalNonContainerDatabases?>();
            set => SetInstanceProperty(value);
        }
    }
}
