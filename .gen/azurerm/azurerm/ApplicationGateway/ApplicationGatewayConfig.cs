using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayConfig")]
    public class ApplicationGatewayConfig : azurerm.ApplicationGateway.IApplicationGatewayConfig
    {
        private object _backendAddressPool;

        /// <summary>backend_address_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend_address_pool ApplicationGateway#backend_address_pool}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackendAddressPool" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "backendAddressPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendAddressPool\"},\"kind\":\"array\"}}]}}")]
        public object BackendAddressPool
        {
            get => _backendAddressPool;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayBackendAddressPool[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayBackendAddressPool).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayBackendAddressPool).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backendAddressPool = value;
            }
        }

        private object _frontendIpConfiguration;

        /// <summary>frontend_ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#frontend_ip_configuration ApplicationGateway#frontend_ip_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayFrontendIpConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "frontendIpConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayFrontendIpConfiguration\"},\"kind\":\"array\"}}]}}")]
        public object FrontendIpConfiguration
        {
            get => _frontendIpConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayFrontendIpConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayFrontendIpConfiguration).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayFrontendIpConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _frontendIpConfiguration = value;
            }
        }

        private object _frontendPort;

        /// <summary>frontend_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#frontend_port ApplicationGateway#frontend_port}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayFrontendPort" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "frontendPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayFrontendPort\"},\"kind\":\"array\"}}]}}")]
        public object FrontendPort
        {
            get => _frontendPort;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayFrontendPort[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayFrontendPort).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayFrontendPort).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _frontendPort = value;
            }
        }

        private object _gatewayIpConfiguration;

        /// <summary>gateway_ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#gateway_ip_configuration ApplicationGateway#gateway_ip_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayGatewayIpConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "gatewayIpConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayGatewayIpConfiguration\"},\"kind\":\"array\"}}]}}")]
        public object GatewayIpConfiguration
        {
            get => _gatewayIpConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayGatewayIpConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayGatewayIpConfiguration).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayGatewayIpConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _gatewayIpConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#location ApplicationGateway#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#resource_group_name ApplicationGateway#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>sku block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#sku ApplicationGateway#sku}
        /// </remarks>
        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySku\"}")]
        public azurerm.ApplicationGateway.IApplicationGatewaySku Sku
        {
            get;
            set;
        }

        private object? _authenticationCertificate;

        /// <summary>authentication_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#authentication_certificate ApplicationGateway#authentication_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayAuthenticationCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayAuthenticationCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuthenticationCertificate
        {
            get => _authenticationCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayAuthenticationCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayAuthenticationCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authenticationCertificate = value;
            }
        }

        /// <summary>autoscale_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#autoscale_configuration ApplicationGateway#autoscale_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoscaleConfiguration", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayAutoscaleConfiguration\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewayAutoscaleConfiguration? AutoscaleConfiguration
        {
            get;
            set;
        }

        private object? _backend;

        /// <summary>backend block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend ApplicationGateway#backend}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackend" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backend", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackend\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Backend
        {
            get => _backend;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayBackend[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayBackend).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backend = value;
            }
        }

        private object? _backendHttpSettings;

        /// <summary>backend_http_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend_http_settings ApplicationGateway#backend_http_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendHttpSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendHttpSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BackendHttpSettings
        {
            get => _backendHttpSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backendHttpSettings = value;
            }
        }

        private object? _customErrorConfiguration;

        /// <summary>custom_error_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#custom_error_configuration ApplicationGateway#custom_error_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayCustomErrorConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customErrorConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayCustomErrorConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomErrorConfiguration
        {
            get => _customErrorConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayCustomErrorConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayCustomErrorConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customErrorConfiguration = value;
            }
        }

        private object? _enableHttp2;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#enable_http2 ApplicationGateway#enable_http2}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableHttp2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableHttp2
        {
            get => _enableHttp2;
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
                _enableHttp2 = value;
            }
        }

        private object? _fipsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#fips_enabled ApplicationGateway#fips_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fipsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FipsEnabled
        {
            get => _fipsEnabled;
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
                _fipsEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#firewall_policy_id ApplicationGateway#firewall_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firewallPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirewallPolicyId
        {
            get;
            set;
        }

        private object? _forceFirewallPolicyAssociation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#force_firewall_policy_association ApplicationGateway#force_firewall_policy_association}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forceFirewallPolicyAssociation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ForceFirewallPolicyAssociation
        {
            get => _forceFirewallPolicyAssociation;
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
                _forceFirewallPolicyAssociation = value;
            }
        }

        /// <summary>global block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#global ApplicationGateway#global}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "global", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayGlobal\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewayGlobal? Global
        {
            get;
            set;
        }

        private object? _http2Enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#http2_enabled ApplicationGateway#http2_enabled}.</summary>
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

        private object? _httpListener;

        /// <summary>http_listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#http_listener ApplicationGateway#http_listener}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayHttpListener" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpListener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayHttpListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HttpListener
        {
            get => _httpListener;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayHttpListener[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayHttpListener).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpListener = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#id ApplicationGateway#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#identity ApplicationGateway#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayIdentity\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewayIdentity? Identity
        {
            get;
            set;
        }

        private object? _listener;

        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#listener ApplicationGateway#listener}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayListener" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Listener
        {
            get => _listener;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayListener[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayListener).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _listener = value;
            }
        }

        private object? _privateLinkConfiguration;

        /// <summary>private_link_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#private_link_configuration ApplicationGateway#private_link_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayPrivateLinkConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayPrivateLinkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PrivateLinkConfiguration
        {
            get => _privateLinkConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayPrivateLinkConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayPrivateLinkConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _privateLinkConfiguration = value;
            }
        }

        private object? _probe;

        /// <summary>probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#probe ApplicationGateway#probe}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayProbe" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "probe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Probe
        {
            get => _probe;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayProbe[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayProbe).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _probe = value;
            }
        }

        private object? _redirectConfiguration;

        /// <summary>redirect_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#redirect_configuration ApplicationGateway#redirect_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRedirectConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirectConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRedirectConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RedirectConfiguration
        {
            get => _redirectConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayRedirectConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayRedirectConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redirectConfiguration = value;
            }
        }

        private object? _requestRoutingRule;

        /// <summary>request_routing_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#request_routing_rule ApplicationGateway#request_routing_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRequestRoutingRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestRoutingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRequestRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestRoutingRule
        {
            get => _requestRoutingRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayRequestRoutingRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayRequestRoutingRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestRoutingRule = value;
            }
        }

        private object? _rewriteRuleSet;

        /// <summary>rewrite_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#rewrite_rule_set ApplicationGateway#rewrite_rule_set}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSet" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rewriteRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RewriteRuleSet
        {
            get => _rewriteRuleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rewriteRuleSet = value;
            }
        }

        private object? _routingRule;

        /// <summary>routing_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#routing_rule ApplicationGateway#routing_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRoutingRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RoutingRule
        {
            get => _routingRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayRoutingRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayRoutingRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _routingRule = value;
            }
        }

        private object? _sslCertificate;

        /// <summary>ssl_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_certificate ApplicationGateway#ssl_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewaySslCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SslCertificate
        {
            get => _sslCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewaySslCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewaySslCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sslCertificate = value;
            }
        }

        /// <summary>ssl_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_policy ApplicationGateway#ssl_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslPolicy", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslPolicy\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewaySslPolicy? SslPolicy
        {
            get;
            set;
        }

        private object? _sslProfile;

        /// <summary>ssl_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_profile ApplicationGateway#ssl_profile}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewaySslProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SslProfile
        {
            get => _sslProfile;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewaySslProfile[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewaySslProfile).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sslProfile = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#tags ApplicationGateway#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#timeouts ApplicationGateway#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTimeouts\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewayTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _trustedClientCertificate;

        /// <summary>trusted_client_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#trusted_client_certificate ApplicationGateway#trusted_client_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayTrustedClientCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustedClientCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTrustedClientCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrustedClientCertificate
        {
            get => _trustedClientCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayTrustedClientCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayTrustedClientCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trustedClientCertificate = value;
            }
        }

        private object? _trustedRootCertificate;

        /// <summary>trusted_root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#trusted_root_certificate ApplicationGateway#trusted_root_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayTrustedRootCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustedRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTrustedRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrustedRootCertificate
        {
            get => _trustedRootCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayTrustedRootCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayTrustedRootCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trustedRootCertificate = value;
            }
        }

        private object? _urlPathMap;

        /// <summary>url_path_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#url_path_map ApplicationGateway#url_path_map}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayUrlPathMap" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlPathMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayUrlPathMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UrlPathMap
        {
            get => _urlPathMap;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayUrlPathMap[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayUrlPathMap).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlPathMap = value;
            }
        }

        /// <summary>waf_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#waf_configuration ApplicationGateway#waf_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wafConfiguration", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfiguration\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewayWafConfiguration? WafConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#zones ApplicationGateway#zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Zones
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
