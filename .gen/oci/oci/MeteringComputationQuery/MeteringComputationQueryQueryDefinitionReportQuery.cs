using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQuery")]
    public class MeteringComputationQueryQueryDefinitionReportQuery : oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#granularity MeteringComputationQuery#granularity}.</summary>
        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        public string Granularity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#tenant_id MeteringComputationQuery#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#compartment_depth MeteringComputationQuery#compartment_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CompartmentDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#date_range_name MeteringComputationQuery#date_range_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dateRangeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DateRangeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#filter MeteringComputationQuery#filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Filter
        {
            get;
            set;
        }

        /// <summary>forecast block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#forecast MeteringComputationQuery#forecast}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forecast", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecast\"}", isOptional: true)]
        public oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryForecast? Forecast
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#group_by MeteringComputationQuery#group_by}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#group_by_tag MeteringComputationQuery#group_by_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupByTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryGroupByTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryGroupByTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _groupByTag = value;
            }
        }

        private object? _isAggregateByTime;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#is_aggregate_by_time MeteringComputationQuery#is_aggregate_by_time}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#query_type MeteringComputationQuery#query_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_usage_ended MeteringComputationQuery#time_usage_ended}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeUsageEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeUsageEnded
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_usage_started MeteringComputationQuery#time_usage_started}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeUsageStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeUsageStarted
        {
            get;
            set;
        }
    }
}
