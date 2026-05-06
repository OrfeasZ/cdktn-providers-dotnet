using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationJobs
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationJobsJobCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationJobsJobCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationJobsJobCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationJobsJobCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "collectTracesData", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsCollectTracesDataList\"}")]
        public virtual oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsCollectTracesDataList CollectTracesData
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsCollectTracesDataList>()!;
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

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "migrationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parameterFileVersions", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsParameterFileVersionsList\"}")]
        public virtual oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsParameterFileVersionsList ParameterFileVersions
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsParameterFileVersionsList>()!;
        }

        [JsiiProperty(name: "progress", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsProgressList\"}")]
        public virtual oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsProgressList Progress
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsProgressList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suspendTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuspendTrigger
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "unsupportedObjects", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsUnsupportedObjectsList\"}")]
        public virtual oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsUnsupportedObjectsList UnsupportedObjects
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItemsUnsupportedObjectsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationJobs.DataOciDatabaseMigrationJobsJobCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationJobs.IDataOciDatabaseMigrationJobsJobCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationJobs.IDataOciDatabaseMigrationJobsJobCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
