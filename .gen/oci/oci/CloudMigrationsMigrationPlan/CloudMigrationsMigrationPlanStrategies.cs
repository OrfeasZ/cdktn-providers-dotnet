using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsMigrationPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudMigrationsMigrationPlan.CloudMigrationsMigrationPlanStrategies")]
    public class CloudMigrationsMigrationPlanStrategies : oci.CloudMigrationsMigrationPlan.ICloudMigrationsMigrationPlanStrategies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#resource_type CloudMigrationsMigrationPlan#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#strategy_type CloudMigrationsMigrationPlan#strategy_type}.</summary>
        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        public string StrategyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#adjustment_multiplier CloudMigrationsMigrationPlan#adjustment_multiplier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adjustmentMultiplier", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdjustmentMultiplier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#metric_time_window CloudMigrationsMigrationPlan#metric_time_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricTimeWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricTimeWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#metric_type CloudMigrationsMigrationPlan#metric_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#percentile CloudMigrationsMigrationPlan#percentile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "percentile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Percentile
        {
            get;
            set;
        }
    }
}
