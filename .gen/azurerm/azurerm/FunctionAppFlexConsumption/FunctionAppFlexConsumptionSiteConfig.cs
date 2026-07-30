using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiByValue(fqn: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfig")]
    public class FunctionAppFlexConsumptionSiteConfig : azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfig
    {
        /// <summary>The URL of the API definition that describes this Linux Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#api_definition_url FunctionAppFlexConsumption#api_definition_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiDefinitionUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiDefinitionUrl
        {
            get;
            set;
        }

        /// <summary>The ID of the API Management API for this Linux Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#api_management_api_id FunctionAppFlexConsumption#api_management_api_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiManagementApiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiManagementApiId
        {
            get;
            set;
        }

        /// <summary>The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#app_command_line FunctionAppFlexConsumption#app_command_line}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appCommandLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppCommandLine
        {
            get;
            set;
        }

        /// <summary>The Connection String for linking the Linux Function App to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#application_insights_connection_string FunctionAppFlexConsumption#application_insights_connection_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationInsightsConnectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationInsightsConnectionString
        {
            get;
            set;
        }

        /// <summary>The Instrumentation Key for connecting the Linux Function App to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#application_insights_key FunctionAppFlexConsumption#application_insights_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationInsightsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationInsightsKey
        {
            get;
            set;
        }

        /// <summary>app_service_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#app_service_logs FunctionAppFlexConsumption#app_service_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appServiceLogs", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigAppServiceLogs\"}", isOptional: true)]
        public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigAppServiceLogs? AppServiceLogs
        {
            get;
            set;
        }

        /// <summary>The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#container_registry_managed_identity_client_id FunctionAppFlexConsumption#container_registry_managed_identity_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryManagedIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerRegistryManagedIdentityClientId
        {
            get;
            set;
        }

        private object? _containerRegistryUseManagedIdentity;

        /// <summary>Should connections for Azure Container Registry use Managed Identity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#container_registry_use_managed_identity FunctionAppFlexConsumption#container_registry_use_managed_identity}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryUseManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ContainerRegistryUseManagedIdentity
        {
            get => _containerRegistryUseManagedIdentity;
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
                _containerRegistryUseManagedIdentity = value;
            }
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#cors FunctionAppFlexConsumption#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigCors\"}", isOptional: true)]
        public azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigCors? Cors
        {
            get;
            set;
        }

        /// <summary>Specifies a list of Default Documents for the Linux Web App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#default_documents FunctionAppFlexConsumption#default_documents}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultDocuments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DefaultDocuments
        {
            get;
            set;
        }

        /// <summary>The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#elastic_instance_minimum FunctionAppFlexConsumption#elastic_instance_minimum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticInstanceMinimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ElasticInstanceMinimum
        {
            get;
            set;
        }

        /// <summary>The amount of time in minutes that a node is unhealthy before being removed from the load balancer.</summary>
        /// <remarks>
        /// Possible values are between <c>2</c> and <c>10</c>. Only valid in conjunction with <c>health_check_path</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#health_check_eviction_time_in_min FunctionAppFlexConsumption#health_check_eviction_time_in_min}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckEvictionTimeInMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckEvictionTimeInMin
        {
            get;
            set;
        }

        /// <summary>The path to be checked for this function app health.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#health_check_path FunctionAppFlexConsumption#health_check_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckPath
        {
            get;
            set;
        }

        private object? _http2Enabled;

        /// <summary>Specifies if the http2 protocol should be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#http2_enabled FunctionAppFlexConsumption#http2_enabled}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#ip_restriction FunctionAppFlexConsumption#ip_restriction}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigIpRestriction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigIpRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigIpRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipRestriction = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#ip_restriction_default_action FunctionAppFlexConsumption#ip_restriction_default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpRestrictionDefaultAction
        {
            get;
            set;
        }

        /// <summary>The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#load_balancing_mode FunctionAppFlexConsumption#load_balancing_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancingMode
        {
            get;
            set;
        }

        /// <summary>The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#managed_pipeline_mode FunctionAppFlexConsumption#managed_pipeline_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedPipelineMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedPipelineMode
        {
            get;
            set;
        }

        /// <summary>The configures the minimum version of TLS required for SSL requests.</summary>
        /// <remarks>
        /// Possible values include: <c>1.0</c>, <c>1.1</c>, and  <c>1.2</c>. Defaults to <c>1.2</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#minimum_tls_version FunctionAppFlexConsumption#minimum_tls_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumTlsVersion
        {
            get;
            set;
        }

        private object? _remoteDebuggingEnabled;

        /// <summary>Should Remote Debugging be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#remote_debugging_enabled FunctionAppFlexConsumption#remote_debugging_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteDebuggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RemoteDebuggingEnabled
        {
            get => _remoteDebuggingEnabled;
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
                _remoteDebuggingEnabled = value;
            }
        }

        /// <summary>The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022``.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#remote_debugging_version FunctionAppFlexConsumption#remote_debugging_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteDebuggingVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteDebuggingVersion
        {
            get;
            set;
        }

        private object? _runtimeScaleMonitoringEnabled;

        /// <summary>Should Functions Runtime Scale Monitoring be enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#runtime_scale_monitoring_enabled FunctionAppFlexConsumption#runtime_scale_monitoring_enabled}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#scm_ip_restriction FunctionAppFlexConsumption#scm_ip_restriction}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestriction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigScmIpRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scmIpRestriction = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#scm_ip_restriction_default_action FunctionAppFlexConsumption#scm_ip_restriction_default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScmIpRestrictionDefaultAction
        {
            get;
            set;
        }

        /// <summary>Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#scm_minimum_tls_version FunctionAppFlexConsumption#scm_minimum_tls_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scmMinimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScmMinimumTlsVersion
        {
            get;
            set;
        }

        private object? _scmUseMainIpRestriction;

        /// <summary>Should the Linux Function App `ip_restriction` configuration be used for the SCM also.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#scm_use_main_ip_restriction FunctionAppFlexConsumption#scm_use_main_ip_restriction}
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

        private object? _use32BitWorker;

        /// <summary>Should the Linux Function App use a 32-bit worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#use_32_bit_worker FunctionAppFlexConsumption#use_32_bit_worker}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "use32BitWorker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Use32BitWorker
        {
            get => _use32BitWorker;
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
                _use32BitWorker = value;
            }
        }

        private object? _vnetRouteAllEnabled;

        /// <summary>Should the Linux Function App route all traffic through the virtual network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#vnet_route_all_enabled FunctionAppFlexConsumption#vnet_route_all_enabled}
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

        /// <summary>Should Web Sockets be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#websockets_enabled FunctionAppFlexConsumption#websockets_enabled}
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

        /// <summary>The number of Workers for this Linux Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/function_app_flex_consumption#worker_count FunctionAppFlexConsumption#worker_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WorkerCount
        {
            get;
            set;
        }
    }
}
