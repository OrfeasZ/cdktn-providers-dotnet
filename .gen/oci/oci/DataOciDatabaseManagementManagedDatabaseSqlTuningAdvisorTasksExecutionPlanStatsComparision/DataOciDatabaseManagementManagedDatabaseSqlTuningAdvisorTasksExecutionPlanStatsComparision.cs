using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision oci_database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision oci_database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision))!;

        [JsiiProperty(name: "modified", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionModifiedList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionModifiedList Modified
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionModifiedList>()!;
        }

        [JsiiProperty(name: "original", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionOriginalList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionOriginalList Original
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionOriginalList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionIdInput
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
        [JsiiProperty(name: "sqlObjectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlObjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlTuningAdvisorTaskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlTuningAdvisorTaskIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "executionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionId
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

        [JsiiProperty(name: "sqlObjectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlObjectId
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
    }
}
