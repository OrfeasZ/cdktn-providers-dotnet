using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeDiscoveryJobsResult
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_discovery_jobs_result oci_data_safe_discovery_jobs_result}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResult), fullyQualifiedName: "oci.dataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResult", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResultConfig\"}}]")]
    public class DataOciDataSafeDiscoveryJobsResult : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_discovery_jobs_result oci_data_safe_discovery_jobs_result} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeDiscoveryJobsResult(Constructs.Construct scope, string id, oci.DataOciDataSafeDiscoveryJobsResult.IDataOciDataSafeDiscoveryJobsResultConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeDiscoveryJobsResult.IDataOciDataSafeDiscoveryJobsResultConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeDiscoveryJobsResult(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeDiscoveryJobsResult(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeDiscoveryJobsResult resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeDiscoveryJobsResult to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeDiscoveryJobsResult that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeDiscoveryJobsResult to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeDiscoveryJobsResult to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_discovery_jobs_result#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeDiscoveryJobsResult that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeDiscoveryJobsResult to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResult), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResult))!;

        [JsiiProperty(name: "appDefinedChildColumnKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AppDefinedChildColumnKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confidenceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfidenceLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confidenceLevelDetails", typeJson: "{\"fqn\":\"oci.dataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResultConfidenceLevelDetailsList\"}")]
        public virtual oci.DataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResultConfidenceLevelDetailsList ConfidenceLevelDetails
        {
            get => GetInstanceProperty<oci.DataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResultConfidenceLevelDetailsList>()!;
        }

        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbDefinedChildColumnKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbDefinedChildColumnKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "discoveryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedDataValueCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EstimatedDataValueCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isResultApplied", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsResultApplied
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedAttributes", typeJson: "{\"fqn\":\"oci.dataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResultModifiedAttributesList\"}")]
        public virtual oci.DataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResultModifiedAttributesList ModifiedAttributes
        {
            get => GetInstanceProperty<oci.DataOciDataSafeDiscoveryJobsResult.DataOciDataSafeDiscoveryJobsResultModifiedAttributesList>()!;
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

        [JsiiProperty(name: "parentColumnKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ParentColumnKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "plannedAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlannedAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sampleDataValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SampleDataValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sensitiveColumnkey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveColumnkey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sensitiveTypeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveTypeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "discoveryJobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiscoveryJobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resultKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResultKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "discoveryJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryJobId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resultKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResultKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
