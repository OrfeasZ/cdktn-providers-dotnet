using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLustreFileStorageObjectStorageLinkSyncJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/lustre_file_storage_object_storage_link_sync_job oci_lustre_file_storage_object_storage_link_sync_job}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciLustreFileStorageObjectStorageLinkSyncJob.DataOciLustreFileStorageObjectStorageLinkSyncJob), fullyQualifiedName: "oci.dataOciLustreFileStorageObjectStorageLinkSyncJob.DataOciLustreFileStorageObjectStorageLinkSyncJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciLustreFileStorageObjectStorageLinkSyncJob.DataOciLustreFileStorageObjectStorageLinkSyncJobConfig\"}}]")]
    public class DataOciLustreFileStorageObjectStorageLinkSyncJob : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/lustre_file_storage_object_storage_link_sync_job oci_lustre_file_storage_object_storage_link_sync_job} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciLustreFileStorageObjectStorageLinkSyncJob(Constructs.Construct scope, string id, oci.DataOciLustreFileStorageObjectStorageLinkSyncJob.IDataOciLustreFileStorageObjectStorageLinkSyncJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciLustreFileStorageObjectStorageLinkSyncJob.IDataOciLustreFileStorageObjectStorageLinkSyncJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLustreFileStorageObjectStorageLinkSyncJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLustreFileStorageObjectStorageLinkSyncJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciLustreFileStorageObjectStorageLinkSyncJob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciLustreFileStorageObjectStorageLinkSyncJob to import.</param>
        /// <param name="importFromId">The id of the existing DataOciLustreFileStorageObjectStorageLinkSyncJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciLustreFileStorageObjectStorageLinkSyncJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciLustreFileStorageObjectStorageLinkSyncJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/lustre_file_storage_object_storage_link_sync_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciLustreFileStorageObjectStorageLinkSyncJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciLustreFileStorageObjectStorageLinkSyncJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciLustreFileStorageObjectStorageLinkSyncJob.DataOciLustreFileStorageObjectStorageLinkSyncJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciLustreFileStorageObjectStorageLinkSyncJob.DataOciLustreFileStorageObjectStorageLinkSyncJob))!;

        [JsiiProperty(name: "bytesTransferred", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BytesTransferred
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isOverwrite", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOverwrite
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jobType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lustreFileSystemPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LustreFileSystemPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStoragePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStoragePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectsTransferred", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectsTransferred
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skippedErrorCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkippedErrorCount
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

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalObjectsScanned", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalObjectsScanned
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStorageLinkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectStorageLinkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "syncJobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SyncJobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectStorageLinkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageLinkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "syncJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncJobId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
