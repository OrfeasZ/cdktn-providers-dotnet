using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreBootVolume
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_boot_volume oci_core_boot_volume}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreBootVolume.DataOciCoreBootVolume), fullyQualifiedName: "oci.dataOciCoreBootVolume.DataOciCoreBootVolume", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreBootVolume.DataOciCoreBootVolumeConfig\"}}]")]
    public class DataOciCoreBootVolume : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_boot_volume oci_core_boot_volume} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreBootVolume(Constructs.Construct scope, string id, oci.DataOciCoreBootVolume.IDataOciCoreBootVolumeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreBootVolume.IDataOciCoreBootVolumeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreBootVolume(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreBootVolume(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreBootVolume resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreBootVolume to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreBootVolume that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreBootVolume to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreBootVolume to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_boot_volume#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreBootVolume that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreBootVolume to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreBootVolume.DataOciCoreBootVolume), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreBootVolume.DataOciCoreBootVolume))!;

        [JsiiProperty(name: "autoTunedVpusPerGb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoTunedVpusPerGb
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autotunePolicies", typeJson: "{\"fqn\":\"oci.dataOciCoreBootVolume.DataOciCoreBootVolumeAutotunePoliciesList\"}")]
        public virtual oci.DataOciCoreBootVolume.DataOciCoreBootVolumeAutotunePoliciesList AutotunePolicies
        {
            get => GetInstanceProperty<oci.DataOciCoreBootVolume.DataOciCoreBootVolumeAutotunePoliciesList>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootVolumeReplicas", typeJson: "{\"fqn\":\"oci.dataOciCoreBootVolume.DataOciCoreBootVolumeBootVolumeReplicasList\"}")]
        public virtual oci.DataOciCoreBootVolume.DataOciCoreBootVolumeBootVolumeReplicasList BootVolumeReplicas
        {
            get => GetInstanceProperty<oci.DataOciCoreBootVolume.DataOciCoreBootVolumeBootVolumeReplicasList>()!;
        }

        [JsiiProperty(name: "bootVolumeReplicasDeletion", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BootVolumeReplicasDeletion
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoTuneEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoTuneEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHydrated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHydrated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeInGbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeInGbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeInMbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreBootVolume.DataOciCoreBootVolumeSourceDetailsList\"}")]
        public virtual oci.DataOciCoreBootVolume.DataOciCoreBootVolumeSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreBootVolume.DataOciCoreBootVolumeSourceDetailsList>()!;
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

        [JsiiProperty(name: "volumeGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpusPerGb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpusPerGb
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "xrcKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XrcKmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BootVolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bootVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootVolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
