using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns oci_data_safe_sdm_masking_policy_difference_difference_columns}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns), fullyQualifiedName: "oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig\"}}]")]
    public class DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns oci_data_safe_sdm_masking_policy_difference_difference_columns} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns(Constructs.Construct scope, string id, oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetColumnName")]
        public virtual void ResetColumnName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDifferenceType")]
        public virtual void ResetDifferenceType()
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

        [JsiiMethod(name: "resetObject")]
        public virtual void ResetObject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlannedAction")]
        public virtual void ResetPlannedAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaName")]
        public virtual void ResetSchemaName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSyncStatus")]
        public virtual void ResetSyncStatus()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilterList\"}")]
        public virtual oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilterList>()!;
        }

        [JsiiProperty(name: "sdmMaskingPolicyDifferenceColumnCollection", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsSdmMaskingPolicyDifferenceColumnCollectionList\"}")]
        public virtual oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsSdmMaskingPolicyDifferenceColumnCollectionList SdmMaskingPolicyDifferenceColumnCollection
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsSdmMaskingPolicyDifferenceColumnCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnNameInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ColumnNameInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "differenceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DifferenceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "objectInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ObjectInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "plannedActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlannedActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaNameInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SchemaNameInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sdmMaskingPolicyDifferenceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SdmMaskingPolicyDifferenceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "syncStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SyncStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ColumnName
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "differenceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DifferenceType
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

        [JsiiProperty(name: "object", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Object
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "plannedAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlannedAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SchemaName
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sdmMaskingPolicyDifferenceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SdmMaskingPolicyDifferenceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "syncStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
