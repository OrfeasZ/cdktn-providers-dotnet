using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeReportDefinition
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_report_definition oci_data_safe_report_definition}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinition), fullyQualifiedName: "oci.dataOciDataSafeReportDefinition.DataOciDataSafeReportDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionConfig\"}}]")]
    public class DataOciDataSafeReportDefinition : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_report_definition oci_data_safe_report_definition} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeReportDefinition(Constructs.Construct scope, string id, oci.DataOciDataSafeReportDefinition.IDataOciDataSafeReportDefinitionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeReportDefinition.IDataOciDataSafeReportDefinitionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeReportDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeReportDefinition(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeReportDefinition resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeReportDefinition to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeReportDefinition that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeReportDefinition to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeReportDefinition to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_report_definition#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeReportDefinition that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeReportDefinition to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinition), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinition))!;

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columnFilters", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnFiltersList\"}")]
        public virtual oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnFiltersList ColumnFilters
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnFiltersList>()!;
        }

        [JsiiProperty(name: "columnInfo", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnInfoList\"}")]
        public virtual oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnInfoList ColumnInfo
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnInfoList>()!;
        }

        [JsiiProperty(name: "columnSortings", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnSortingsList\"}")]
        public virtual oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnSortingsList ColumnSortings
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionColumnSortingsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "complianceStandards", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ComplianceStandards
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayOrder", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DisplayOrder
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isSeeded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSeeded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordTimeSpan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordTimeSpan
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schedule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledReportCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledReportCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledReportMimeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledReportMimeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledReportName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledReportName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledReportRowLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScheduledReportRowLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scimFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScimFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"fqn\":\"oci.dataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionSummaryList\"}")]
        public virtual oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionSummaryList Summary
        {
            get => GetInstanceProperty<oci.DataOciDataSafeReportDefinition.DataOciDataSafeReportDefinitionSummaryList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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
        [JsiiProperty(name: "reportDefinitionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportDefinitionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "reportDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportDefinitionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
