using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiByValue(fqn: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettings")]
    public class JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettings : oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettings
    {
        private object? _certpath;

        /// <summary>certpath block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#certpath JmsFleetAdvancedFeatureConfiguration#certpath}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certpath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Certpath
        {
            get => _certpath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _certpath = value;
            }
        }

        private object? _jar;

        /// <summary>jar block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#jar JmsFleetAdvancedFeatureConfiguration#jar}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jar", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Jar
        {
            get => _jar;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _jar = value;
            }
        }

        private object? _tls;

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#tls JmsFleetAdvancedFeatureConfiguration#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tls
        {
            get => _tls;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTls[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTls).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tls = value;
            }
        }
    }
}
