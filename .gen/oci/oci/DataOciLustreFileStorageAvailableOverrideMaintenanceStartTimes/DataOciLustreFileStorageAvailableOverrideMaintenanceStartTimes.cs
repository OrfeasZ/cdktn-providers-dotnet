using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/lustre_file_storage_available_override_maintenance_start_times oci_lustre_file_storage_available_override_maintenance_start_times}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes), fullyQualifiedName: "oci.dataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesConfig\"}}]")]
    public class DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/lustre_file_storage_available_override_maintenance_start_times oci_lustre_file_storage_available_override_maintenance_start_times} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes(Constructs.Construct scope, string id, oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.IDataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.IDataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes to import.</param>
        /// <param name="importFromId">The id of the existing DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/lustre_file_storage_available_override_maintenance_start_times#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.IDataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.IDataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.IDataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.IDataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDate")]
        public virtual void ResetDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
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
        = GetStaticProperty<string>(typeof(oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes))!;

        [JsiiProperty(name: "availableOverrideMaintenanceStartTimeCollection", typeJson: "{\"fqn\":\"oci.dataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesAvailableOverrideMaintenanceStartTimeCollectionList\"}")]
        public virtual oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesAvailableOverrideMaintenanceStartTimeCollectionList AvailableOverrideMaintenanceStartTimeCollection
        {
            get => GetInstanceProperty<oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesAvailableOverrideMaintenanceStartTimeCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilterList\"}")]
        public virtual oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DateInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.IDataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciLustreFileStorageAvailableOverrideMaintenanceStartTimes.DataOciLustreFileStorageAvailableOverrideMaintenanceStartTimesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Date
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
    }
}
