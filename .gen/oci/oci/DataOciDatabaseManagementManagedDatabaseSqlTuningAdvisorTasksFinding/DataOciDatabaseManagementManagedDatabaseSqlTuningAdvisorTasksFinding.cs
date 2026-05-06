using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_finding oci_database_management_managed_database_sql_tuning_advisor_tasks_finding}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFindingConfig\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_finding oci_database_management_managed_database_sql_tuning_advisor_tasks_finding} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFindingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFindingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_finding#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetBeginExecId")]
        public virtual void ResetBeginExecId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndExecId")]
        public virtual void ResetEndExecId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingFilter")]
        public virtual void ResetFindingFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexHashFilter")]
        public virtual void ResetIndexHashFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchPeriod")]
        public virtual void ResetSearchPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatsHashFilter")]
        public virtual void ResetStatsHashFilter()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFindingItemsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFindingItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFinding.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksFindingItemsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "beginExecIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BeginExecIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endExecIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndExecIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FindingFilterInput
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
        [JsiiProperty(name: "indexHashFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndexHashFilterInput
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
        [JsiiProperty(name: "statsHashFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatsHashFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "beginExecId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BeginExecId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endExecId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndExecId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "findingFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FindingFilter
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

        [JsiiProperty(name: "indexHashFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexHashFilter
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

        [JsiiProperty(name: "statsHashFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatsHashFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
