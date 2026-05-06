using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fusion_apps_fusion_environment_data_masking_activities oci_fusion_apps_fusion_environment_data_masking_activities}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivities), fullyQualifiedName: "oci.dataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivities", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesConfig\"}}]")]
    public class DataOciFusionAppsFusionEnvironmentDataMaskingActivities : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fusion_apps_fusion_environment_data_masking_activities oci_fusion_apps_fusion_environment_data_masking_activities} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciFusionAppsFusionEnvironmentDataMaskingActivities(Constructs.Construct scope, string id, oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.IDataOciFusionAppsFusionEnvironmentDataMaskingActivitiesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.IDataOciFusionAppsFusionEnvironmentDataMaskingActivitiesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFusionAppsFusionEnvironmentDataMaskingActivities(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFusionAppsFusionEnvironmentDataMaskingActivities(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciFusionAppsFusionEnvironmentDataMaskingActivities resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciFusionAppsFusionEnvironmentDataMaskingActivities to import.</param>
        /// <param name="importFromId">The id of the existing DataOciFusionAppsFusionEnvironmentDataMaskingActivities that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciFusionAppsFusionEnvironmentDataMaskingActivities to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciFusionAppsFusionEnvironmentDataMaskingActivities to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fusion_apps_fusion_environment_data_masking_activities#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciFusionAppsFusionEnvironmentDataMaskingActivities that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciFusionAppsFusionEnvironmentDataMaskingActivities to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivities), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.IDataOciFusionAppsFusionEnvironmentDataMaskingActivitiesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.IDataOciFusionAppsFusionEnvironmentDataMaskingActivitiesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.IDataOciFusionAppsFusionEnvironmentDataMaskingActivitiesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
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
        = GetStaticProperty<string>(typeof(oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivities))!;

        [JsiiProperty(name: "dataMaskingActivityCollection", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesDataMaskingActivityCollectionList\"}")]
        public virtual oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesDataMaskingActivityCollectionList DataMaskingActivityCollection
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesDataMaskingActivityCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesFilterList\"}")]
        public virtual oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentDataMaskingActivities.DataOciFusionAppsFusionEnvironmentDataMaskingActivitiesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fusionEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FusionEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FusionEnvironmentId
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

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
