using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinition")]
    public class MeteringComputationQueryQueryDefinition : oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinition
    {
        /// <summary>cost_analysis_ui block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#cost_analysis_ui MeteringComputationQuery#cost_analysis_ui}
        /// </remarks>
        [JsiiProperty(name: "costAnalysisUi", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUi\"}")]
        public oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionCostAnalysisUi CostAnalysisUi
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#display_name MeteringComputationQuery#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>report_query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#report_query MeteringComputationQuery#report_query}
        /// </remarks>
        [JsiiProperty(name: "reportQuery", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQuery\"}")]
        public oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQuery ReportQuery
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#version MeteringComputationQuery#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public double Version
        {
            get;
            set;
        }
    }
}
