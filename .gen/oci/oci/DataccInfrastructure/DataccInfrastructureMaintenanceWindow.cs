using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccInfrastructure
{
    [JsiiByValue(fqn: "oci.dataccInfrastructure.DataccInfrastructureMaintenanceWindow")]
    public class DataccInfrastructureMaintenanceWindow : oci.DataccInfrastructure.IDataccInfrastructureMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#custom_action_timeout_in_mins DataccInfrastructure#custom_action_timeout_in_mins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CustomActionTimeoutInMins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#days_of_week DataccInfrastructure#days_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DaysOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#hours_of_day DataccInfrastructure#hours_of_day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? HoursOfDay
        {
            get;
            set;
        }

        private object? _isCustomActionTimeoutEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#is_custom_action_timeout_enabled DataccInfrastructure#is_custom_action_timeout_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCustomActionTimeoutEnabled
        {
            get => _isCustomActionTimeoutEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isCustomActionTimeoutEnabled = value;
            }
        }

        private object? _isMonthlyPatchingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#is_monthly_patching_enabled DataccInfrastructure#is_monthly_patching_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMonthlyPatchingEnabled
        {
            get => _isMonthlyPatchingEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isMonthlyPatchingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#lead_time_in_weeks DataccInfrastructure#lead_time_in_weeks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LeadTimeInWeeks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#months DataccInfrastructure#months}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "months", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Months
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#patching_mode DataccInfrastructure#patching_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PatchingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#preference DataccInfrastructure#preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Preference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#weeks_of_month DataccInfrastructure#weeks_of_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? WeeksOfMonth
        {
            get;
            set;
        }
    }
}
