using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiNewsReport
{
    [JsiiByValue(fqn: "oci.opsiNewsReport.OpsiNewsReportContentTypes")]
    public class OpsiNewsReportContentTypes : oci.OpsiNewsReport.IOpsiNewsReportContentTypes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_news_report#actionable_insights_resources OpsiNewsReport#actionable_insights_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionableInsightsResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ActionableInsightsResources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_news_report#capacity_planning_resources OpsiNewsReport#capacity_planning_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityPlanningResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CapacityPlanningResources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_news_report#sql_insights_fleet_analysis_resources OpsiNewsReport#sql_insights_fleet_analysis_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlInsightsFleetAnalysisResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SqlInsightsFleetAnalysisResources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_news_report#sql_insights_performance_degradation_resources OpsiNewsReport#sql_insights_performance_degradation_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlInsightsPerformanceDegradationResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SqlInsightsPerformanceDegradationResources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_news_report#sql_insights_plan_changes_resources OpsiNewsReport#sql_insights_plan_changes_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlInsightsPlanChangesResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SqlInsightsPlanChangesResources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_news_report#sql_insights_top_databases_resources OpsiNewsReport#sql_insights_top_databases_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlInsightsTopDatabasesResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SqlInsightsTopDatabasesResources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_news_report#sql_insights_top_sql_by_insights_resources OpsiNewsReport#sql_insights_top_sql_by_insights_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlInsightsTopSqlByInsightsResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SqlInsightsTopSqlByInsightsResources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_news_report#sql_insights_top_sql_resources OpsiNewsReport#sql_insights_top_sql_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlInsightsTopSqlResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SqlInsightsTopSqlResources
        {
            get;
            set;
        }
    }
}
