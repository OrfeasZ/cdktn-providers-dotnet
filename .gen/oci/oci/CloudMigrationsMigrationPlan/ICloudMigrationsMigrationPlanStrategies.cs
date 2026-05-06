using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsMigrationPlan
{
    [JsiiInterface(nativeType: typeof(ICloudMigrationsMigrationPlanStrategies), fullyQualifiedName: "oci.cloudMigrationsMigrationPlan.CloudMigrationsMigrationPlanStrategies")]
    public interface ICloudMigrationsMigrationPlanStrategies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#resource_type CloudMigrationsMigrationPlan#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#strategy_type CloudMigrationsMigrationPlan#strategy_type}.</summary>
        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        string StrategyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#adjustment_multiplier CloudMigrationsMigrationPlan#adjustment_multiplier}.</summary>
        [JsiiProperty(name: "adjustmentMultiplier", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AdjustmentMultiplier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#metric_time_window CloudMigrationsMigrationPlan#metric_time_window}.</summary>
        [JsiiProperty(name: "metricTimeWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricTimeWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#metric_type CloudMigrationsMigrationPlan#metric_type}.</summary>
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#percentile CloudMigrationsMigrationPlan#percentile}.</summary>
        [JsiiProperty(name: "percentile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Percentile
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudMigrationsMigrationPlanStrategies), fullyQualifiedName: "oci.cloudMigrationsMigrationPlan.CloudMigrationsMigrationPlanStrategies")]
        internal sealed class _Proxy : DeputyBase, oci.CloudMigrationsMigrationPlan.ICloudMigrationsMigrationPlanStrategies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#resource_type CloudMigrationsMigrationPlan#resource_type}.</summary>
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#strategy_type CloudMigrationsMigrationPlan#strategy_type}.</summary>
            [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
            public string StrategyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#adjustment_multiplier CloudMigrationsMigrationPlan#adjustment_multiplier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adjustmentMultiplier", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AdjustmentMultiplier
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#metric_time_window CloudMigrationsMigrationPlan#metric_time_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricTimeWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricTimeWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#metric_type CloudMigrationsMigrationPlan#metric_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_migration_plan#percentile CloudMigrationsMigrationPlan#percentile}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "percentile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Percentile
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
