using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies")]
    public interface IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#ftp_proxy_host JmsFleetAdvancedFeatureConfiguration#ftp_proxy_host}.</summary>
        [JsiiProperty(name: "ftpProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FtpProxyHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#ftp_proxy_port JmsFleetAdvancedFeatureConfiguration#ftp_proxy_port}.</summary>
        [JsiiProperty(name: "ftpProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FtpProxyPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#http_proxy_host JmsFleetAdvancedFeatureConfiguration#http_proxy_host}.</summary>
        [JsiiProperty(name: "httpProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpProxyHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#http_proxy_port JmsFleetAdvancedFeatureConfiguration#http_proxy_port}.</summary>
        [JsiiProperty(name: "httpProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpProxyPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#https_proxy_host JmsFleetAdvancedFeatureConfiguration#https_proxy_host}.</summary>
        [JsiiProperty(name: "httpsProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpsProxyHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#https_proxy_port JmsFleetAdvancedFeatureConfiguration#https_proxy_port}.</summary>
        [JsiiProperty(name: "httpsProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpsProxyPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#socks_proxy_host JmsFleetAdvancedFeatureConfiguration#socks_proxy_host}.</summary>
        [JsiiProperty(name: "socksProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SocksProxyHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#socks_proxy_port JmsFleetAdvancedFeatureConfiguration#socks_proxy_port}.</summary>
        [JsiiProperty(name: "socksProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SocksProxyPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#use_system_proxies JmsFleetAdvancedFeatureConfiguration#use_system_proxies}.</summary>
        [JsiiProperty(name: "useSystemProxies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseSystemProxies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies")]
        internal sealed class _Proxy : DeputyBase, oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#ftp_proxy_host JmsFleetAdvancedFeatureConfiguration#ftp_proxy_host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ftpProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FtpProxyHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#ftp_proxy_port JmsFleetAdvancedFeatureConfiguration#ftp_proxy_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ftpProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FtpProxyPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#http_proxy_host JmsFleetAdvancedFeatureConfiguration#http_proxy_host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpProxyHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#http_proxy_port JmsFleetAdvancedFeatureConfiguration#http_proxy_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpProxyPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#https_proxy_host JmsFleetAdvancedFeatureConfiguration#https_proxy_host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpsProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpsProxyHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#https_proxy_port JmsFleetAdvancedFeatureConfiguration#https_proxy_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpsProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpsProxyPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#socks_proxy_host JmsFleetAdvancedFeatureConfiguration#socks_proxy_host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "socksProxyHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SocksProxyHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#socks_proxy_port JmsFleetAdvancedFeatureConfiguration#socks_proxy_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "socksProxyPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SocksProxyPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#use_system_proxies JmsFleetAdvancedFeatureConfiguration#use_system_proxies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useSystemProxies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseSystemProxies
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
