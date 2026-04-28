using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudStorageBoxSnapshots
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_snapshots hcloud_storage_box_snapshots}.</summary>
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshots), fullyQualifiedName: "hcloud.dataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshots", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"hcloud.dataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshotsConfig\"}}]")]
    public class DataHcloudStorageBoxSnapshots : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_snapshots hcloud_storage_box_snapshots} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataHcloudStorageBoxSnapshots(Constructs.Construct scope, string id, hcloud.DataHcloudStorageBoxSnapshots.IDataHcloudStorageBoxSnapshotsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, hcloud.DataHcloudStorageBoxSnapshots.IDataHcloudStorageBoxSnapshotsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBoxSnapshots(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudStorageBoxSnapshots(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataHcloudStorageBoxSnapshots resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataHcloudStorageBoxSnapshots to import.</param>
        /// <param name="importFromId">The id of the existing DataHcloudStorageBoxSnapshots that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataHcloudStorageBoxSnapshots to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataHcloudStorageBoxSnapshots to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/data-sources/storage_box_snapshots#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataHcloudStorageBoxSnapshots that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataHcloudStorageBoxSnapshots to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(hcloud.DataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshots), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetWithSelector")]
        public virtual void ResetWithSelector()
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
        = GetStaticProperty<string>(typeof(hcloud.DataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshots))!;

        [JsiiProperty(name: "snapshots", typeJson: "{\"fqn\":\"hcloud.dataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshotsSnapshotsList\"}")]
        public virtual hcloud.DataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshotsSnapshotsList Snapshots
        {
            get => GetInstanceProperty<hcloud.DataHcloudStorageBoxSnapshots.DataHcloudStorageBoxSnapshotsSnapshotsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageBoxIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageBoxIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "withSelectorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WithSelectorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "storageBoxId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageBoxId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WithSelector
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
