using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sensitive_type_group_grouped_sensitive_types oci_data_safe_sensitive_type_group_grouped_sensitive_types}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes), fullyQualifiedName: "oci.dataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesConfig\"}}]")]
    public class DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sensitive_type_group_grouped_sensitive_types oci_data_safe_sensitive_type_group_grouped_sensitive_types} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes(Constructs.Construct scope, string id, oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.IDataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.IDataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sensitive_type_group_grouped_sensitive_types#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.IDataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.IDataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.IDataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetSensitiveTypeId")]
        public virtual void ResetSensitiveTypeId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesFilterList\"}")]
        public virtual oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesFilterList>()!;
        }

        [JsiiProperty(name: "groupedSensitiveTypeCollection", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesGroupedSensitiveTypeCollectionList\"}")]
        public virtual oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesGroupedSensitiveTypeCollectionList GroupedSensitiveTypeCollection
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesGroupedSensitiveTypeCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypes.DataOciDataSafeSensitiveTypeGroupGroupedSensitiveTypesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "sensitiveTypeGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SensitiveTypeGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sensitiveTypeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SensitiveTypeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sensitiveTypeGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveTypeGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sensitiveTypeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveTypeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
