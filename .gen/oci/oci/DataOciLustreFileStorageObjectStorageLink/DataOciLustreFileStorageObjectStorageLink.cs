using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLustreFileStorageObjectStorageLink
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/lustre_file_storage_object_storage_link oci_lustre_file_storage_object_storage_link}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciLustreFileStorageObjectStorageLink.DataOciLustreFileStorageObjectStorageLink), fullyQualifiedName: "oci.dataOciLustreFileStorageObjectStorageLink.DataOciLustreFileStorageObjectStorageLink", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciLustreFileStorageObjectStorageLink.DataOciLustreFileStorageObjectStorageLinkConfig\"}}]")]
    public class DataOciLustreFileStorageObjectStorageLink : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/lustre_file_storage_object_storage_link oci_lustre_file_storage_object_storage_link} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciLustreFileStorageObjectStorageLink(Constructs.Construct scope, string id, oci.DataOciLustreFileStorageObjectStorageLink.IDataOciLustreFileStorageObjectStorageLinkConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciLustreFileStorageObjectStorageLink.IDataOciLustreFileStorageObjectStorageLinkConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLustreFileStorageObjectStorageLink(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLustreFileStorageObjectStorageLink(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciLustreFileStorageObjectStorageLink resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciLustreFileStorageObjectStorageLink to import.</param>
        /// <param name="importFromId">The id of the existing DataOciLustreFileStorageObjectStorageLink that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciLustreFileStorageObjectStorageLink to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciLustreFileStorageObjectStorageLink to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/lustre_file_storage_object_storage_link#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciLustreFileStorageObjectStorageLink that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciLustreFileStorageObjectStorageLink to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciLustreFileStorageObjectStorageLink.DataOciLustreFileStorageObjectStorageLink), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciLustreFileStorageObjectStorageLink.DataOciLustreFileStorageObjectStorageLink))!;

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentJobId
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

        [JsiiProperty(name: "fileSystemPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemPath
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

        [JsiiProperty(name: "isOverwrite", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOverwrite
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastJobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lustreFileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LustreFileSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStoragePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStoragePrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startExportToObjectTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartExportToObjectTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "startImportFromObjectTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartImportFromObjectTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stopExportToObjectTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StopExportToObjectTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "stopImportFromObjectTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StopImportFromObjectTrigger
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

        [JsiiOptional]
        [JsiiProperty(name: "objectStorageLinkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectStorageLinkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "objectStorageLinkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageLinkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
