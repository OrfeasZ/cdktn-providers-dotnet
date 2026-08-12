using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudAutonomousVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetails), fullyQualifiedName: "oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetails")]
    public interface IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#custom_action_timeout_in_mins DatabaseCloudAutonomousVmCluster#custom_action_timeout_in_mins}.</summary>
        [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CustomActionTimeoutInMins
        {
            get
            {
                return null;
            }
        }

        /// <summary>days_of_week block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#days_of_week DatabaseCloudAutonomousVmCluster#days_of_week}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DaysOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#hours_of_day DatabaseCloudAutonomousVmCluster#hours_of_day}.</summary>
        [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? HoursOfDay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#is_custom_action_timeout_enabled DatabaseCloudAutonomousVmCluster#is_custom_action_timeout_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCustomActionTimeoutEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#is_monthly_patching_enabled DatabaseCloudAutonomousVmCluster#is_monthly_patching_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMonthlyPatchingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#lead_time_in_weeks DatabaseCloudAutonomousVmCluster#lead_time_in_weeks}.</summary>
        [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LeadTimeInWeeks
        {
            get
            {
                return null;
            }
        }

        /// <summary>months block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#months DatabaseCloudAutonomousVmCluster#months}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsMonths" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Months
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#patching_mode DatabaseCloudAutonomousVmCluster#patching_mode}.</summary>
        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatchingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#preference DatabaseCloudAutonomousVmCluster#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Preference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#skip_ru DatabaseCloudAutonomousVmCluster#skip_ru}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (either bool or <see cref="Io.Cdktn.IResolvable" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "skipRu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipRu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#weeks_of_month DatabaseCloudAutonomousVmCluster#weeks_of_month}.</summary>
        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? WeeksOfMonth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetails), fullyQualifiedName: "oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#custom_action_timeout_in_mins DatabaseCloudAutonomousVmCluster#custom_action_timeout_in_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CustomActionTimeoutInMins
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>days_of_week block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#days_of_week DatabaseCloudAutonomousVmCluster#days_of_week}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DaysOfWeek
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#hours_of_day DatabaseCloudAutonomousVmCluster#hours_of_day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? HoursOfDay
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#is_custom_action_timeout_enabled DatabaseCloudAutonomousVmCluster#is_custom_action_timeout_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCustomActionTimeoutEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#is_monthly_patching_enabled DatabaseCloudAutonomousVmCluster#is_monthly_patching_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMonthlyPatchingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#lead_time_in_weeks DatabaseCloudAutonomousVmCluster#lead_time_in_weeks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LeadTimeInWeeks
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>months block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#months DatabaseCloudAutonomousVmCluster#months}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsMonths" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetailsMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Months
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#patching_mode DatabaseCloudAutonomousVmCluster#patching_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatchingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#preference DatabaseCloudAutonomousVmCluster#preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Preference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#skip_ru DatabaseCloudAutonomousVmCluster#skip_ru}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (either bool or <see cref="Io.Cdktn.IResolvable" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipRu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SkipRu
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_cloud_autonomous_vm_cluster#weeks_of_month DatabaseCloudAutonomousVmCluster#weeks_of_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? WeeksOfMonth
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
