using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudExadataInfrastructureMaintenanceWindow), fullyQualifiedName: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceWindow")]
    public interface IDatabaseCloudExadataInfrastructureMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#custom_action_timeout_in_mins DatabaseCloudExadataInfrastructure#custom_action_timeout_in_mins}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#days_of_week DatabaseCloudExadataInfrastructure#days_of_week}
        /// </remarks>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceWindowDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DaysOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#hours_of_day DatabaseCloudExadataInfrastructure#hours_of_day}.</summary>
        [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? HoursOfDay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#is_custom_action_timeout_enabled DatabaseCloudExadataInfrastructure#is_custom_action_timeout_enabled}.</summary>
        [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCustomActionTimeoutEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#is_monthly_patching_enabled DatabaseCloudExadataInfrastructure#is_monthly_patching_enabled}.</summary>
        [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMonthlyPatchingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#lead_time_in_weeks DatabaseCloudExadataInfrastructure#lead_time_in_weeks}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#months DatabaseCloudExadataInfrastructure#months}
        /// </remarks>
        [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceWindowMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Months
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#patching_mode DatabaseCloudExadataInfrastructure#patching_mode}.</summary>
        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatchingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#preference DatabaseCloudExadataInfrastructure#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Preference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#skip_ru DatabaseCloudExadataInfrastructure#skip_ru}.</summary>
        [JsiiProperty(name: "skipRu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipRu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#weeks_of_month DatabaseCloudExadataInfrastructure#weeks_of_month}.</summary>
        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? WeeksOfMonth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudExadataInfrastructureMaintenanceWindow), fullyQualifiedName: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudExadataInfrastructure.IDatabaseCloudExadataInfrastructureMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#custom_action_timeout_in_mins DatabaseCloudExadataInfrastructure#custom_action_timeout_in_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CustomActionTimeoutInMins
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>days_of_week block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#days_of_week DatabaseCloudExadataInfrastructure#days_of_week}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceWindowDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DaysOfWeek
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#hours_of_day DatabaseCloudExadataInfrastructure#hours_of_day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? HoursOfDay
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#is_custom_action_timeout_enabled DatabaseCloudExadataInfrastructure#is_custom_action_timeout_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCustomActionTimeoutEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#is_monthly_patching_enabled DatabaseCloudExadataInfrastructure#is_monthly_patching_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMonthlyPatchingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#lead_time_in_weeks DatabaseCloudExadataInfrastructure#lead_time_in_weeks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LeadTimeInWeeks
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>months block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#months DatabaseCloudExadataInfrastructure#months}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceWindowMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Months
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#patching_mode DatabaseCloudExadataInfrastructure#patching_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatchingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#preference DatabaseCloudExadataInfrastructure#preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Preference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#skip_ru DatabaseCloudExadataInfrastructure#skip_ru}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipRu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SkipRu
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#weeks_of_month DatabaseCloudExadataInfrastructure#weeks_of_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? WeeksOfMonth
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
