using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStruct")]
    public interface IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/psql_db_system#insight_type PsqlDbSystem#insight_type}.</summary>
        [JsiiProperty(name: "insightType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InsightType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/psql_db_system#retention_period_in_days PsqlDbSystem#retention_period_in_days}.</summary>
        [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriodInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/psql_db_system#insight_type PsqlDbSystem#insight_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "insightType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InsightType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/psql_db_system#retention_period_in_days PsqlDbSystem#retention_period_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriodInDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
