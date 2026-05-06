using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiByValue(fqn: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies")]
    public class JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies : oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#ftp_proxy_host JmsFleetAdvancedFeatureConfiguration#ftp_proxy_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ftpProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FtpProxyHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#ftp_proxy_port JmsFleetAdvancedFeatureConfiguration#ftp_proxy_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ftpProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FtpProxyPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#http_proxy_host JmsFleetAdvancedFeatureConfiguration#http_proxy_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpProxyHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#http_proxy_port JmsFleetAdvancedFeatureConfiguration#http_proxy_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpProxyPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#https_proxy_host JmsFleetAdvancedFeatureConfiguration#https_proxy_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpsProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpsProxyHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#https_proxy_port JmsFleetAdvancedFeatureConfiguration#https_proxy_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpsProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpsProxyPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#socks_proxy_host JmsFleetAdvancedFeatureConfiguration#socks_proxy_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "socksProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SocksProxyHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#socks_proxy_port JmsFleetAdvancedFeatureConfiguration#socks_proxy_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "socksProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SocksProxyPort
        {
            get;
            set;
        }

        private object? _useSystemProxies;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#use_system_proxies JmsFleetAdvancedFeatureConfiguration#use_system_proxies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useSystemProxies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseSystemProxies
        {
            get => _useSystemProxies;
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
                _useSystemProxies = value;
            }
        }
    }
}
