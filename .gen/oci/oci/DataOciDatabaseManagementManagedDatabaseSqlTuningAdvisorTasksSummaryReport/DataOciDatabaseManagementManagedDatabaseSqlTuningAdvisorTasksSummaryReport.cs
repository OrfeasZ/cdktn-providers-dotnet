using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_summary_report oci_database_management_managed_database_sql_tuning_advisor_tasks_summary_report}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportConfig\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_summary_report oci_database_management_managed_database_sql_tuning_advisor_tasks_summary_report} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_summary_report#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetBeginExecIdGreaterThanOrEqualTo")]
        public virtual void ResetBeginExecIdGreaterThanOrEqualTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndExecIdLessThanOrEqualTo")]
        public virtual void ResetEndExecIdLessThanOrEqualTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpcNamedCredentialId")]
        public virtual void ResetOpcNamedCredentialId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchPeriod")]
        public virtual void ResetSearchPeriod()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport))!;

        [JsiiProperty(name: "indexFindings", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportIndexFindingsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportIndexFindingsList IndexFindings
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportIndexFindingsList>()!;
        }

        [JsiiProperty(name: "objectStatFindings", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportObjectStatFindingsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportObjectStatFindingsList ObjectStatFindings
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportObjectStatFindingsList>()!;
        }

        [JsiiProperty(name: "statistics", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsList Statistics
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsList>()!;
        }

        [JsiiProperty(name: "taskInfo", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportTaskInfoList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportTaskInfoList TaskInfo
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportTaskInfoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "beginExecIdGreaterThanOrEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BeginExecIdGreaterThanOrEqualToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endExecIdLessThanOrEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndExecIdLessThanOrEqualToInput
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
        [JsiiProperty(name: "managedDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opcNamedCredentialIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OpcNamedCredentialIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchPeriodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchPeriodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlTuningAdvisorTaskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlTuningAdvisorTaskIdInput
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

        [JsiiProperty(name: "beginExecIdGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BeginExecIdGreaterThanOrEqualTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endExecIdLessThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndExecIdLessThanOrEqualTo
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

        [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "opcNamedCredentialId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcNamedCredentialId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchPeriod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlTuningAdvisorTaskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlTuningAdvisorTaskId
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
    }
}
