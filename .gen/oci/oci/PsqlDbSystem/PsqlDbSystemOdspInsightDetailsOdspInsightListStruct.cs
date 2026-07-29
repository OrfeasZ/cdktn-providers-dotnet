using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStruct")]
    public class PsqlDbSystemOdspInsightDetailsOdspInsightListStruct : oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/psql_db_system#insight_type PsqlDbSystem#insight_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insightType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InsightType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/psql_db_system#retention_period_in_days PsqlDbSystem#retention_period_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionPeriodInDays
        {
            get;
            set;
        }
    }
}
