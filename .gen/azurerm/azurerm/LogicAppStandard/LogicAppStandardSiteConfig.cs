using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppStandard
{
    [JsiiByValue(fqn: "azurerm.logicAppStandard.LogicAppStandardSiteConfig")]
    public class LogicAppStandardSiteConfig : azurerm.LogicAppStandard.ILogicAppStandardSiteConfig
    {
        private object? _alwaysOn;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#always_on LogicAppStandard#always_on}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alwaysOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AlwaysOn
        {
            get => _alwaysOn;
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
                _alwaysOn = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#app_scale_limit LogicAppStandard#app_scale_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appScaleLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AppScaleLimit
        {
            get;
            set;
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#cors LogicAppStandard#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.logicAppStandard.LogicAppStandardSiteConfigCors\"}", isOptional: true)]
        public azurerm.LogicAppStandard.ILogicAppStandardSiteConfigCors? Cors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#dotnet_framework_version LogicAppStandard#dotnet_framework_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dotnetFrameworkVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DotnetFrameworkVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#elastic_instance_minimum LogicAppStandard#elastic_instance_minimum}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticInstanceMinimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ElasticInstanceMinimum
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#ftps_state LogicAppStandard#ftps_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ftpsState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FtpsState
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#health_check_path LogicAppStandard#health_check_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckPath
        {
            get;
            set;
        }

        private object? _http2Enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#http2_enabled LogicAppStandard#http2_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Http2Enabled
        {
            get => _http2Enabled;
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
                _http2Enabled = value;
            }
        }

        private object? _ipRestriction;

        /// <summary>ip_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#ip_restriction LogicAppStandard#ip_restriction}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LogicAppStandard.ILogicAppStandardSiteConfigIpRestriction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logicAppStandard.LogicAppStandardSiteConfigIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpRestriction
        {
            get => _ipRestriction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.LogicAppStandard.ILogicAppStandardSiteConfigIpRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LogicAppStandard.ILogicAppStandardSiteConfigIpRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipRestriction = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#ip_restriction_default_action LogicAppStandard#ip_restriction_default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpRestrictionDefaultAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#linux_fx_version LogicAppStandard#linux_fx_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linuxFxVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LinuxFxVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#min_tls_version LogicAppStandard#min_tls_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinTlsVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#pre_warmed_instance_count LogicAppStandard#pre_warmed_instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preWarmedInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PreWarmedInstanceCount
        {
            get;
            set;
        }

        private object? _runtimeScaleMonitoringEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#runtime_scale_monitoring_enabled LogicAppStandard#runtime_scale_monitoring_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeScaleMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RuntimeScaleMonitoringEnabled
        {
            get => _runtimeScaleMonitoringEnabled;
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
                _runtimeScaleMonitoringEnabled = value;
            }
        }

        private object? _scmIpRestriction;

        /// <summary>scm_ip_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#scm_ip_restriction LogicAppStandard#scm_ip_restriction}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LogicAppStandard.ILogicAppStandardSiteConfigScmIpRestriction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logicAppStandard.LogicAppStandardSiteConfigScmIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScmIpRestriction
        {
            get => _scmIpRestriction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.LogicAppStandard.ILogicAppStandardSiteConfigScmIpRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LogicAppStandard.ILogicAppStandardSiteConfigScmIpRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scmIpRestriction = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#scm_ip_restriction_default_action LogicAppStandard#scm_ip_restriction_default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScmIpRestrictionDefaultAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#scm_min_tls_version LogicAppStandard#scm_min_tls_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scmMinTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScmMinTlsVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#scm_type LogicAppStandard#scm_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScmType
        {
            get;
            set;
        }

        private object? _scmUseMainIpRestriction;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#scm_use_main_ip_restriction LogicAppStandard#scm_use_main_ip_restriction}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmUseMainIpRestriction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ScmUseMainIpRestriction
        {
            get => _scmUseMainIpRestriction;
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
                _scmUseMainIpRestriction = value;
            }
        }

        private object? _use32BitWorkerProcess;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#use_32_bit_worker_process LogicAppStandard#use_32_bit_worker_process}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "use32BitWorkerProcess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Use32BitWorkerProcess
        {
            get => _use32BitWorkerProcess;
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
                _use32BitWorkerProcess = value;
            }
        }

        private object? _vnetRouteAllEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#vnet_route_all_enabled LogicAppStandard#vnet_route_all_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnetRouteAllEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? VnetRouteAllEnabled
        {
            get => _vnetRouteAllEnabled;
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
                _vnetRouteAllEnabled = value;
            }
        }

        private object? _websocketsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/logic_app_standard#websockets_enabled LogicAppStandard#websockets_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "websocketsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? WebsocketsEnabled
        {
            get => _websocketsEnabled;
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
                _websocketsEnabled = value;
            }
        }
    }
}
