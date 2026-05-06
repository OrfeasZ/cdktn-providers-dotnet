using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar")]
    public interface IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#key_size JmsFleetAdvancedFeatureConfiguration#key_size}.</summary>
        [JsiiProperty(name: "keySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeySize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#name JmsFleetAdvancedFeatureConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar")]
        internal sealed class _Proxy : DeputyBase, oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#key_size JmsFleetAdvancedFeatureConfiguration#key_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeySize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#name JmsFleetAdvancedFeatureConfiguration#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
