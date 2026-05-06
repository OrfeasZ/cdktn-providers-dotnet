using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiByValue(fqn: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActions")]
    public class JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActions : oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActions
    {
        private object? _addLoggingHandler;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#add_logging_handler JmsFleetAdvancedFeatureConfiguration#add_logging_handler}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addLoggingHandler", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AddLoggingHandler
        {
            get => _addLoggingHandler;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _addLoggingHandler = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#disabled_tls_versions JmsFleetAdvancedFeatureConfiguration#disabled_tls_versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disabledTlsVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DisabledTlsVersions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#global_logging_level JmsFleetAdvancedFeatureConfiguration#global_logging_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "globalLoggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GlobalLoggingLevel
        {
            get;
            set;
        }

        /// <summary>minimum_key_size_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#minimum_key_size_settings JmsFleetAdvancedFeatureConfiguration#minimum_key_size_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumKeySizeSettings", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettings\"}", isOptional: true)]
        public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettings? MinimumKeySizeSettings
        {
            get;
            set;
        }

        /// <summary>proxies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#proxies JmsFleetAdvancedFeatureConfiguration#proxies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxies", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies\"}", isOptional: true)]
        public oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies? Proxies
        {
            get;
            set;
        }

        private object? _shouldReplaceCertificatesOperatingSystem;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#should_replace_certificates_operating_system JmsFleetAdvancedFeatureConfiguration#should_replace_certificates_operating_system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldReplaceCertificatesOperatingSystem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldReplaceCertificatesOperatingSystem
        {
            get => _shouldReplaceCertificatesOperatingSystem;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shouldReplaceCertificatesOperatingSystem = value;
            }
        }
    }
}
