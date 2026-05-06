using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbSystem
{
    [JsiiInterface(nativeType: typeof(IDatabaseDbSystemMaintenanceWindowDetails), fullyQualifiedName: "oci.databaseDbSystem.DatabaseDbSystemMaintenanceWindowDetails")]
    public interface IDatabaseDbSystemMaintenanceWindowDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#custom_action_timeout_in_mins DatabaseDbSystem#custom_action_timeout_in_mins}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#days_of_week DatabaseDbSystem#days_of_week}
        /// </remarks>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDbSystem.DatabaseDbSystemMaintenanceWindowDetailsDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DaysOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#hours_of_day DatabaseDbSystem#hours_of_day}.</summary>
        [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? HoursOfDay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#is_custom_action_timeout_enabled DatabaseDbSystem#is_custom_action_timeout_enabled}.</summary>
        [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCustomActionTimeoutEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#is_monthly_patching_enabled DatabaseDbSystem#is_monthly_patching_enabled}.</summary>
        [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMonthlyPatchingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#lead_time_in_weeks DatabaseDbSystem#lead_time_in_weeks}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#months DatabaseDbSystem#months}
        /// </remarks>
        [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDbSystem.DatabaseDbSystemMaintenanceWindowDetailsMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Months
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#patching_mode DatabaseDbSystem#patching_mode}.</summary>
        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatchingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#preference DatabaseDbSystem#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Preference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#skip_ru DatabaseDbSystem#skip_ru}.</summary>
        [JsiiProperty(name: "skipRu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipRu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#weeks_of_month DatabaseDbSystem#weeks_of_month}.</summary>
        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? WeeksOfMonth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDbSystemMaintenanceWindowDetails), fullyQualifiedName: "oci.databaseDbSystem.DatabaseDbSystemMaintenanceWindowDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDbSystem.IDatabaseDbSystemMaintenanceWindowDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#custom_action_timeout_in_mins DatabaseDbSystem#custom_action_timeout_in_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CustomActionTimeoutInMins
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>days_of_week block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#days_of_week DatabaseDbSystem#days_of_week}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDbSystem.DatabaseDbSystemMaintenanceWindowDetailsDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DaysOfWeek
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#hours_of_day DatabaseDbSystem#hours_of_day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? HoursOfDay
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#is_custom_action_timeout_enabled DatabaseDbSystem#is_custom_action_timeout_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCustomActionTimeoutEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#is_monthly_patching_enabled DatabaseDbSystem#is_monthly_patching_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMonthlyPatchingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#lead_time_in_weeks DatabaseDbSystem#lead_time_in_weeks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LeadTimeInWeeks
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>months block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#months DatabaseDbSystem#months}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseDbSystem.DatabaseDbSystemMaintenanceWindowDetailsMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Months
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#patching_mode DatabaseDbSystem#patching_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatchingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#preference DatabaseDbSystem#preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Preference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#skip_ru DatabaseDbSystem#skip_ru}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipRu", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SkipRu
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#weeks_of_month DatabaseDbSystem#weeks_of_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? WeeksOfMonth
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
