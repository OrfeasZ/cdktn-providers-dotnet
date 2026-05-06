using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisSummarizedEventsLog), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisSummarizedEventsLog")]
    public interface IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisSummarizedEventsLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#log_group_id JmsFleetAdvancedFeatureConfiguration#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#log_id JmsFleetAdvancedFeatureConfiguration#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        string LogId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisSummarizedEventsLog), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisSummarizedEventsLog")]
        internal sealed class _Proxy : DeputyBase, oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisSummarizedEventsLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#log_group_id JmsFleetAdvancedFeatureConfiguration#log_group_id}.</summary>
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#log_id JmsFleetAdvancedFeatureConfiguration#log_id}.</summary>
            [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
