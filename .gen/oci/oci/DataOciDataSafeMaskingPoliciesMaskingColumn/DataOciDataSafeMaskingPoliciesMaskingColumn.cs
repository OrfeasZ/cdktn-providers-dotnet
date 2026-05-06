using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeMaskingPoliciesMaskingColumn
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_column oci_data_safe_masking_policies_masking_column}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeMaskingPoliciesMaskingColumn.DataOciDataSafeMaskingPoliciesMaskingColumn), fullyQualifiedName: "oci.dataOciDataSafeMaskingPoliciesMaskingColumn.DataOciDataSafeMaskingPoliciesMaskingColumn", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeMaskingPoliciesMaskingColumn.DataOciDataSafeMaskingPoliciesMaskingColumnConfig\"}}]")]
    public class DataOciDataSafeMaskingPoliciesMaskingColumn : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_column oci_data_safe_masking_policies_masking_column} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeMaskingPoliciesMaskingColumn(Constructs.Construct scope, string id, oci.DataOciDataSafeMaskingPoliciesMaskingColumn.IDataOciDataSafeMaskingPoliciesMaskingColumnConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeMaskingPoliciesMaskingColumn.IDataOciDataSafeMaskingPoliciesMaskingColumnConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeMaskingPoliciesMaskingColumn(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeMaskingPoliciesMaskingColumn(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeMaskingPoliciesMaskingColumn resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeMaskingPoliciesMaskingColumn to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeMaskingPoliciesMaskingColumn that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeMaskingPoliciesMaskingColumn to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeMaskingPoliciesMaskingColumn to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_column#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeMaskingPoliciesMaskingColumn that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeMaskingPoliciesMaskingColumn to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeMaskingPoliciesMaskingColumn.DataOciDataSafeMaskingPoliciesMaskingColumn), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeMaskingPoliciesMaskingColumn.DataOciDataSafeMaskingPoliciesMaskingColumn))!;

        [JsiiProperty(name: "childColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ChildColumns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isMaskingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMaskingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingColumnGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingColumnGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingFormats", typeJson: "{\"fqn\":\"oci.dataOciDataSafeMaskingPoliciesMaskingColumn.DataOciDataSafeMaskingPoliciesMaskingColumnMaskingFormatsList\"}")]
        public virtual oci.DataOciDataSafeMaskingPoliciesMaskingColumn.DataOciDataSafeMaskingPoliciesMaskingColumnMaskingFormatsList MaskingFormats
        {
            get => GetInstanceProperty<oci.DataOciDataSafeMaskingPoliciesMaskingColumn.DataOciDataSafeMaskingPoliciesMaskingColumnMaskingFormatsList>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sensitiveTypeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveTypeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maskingColumnKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaskingColumnKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maskingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaskingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maskingColumnKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingColumnKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
