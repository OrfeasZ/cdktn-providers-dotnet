using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_attention_log_counts oci_database_management_managed_database_attention_log_counts}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsConfig\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseAttentionLogCounts : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_attention_log_counts oci_database_management_managed_database_attention_log_counts} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedDatabaseAttentionLogCounts(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.IDataOciDatabaseManagementManagedDatabaseAttentionLogCountsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.IDataOciDatabaseManagementManagedDatabaseAttentionLogCountsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseAttentionLogCounts(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseAttentionLogCounts(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedDatabaseAttentionLogCounts resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseAttentionLogCounts to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedDatabaseAttentionLogCounts that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseAttentionLogCounts to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseAttentionLogCounts to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_attention_log_counts#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedDatabaseAttentionLogCounts that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseAttentionLogCounts to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.IDataOciDatabaseManagementManagedDatabaseAttentionLogCountsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.IDataOciDatabaseManagementManagedDatabaseAttentionLogCountsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.IDataOciDatabaseManagementManagedDatabaseAttentionLogCountsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupBy")]
        public virtual void ResetGroupBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsRegularExpression")]
        public virtual void ResetIsRegularExpression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogSearchText")]
        public virtual void ResetLogSearchText()
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

        [JsiiMethod(name: "resetTypeFilter")]
        public virtual void ResetTypeFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrgencyFilter")]
        public virtual void ResetUrgencyFilter()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts))!;

        [JsiiProperty(name: "attentionLogCountsCollection", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsAttentionLogCountsCollectionList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsAttentionLogCountsCollectionList AttentionLogCountsCollection
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsAttentionLogCountsCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsFilterList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseAttentionLogCounts.DataOciDatabaseManagementManagedDatabaseAttentionLogCountsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupByInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupByInput
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
        [JsiiProperty(name: "isRegularExpressionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsRegularExpressionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logSearchTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogSearchTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedDatabaseIdInput
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

        [JsiiOptional]
        [JsiiProperty(name: "typeFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urgencyFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrgencyFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "groupBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupBy
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

        [JsiiProperty(name: "isRegularExpression", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsRegularExpression
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "logSearchText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogSearchText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedDatabaseId
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

        [JsiiProperty(name: "typeFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "urgencyFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UrgencyFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
