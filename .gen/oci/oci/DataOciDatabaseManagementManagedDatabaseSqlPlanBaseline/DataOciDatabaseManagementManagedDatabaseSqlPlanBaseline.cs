using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_plan_baseline oci_database_management_managed_database_sql_plan_baseline}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlPlanBaseline.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlPlanBaseline.DataOciDatabaseManagementManagedDatabaseSqlPlanBaselineConfig\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_plan_baseline oci_database_management_managed_database_sql_plan_baseline} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline.IDataOciDatabaseManagementManagedDatabaseSqlPlanBaselineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline.IDataOciDatabaseManagementManagedDatabaseSqlPlanBaselineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_plan_baseline#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline.DataOciDatabaseManagementManagedDatabaseSqlPlanBaseline))!;

        [JsiiProperty(name: "accepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Accepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adaptive", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Adaptive
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoPurge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoPurge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Enabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executionPlan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionPlan
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fixed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fixed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "module", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Module
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Origin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reproduced", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reproduced
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlHandle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlHandle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastExecuted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastExecuted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastModified
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "planNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanNameInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "planName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
