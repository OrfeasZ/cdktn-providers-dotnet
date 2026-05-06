using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsageCarbonEmissionsQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.meteringComputationUsageCarbonEmissionsQuery.MeteringComputationUsageCarbonEmissionsQueryQueryDefinition")]
    public class MeteringComputationUsageCarbonEmissionsQueryQueryDefinition : oci.MeteringComputationUsageCarbonEmissionsQuery.IMeteringComputationUsageCarbonEmissionsQueryQueryDefinition
    {
        /// <summary>cost_analysis_ui block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#cost_analysis_ui MeteringComputationUsageCarbonEmissionsQuery#cost_analysis_ui}
        /// </remarks>
        [JsiiProperty(name: "costAnalysisUi", typeJson: "{\"fqn\":\"oci.meteringComputationUsageCarbonEmissionsQuery.MeteringComputationUsageCarbonEmissionsQueryQueryDefinitionCostAnalysisUi\"}")]
        public oci.MeteringComputationUsageCarbonEmissionsQuery.IMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionCostAnalysisUi CostAnalysisUi
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#display_name MeteringComputationUsageCarbonEmissionsQuery#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>report_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#report_query MeteringComputationUsageCarbonEmissionsQuery#report_query}
        /// </remarks>
        [JsiiProperty(name: "reportQuery", typeJson: "{\"fqn\":\"oci.meteringComputationUsageCarbonEmissionsQuery.MeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQuery\"}")]
        public oci.MeteringComputationUsageCarbonEmissionsQuery.IMeteringComputationUsageCarbonEmissionsQueryQueryDefinitionReportQuery ReportQuery
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_carbon_emissions_query#version MeteringComputationUsageCarbonEmissionsQuery#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public double Version
        {
            get;
            set;
        }
    }
}
