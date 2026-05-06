using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationConfig), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationConfig")]
    public interface IJmsFleetAdvancedFeatureConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#fleet_id JmsFleetAdvancedFeatureConfiguration#fleet_id}.</summary>
        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        string FleetId
        {
            get;
        }

        /// <summary>advanced_usage_tracking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#advanced_usage_tracking JmsFleetAdvancedFeatureConfiguration#advanced_usage_tracking}
        /// </remarks>
        [JsiiProperty(name: "advancedUsageTracking", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking? AdvancedUsageTracking
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#analytic_bucket_name JmsFleetAdvancedFeatureConfiguration#analytic_bucket_name}.</summary>
        [JsiiProperty(name: "analyticBucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AnalyticBucketName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#analytic_namespace JmsFleetAdvancedFeatureConfiguration#analytic_namespace}.</summary>
        [JsiiProperty(name: "analyticNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AnalyticNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>crypto_event_analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#crypto_event_analysis JmsFleetAdvancedFeatureConfiguration#crypto_event_analysis}
        /// </remarks>
        [JsiiProperty(name: "cryptoEventAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis? CryptoEventAnalysis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#id JmsFleetAdvancedFeatureConfiguration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>java_migration_analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#java_migration_analysis JmsFleetAdvancedFeatureConfiguration#java_migration_analysis}
        /// </remarks>
        [JsiiProperty(name: "javaMigrationAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis? JavaMigrationAnalysis
        {
            get
            {
                return null;
            }
        }

        /// <summary>jfr_recording block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#jfr_recording JmsFleetAdvancedFeatureConfiguration#jfr_recording}
        /// </remarks>
        [JsiiProperty(name: "jfrRecording", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJfrRecording\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJfrRecording? JfrRecording
        {
            get
            {
                return null;
            }
        }

        /// <summary>lcm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#lcm JmsFleetAdvancedFeatureConfiguration#lcm}
        /// </remarks>
        [JsiiProperty(name: "lcm", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcm? Lcm
        {
            get
            {
                return null;
            }
        }

        /// <summary>performance_tuning_analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#performance_tuning_analysis JmsFleetAdvancedFeatureConfiguration#performance_tuning_analysis}
        /// </remarks>
        [JsiiProperty(name: "performanceTuningAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis? PerformanceTuningAnalysis
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#timeouts JmsFleetAdvancedFeatureConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationConfig), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#fleet_id JmsFleetAdvancedFeatureConfiguration#fleet_id}.</summary>
            [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
            public string FleetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>advanced_usage_tracking block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#advanced_usage_tracking JmsFleetAdvancedFeatureConfiguration#advanced_usage_tracking}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "advancedUsageTracking", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking\"}", isOptional: true)]
            public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking? AdvancedUsageTracking
            {
                get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#analytic_bucket_name JmsFleetAdvancedFeatureConfiguration#analytic_bucket_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "analyticBucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AnalyticBucketName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#analytic_namespace JmsFleetAdvancedFeatureConfiguration#analytic_namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "analyticNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AnalyticNamespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>crypto_event_analysis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#crypto_event_analysis JmsFleetAdvancedFeatureConfiguration#crypto_event_analysis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cryptoEventAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis\"}", isOptional: true)]
            public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis? CryptoEventAnalysis
            {
                get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#id JmsFleetAdvancedFeatureConfiguration#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>java_migration_analysis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#java_migration_analysis JmsFleetAdvancedFeatureConfiguration#java_migration_analysis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "javaMigrationAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis\"}", isOptional: true)]
            public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis? JavaMigrationAnalysis
            {
                get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis?>();
            }

            /// <summary>jfr_recording block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#jfr_recording JmsFleetAdvancedFeatureConfiguration#jfr_recording}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jfrRecording", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJfrRecording\"}", isOptional: true)]
            public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJfrRecording? JfrRecording
            {
                get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJfrRecording?>();
            }

            /// <summary>lcm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#lcm JmsFleetAdvancedFeatureConfiguration#lcm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lcm", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcm\"}", isOptional: true)]
            public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcm? Lcm
            {
                get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcm?>();
            }

            /// <summary>performance_tuning_analysis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#performance_tuning_analysis JmsFleetAdvancedFeatureConfiguration#performance_tuning_analysis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "performanceTuningAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis\"}", isOptional: true)]
            public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis? PerformanceTuningAnalysis
            {
                get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#timeouts JmsFleetAdvancedFeatureConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationTimeouts\"}", isOptional: true)]
            public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
