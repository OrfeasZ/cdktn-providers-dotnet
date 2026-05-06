using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsNamespacePropertiesMetadata
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_namespace_properties_metadata oci_log_analytics_namespace_properties_metadata}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadata), fullyQualifiedName: "oci.dataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadata", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataConfig\"}}]")]
    public class DataOciLogAnalyticsNamespacePropertiesMetadata : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_namespace_properties_metadata oci_log_analytics_namespace_properties_metadata} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciLogAnalyticsNamespacePropertiesMetadata(Constructs.Construct scope, string id, oci.DataOciLogAnalyticsNamespacePropertiesMetadata.IDataOciLogAnalyticsNamespacePropertiesMetadataConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciLogAnalyticsNamespacePropertiesMetadata.IDataOciLogAnalyticsNamespacePropertiesMetadataConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsNamespacePropertiesMetadata(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsNamespacePropertiesMetadata(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciLogAnalyticsNamespacePropertiesMetadata resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciLogAnalyticsNamespacePropertiesMetadata to import.</param>
        /// <param name="importFromId">The id of the existing DataOciLogAnalyticsNamespacePropertiesMetadata that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciLogAnalyticsNamespacePropertiesMetadata to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciLogAnalyticsNamespacePropertiesMetadata to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/log_analytics_namespace_properties_metadata#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciLogAnalyticsNamespacePropertiesMetadata that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciLogAnalyticsNamespacePropertiesMetadata to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadata), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciLogAnalyticsNamespacePropertiesMetadata.IDataOciLogAnalyticsNamespacePropertiesMetadataFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciLogAnalyticsNamespacePropertiesMetadata.IDataOciLogAnalyticsNamespacePropertiesMetadataFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciLogAnalyticsNamespacePropertiesMetadata.IDataOciLogAnalyticsNamespacePropertiesMetadataFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConstraints")]
        public virtual void ResetConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayText")]
        public virtual void ResetDisplayText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetLevel")]
        public virtual void ResetLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(oci.DataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadata))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataFilterList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataFilterList>()!;
        }

        [JsiiProperty(name: "propertyMetadataSummaryCollection", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataPropertyMetadataSummaryCollectionList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataPropertyMetadataSummaryCollectionList PropertyMetadataSummaryCollection
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataPropertyMetadataSummaryCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "constraintsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConstraintsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciLogAnalyticsNamespacePropertiesMetadata.DataOciLogAnalyticsNamespacePropertiesMetadataFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "levelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "constraints", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Constraints
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayText
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

        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Level
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

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
