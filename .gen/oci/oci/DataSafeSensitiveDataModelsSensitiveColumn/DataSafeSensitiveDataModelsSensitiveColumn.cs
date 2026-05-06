using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModelsSensitiveColumn
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column oci_data_safe_sensitive_data_models_sensitive_column}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumn), fullyQualifiedName: "oci.dataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumn", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnConfig\"}}]")]
    public class DataSafeSensitiveDataModelsSensitiveColumn : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column oci_data_safe_sensitive_data_models_sensitive_column} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeSensitiveDataModelsSensitiveColumn(Constructs.Construct scope, string id, oci.DataSafeSensitiveDataModelsSensitiveColumn.IDataSafeSensitiveDataModelsSensitiveColumnConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeSensitiveDataModelsSensitiveColumn.IDataSafeSensitiveDataModelsSensitiveColumnConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSensitiveDataModelsSensitiveColumn(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSensitiveDataModelsSensitiveColumn(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeSensitiveDataModelsSensitiveColumn resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeSensitiveDataModelsSensitiveColumn to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeSensitiveDataModelsSensitiveColumn that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeSensitiveDataModelsSensitiveColumn to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeSensitiveDataModelsSensitiveColumn to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeSensitiveDataModelsSensitiveColumn that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeSensitiveDataModelsSensitiveColumn to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumn), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeSensitiveDataModelsSensitiveColumn.IDataSafeSensitiveDataModelsSensitiveColumnTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSensitiveDataModelsSensitiveColumn.IDataSafeSensitiveDataModelsSensitiveColumnTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAppDefinedChildColumnKeys")]
        public virtual void ResetAppDefinedChildColumnKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppName")]
        public virtual void ResetAppName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataType")]
        public virtual void ResetDataType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbDefinedChildColumnKeys")]
        public virtual void ResetDbDefinedChildColumnKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectType")]
        public virtual void ResetObjectType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentColumnKeys")]
        public virtual void ResetParentColumnKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelationType")]
        public virtual void ResetRelationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSensitiveTypeId")]
        public virtual void ResetSensitiveTypeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumn))!;

        [JsiiProperty(name: "columnGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ColumnGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "confidenceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfidenceLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confidenceLevelDetails", typeJson: "{\"fqn\":\"oci.dataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnConfidenceLevelDetailsList\"}")]
        public virtual oci.DataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnConfidenceLevelDetailsList ConfidenceLevelDetails
        {
            get => GetInstanceProperty<oci.DataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnConfidenceLevelDetailsList>()!;
        }

        [JsiiProperty(name: "estimatedDataValueCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EstimatedDataValueCount
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "sampleDataValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SampleDataValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appDefinedChildColumnKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AppDefinedChildColumnKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ColumnNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbDefinedChildColumnKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DbDefinedChildColumnKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentColumnKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ParentColumnKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RelationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sensitiveDataModelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SensitiveDataModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sensitiveTypeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SensitiveTypeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "appDefinedChildColumnKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AppDefinedChildColumnKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbDefinedChildColumnKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbDefinedChildColumnKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parentColumnKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ParentColumnKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "relationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sensitiveDataModelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveDataModelId
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

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
