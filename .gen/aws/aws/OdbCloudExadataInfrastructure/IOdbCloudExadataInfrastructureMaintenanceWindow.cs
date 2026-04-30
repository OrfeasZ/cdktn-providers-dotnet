using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IOdbCloudExadataInfrastructureMaintenanceWindow), fullyQualifiedName: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindow")]
    public interface IOdbCloudExadataInfrastructureMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#custom_action_timeout_in_mins OdbCloudExadataInfrastructure#custom_action_timeout_in_mins}.</summary>
        [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        double CustomActionTimeoutInMins
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#is_custom_action_timeout_enabled OdbCloudExadataInfrastructure#is_custom_action_timeout_enabled}.</summary>
        [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsCustomActionTimeoutEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#patching_mode OdbCloudExadataInfrastructure#patching_mode}.</summary>
        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}")]
        string PatchingMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#preference OdbCloudExadataInfrastructure#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}")]
        string Preference
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#days_of_week OdbCloudExadataInfrastructure#days_of_week}.</summary>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindowDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DaysOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#hours_of_day OdbCloudExadataInfrastructure#hours_of_day}.</summary>
        [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? HoursOfDay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#lead_time_in_weeks OdbCloudExadataInfrastructure#lead_time_in_weeks}.</summary>
        [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LeadTimeInWeeks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#months OdbCloudExadataInfrastructure#months}.</summary>
        [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindowMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Months
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#weeks_of_month OdbCloudExadataInfrastructure#weeks_of_month}.</summary>
        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? WeeksOfMonth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbCloudExadataInfrastructureMaintenanceWindow), fullyQualifiedName: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#custom_action_timeout_in_mins OdbCloudExadataInfrastructure#custom_action_timeout_in_mins}.</summary>
            [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
            public double CustomActionTimeoutInMins
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#is_custom_action_timeout_enabled OdbCloudExadataInfrastructure#is_custom_action_timeout_enabled}.</summary>
            [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsCustomActionTimeoutEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#patching_mode OdbCloudExadataInfrastructure#patching_mode}.</summary>
            [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}")]
            public string PatchingMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#preference OdbCloudExadataInfrastructure#preference}.</summary>
            [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}")]
            public string Preference
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#days_of_week OdbCloudExadataInfrastructure#days_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindowDaysOfWeek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DaysOfWeek
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#hours_of_day OdbCloudExadataInfrastructure#hours_of_day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? HoursOfDay
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#lead_time_in_weeks OdbCloudExadataInfrastructure#lead_time_in_weeks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LeadTimeInWeeks
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#months OdbCloudExadataInfrastructure#months}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "months", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindowMonths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Months
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#weeks_of_month OdbCloudExadataInfrastructure#weeks_of_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? WeeksOfMonth
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
