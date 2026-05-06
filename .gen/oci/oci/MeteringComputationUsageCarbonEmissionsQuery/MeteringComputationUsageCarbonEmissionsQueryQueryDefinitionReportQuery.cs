using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsageCarbonEmissionsQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.meteringComputationUsageCarbonEmissionsQuery.MeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQuery")]
    public class MeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQuery : oci.MeteringComputationUsageCarbonEmissionsQuery.IMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#tenant_id MeteringComputationUsageCarbonEmissionsQuery#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#compartment_depth MeteringComputationUsageCarbonEmissionsQuery#compartment_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CompartmentDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#date_range_name MeteringComputationUsageCarbonEmissionsQuery#date_range_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dateRangeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DateRangeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#emission_calculation_method MeteringComputationUsageCarbonEmissionsQuery#emission_calculation_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emissionCalculationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmissionCalculationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#emission_type MeteringComputationUsageCarbonEmissionsQuery#emission_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emissionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmissionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#granularity MeteringComputationUsageCarbonEmissionsQuery#granularity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Granularity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#group_by MeteringComputationUsageCarbonEmissionsQuery#group_by}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GroupBy
        {
            get;
            set;
        }

        private object? _groupByTag;

        /// <summary>group_by_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#group_by_tag MeteringComputationUsageCarbonEmissionsQuery#group_by_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupByTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationUsageCarbonEmissionsQuery.MeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GroupByTag
        {
            get => _groupByTag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.MeteringComputationUsageCarbonEmissionsQuery.IMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryGroupByTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationUsageCarbonEmissionsQuery.IMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQueryGroupByTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _groupByTag = value;
            }
        }

        private object? _isAggregateByTime;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#is_aggregate_by_time MeteringComputationUsageCarbonEmissionsQuery#is_aggregate_by_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAggregateByTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAggregateByTime
        {
            get => _isAggregateByTime;
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
                _isAggregateByTime = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#time_usage_ended MeteringComputationUsageCarbonEmissionsQuery#time_usage_ended}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeUsageEnded
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#time_usage_started MeteringComputationUsageCarbonEmissionsQuery#time_usage_started}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeUsageStarted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#usage_carbon_emissions_query_filter MeteringComputationUsageCarbonEmissionsQuery#usage_carbon_emissions_query_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usageCarbonEmissionsQueryFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsageCarbonEmissionsQueryFilter
        {
            get;
            set;
        }
    }
}
