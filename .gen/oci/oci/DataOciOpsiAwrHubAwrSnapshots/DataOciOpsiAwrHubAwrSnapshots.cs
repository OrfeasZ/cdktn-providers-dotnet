using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiAwrHubAwrSnapshots
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshots oci_opsi_awr_hub_awr_snapshots}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshots), fullyQualifiedName: "oci.dataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshots", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsConfig\"}}]")]
    public class DataOciOpsiAwrHubAwrSnapshots : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshots oci_opsi_awr_hub_awr_snapshots} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOpsiAwrHubAwrSnapshots(Constructs.Construct scope, string id, oci.DataOciOpsiAwrHubAwrSnapshots.IDataOciOpsiAwrHubAwrSnapshotsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOpsiAwrHubAwrSnapshots.IDataOciOpsiAwrHubAwrSnapshotsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiAwrHubAwrSnapshots(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiAwrHubAwrSnapshots(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOpsiAwrHubAwrSnapshots resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOpsiAwrHubAwrSnapshots to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOpsiAwrHubAwrSnapshots that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOpsiAwrHubAwrSnapshots to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOpsiAwrHubAwrSnapshots to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshots#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOpsiAwrHubAwrSnapshots that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOpsiAwrHubAwrSnapshots to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshots), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciOpsiAwrHubAwrSnapshots.IDataOciOpsiAwrHubAwrSnapshotsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciOpsiAwrHubAwrSnapshots.IDataOciOpsiAwrHubAwrSnapshotsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciOpsiAwrHubAwrSnapshots.IDataOciOpsiAwrHubAwrSnapshotsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeGreaterThanOrEqualTo")]
        public virtual void ResetTimeGreaterThanOrEqualTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeLessThanOrEqualTo")]
        public virtual void ResetTimeLessThanOrEqualTo()
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
        = GetStaticProperty<string>(typeof(oci.DataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshots))!;

        [JsiiProperty(name: "awrSnapshotCollection", typeJson: "{\"fqn\":\"oci.dataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsAwrSnapshotCollectionList\"}")]
        public virtual oci.DataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsAwrSnapshotCollectionList AwrSnapshotCollection
        {
            get => GetInstanceProperty<oci.DataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsAwrSnapshotCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsFilterList\"}")]
        public virtual oci.DataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awrHubIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwrHubIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awrSourceDatabaseIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwrSourceDatabaseIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOpsiAwrHubAwrSnapshots.DataOciOpsiAwrHubAwrSnapshotsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeGreaterThanOrEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeGreaterThanOrEqualToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeLessThanOrEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeLessThanOrEqualToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "awrHubId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwrHubId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "awrSourceDatabaseIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwrSourceDatabaseIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeGreaterThanOrEqualTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeLessThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLessThanOrEqualTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
