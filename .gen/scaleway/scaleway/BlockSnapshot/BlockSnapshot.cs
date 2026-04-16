using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.BlockSnapshot
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/block_snapshot scaleway_block_snapshot}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.BlockSnapshot.BlockSnapshot), fullyQualifiedName: "scaleway.blockSnapshot.BlockSnapshot", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotConfig\"}}]")]
    public class BlockSnapshot : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/block_snapshot scaleway_block_snapshot} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BlockSnapshot(Constructs.Construct scope, string id, scaleway.BlockSnapshot.IBlockSnapshotConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.BlockSnapshot.IBlockSnapshotConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BlockSnapshot(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BlockSnapshot(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BlockSnapshot resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BlockSnapshot to import.</param>
        /// <param name="importFromId">The id of the existing BlockSnapshot that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BlockSnapshot to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BlockSnapshot to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/block_snapshot#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BlockSnapshot that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BlockSnapshot to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.BlockSnapshot.BlockSnapshot), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putExport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotExport\"}}]")]
        public virtual void PutExport(scaleway.BlockSnapshot.IBlockSnapshotExport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.BlockSnapshot.IBlockSnapshotExport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotImport\"}}]")]
        public virtual void PutImport(scaleway.BlockSnapshot.IBlockSnapshotImport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.BlockSnapshot.IBlockSnapshotImport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.BlockSnapshot.IBlockSnapshotTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.BlockSnapshot.IBlockSnapshotTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExport")]
        public virtual void ResetExport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImport")]
        public virtual void ResetImport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeId")]
        public virtual void ResetVolumeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZone")]
        public virtual void ResetZone()
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
        = GetStaticProperty<string>(typeof(scaleway.BlockSnapshot.BlockSnapshot))!;

        [JsiiProperty(name: "export", typeJson: "{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotExportOutputReference\"}")]
        public virtual scaleway.BlockSnapshot.BlockSnapshotExportOutputReference Export
        {
            get => GetInstanceProperty<scaleway.BlockSnapshot.BlockSnapshotExportOutputReference>()!;
        }

        [JsiiProperty(name: "import", typeJson: "{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotImportOutputReference\"}")]
        public virtual scaleway.BlockSnapshot.BlockSnapshotImportOutputReference Import
        {
            get => GetInstanceProperty<scaleway.BlockSnapshot.BlockSnapshotImportOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotTimeoutsOutputReference\"}")]
        public virtual scaleway.BlockSnapshot.BlockSnapshotTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.BlockSnapshot.BlockSnapshotTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportInput", typeJson: "{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotExport\"}", isOptional: true)]
        public virtual scaleway.BlockSnapshot.IBlockSnapshotExport? ExportInput
        {
            get => GetInstanceProperty<scaleway.BlockSnapshot.IBlockSnapshotExport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "importInput", typeJson: "{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotImport\"}", isOptional: true)]
        public virtual scaleway.BlockSnapshot.IBlockSnapshotImport? ImportInput
        {
            get => GetInstanceProperty<scaleway.BlockSnapshot.IBlockSnapshotImport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.blockSnapshot.BlockSnapshotTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
