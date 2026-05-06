using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsConfig), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsConfig")]
    public interface IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#group_type DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#group_type}.</summary>
        [JsiiProperty(name: "groupType", typeJson: "{\"primitive\":\"string\"}")]
        string GroupType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#managed_database_id DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#managed_database_id}.</summary>
        [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#end_time_less_than_or_equal_to DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#end_time_less_than_or_equal_to}.</summary>
        [JsiiProperty(name: "endTimeLessThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndTimeLessThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#filter DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#id DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#limit DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#start_time_greater_than_or_equal_to DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#start_time_greater_than_or_equal_to}.</summary>
        [JsiiProperty(name: "startTimeGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartTimeGreaterThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#task_type DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#task_type}.</summary>
        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaskType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsConfig), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#group_type DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#group_type}.</summary>
            [JsiiProperty(name: "groupType", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#managed_database_id DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#managed_database_id}.</summary>
            [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#end_time_less_than_or_equal_to DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#end_time_less_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endTimeLessThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndTimeLessThanOrEqualTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#filter DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregationsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#id DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#limit DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#start_time_greater_than_or_equal_to DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#start_time_greater_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startTimeGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartTimeGreaterThanOrEqualTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_aggregations#task_type DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionAggregations#task_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaskType
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
