using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig")]
    public interface IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#execution_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#execution_id}.</summary>
        [JsiiProperty(name: "executionId", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#managed_database_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#managed_database_id}.</summary>
        [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#sql_object_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#sql_object_id}.</summary>
        [JsiiProperty(name: "sqlObjectId", typeJson: "{\"primitive\":\"string\"}")]
        string SqlObjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#sql_tuning_advisor_task_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#sql_tuning_advisor_task_id}.</summary>
        [JsiiProperty(name: "sqlTuningAdvisorTaskId", typeJson: "{\"primitive\":\"string\"}")]
        string SqlTuningAdvisorTaskId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#opc_named_credential_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#opc_named_credential_id}.</summary>
        [JsiiProperty(name: "opcNamedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpcNamedCredentialId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparisionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#execution_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#execution_id}.</summary>
            [JsiiProperty(name: "executionId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#managed_database_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#managed_database_id}.</summary>
            [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#sql_object_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#sql_object_id}.</summary>
            [JsiiProperty(name: "sqlObjectId", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#sql_tuning_advisor_task_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#sql_tuning_advisor_task_id}.</summary>
            [JsiiProperty(name: "sqlTuningAdvisorTaskId", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlTuningAdvisorTaskId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_sql_tuning_advisor_tasks_execution_plan_stats_comparision#opc_named_credential_id DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksExecutionPlanStatsComparision#opc_named_credential_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opcNamedCredentialId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpcNamedCredentialId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
