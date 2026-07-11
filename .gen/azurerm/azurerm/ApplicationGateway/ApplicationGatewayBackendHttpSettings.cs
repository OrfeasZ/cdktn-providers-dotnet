using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayBackendHttpSettings")]
    public class ApplicationGatewayBackendHttpSettings : azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#cookie_based_affinity ApplicationGateway#cookie_based_affinity}.</summary>
        [JsiiProperty(name: "cookieBasedAffinity", typeJson: "{\"primitive\":\"string\"}")]
        public string CookieBasedAffinity
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#port ApplicationGateway#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#protocol ApplicationGateway#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#affinity_cookie_name ApplicationGateway#affinity_cookie_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "affinityCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AffinityCookieName
        {
            get;
            set;
        }

        private object? _authenticationCertificate;

        /// <summary>authentication_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#authentication_certificate ApplicationGateway#authentication_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettingsAuthenticationCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendHttpSettingsAuthenticationCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettingsAuthenticationCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettingsAuthenticationCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authenticationCertificate = value;
            }
        }

        private object? _certificateChainValidationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#certificate_chain_validation_enabled ApplicationGateway#certificate_chain_validation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificateChainValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CertificateChainValidationEnabled
        {
            get => _certificateChainValidationEnabled;
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
                _certificateChainValidationEnabled = value;
            }
        }

        /// <summary>connection_draining block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#connection_draining ApplicationGateway#connection_draining}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionDraining", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendHttpSettingsConnectionDraining\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettingsConnectionDraining? ConnectionDraining
        {
            get;
            set;
        }

        private object? _dedicatedBackendConnectionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#dedicated_backend_connection_enabled ApplicationGateway#dedicated_backend_connection_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedBackendConnectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DedicatedBackendConnectionEnabled
        {
            get => _dedicatedBackendConnectionEnabled;
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
                _dedicatedBackendConnectionEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#host_name ApplicationGateway#host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#path ApplicationGateway#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        private object? _pickHostNameFromBackendAddress;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#pick_host_name_from_backend_address ApplicationGateway#pick_host_name_from_backend_address}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pickHostNameFromBackendAddress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PickHostNameFromBackendAddress
        {
            get => _pickHostNameFromBackendAddress;
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
                _pickHostNameFromBackendAddress = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#probe_name ApplicationGateway#probe_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "probeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProbeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#request_timeout ApplicationGateway#request_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RequestTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#sni_name ApplicationGateway#sni_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sniName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SniName
        {
            get;
            set;
        }

        private object? _sniValidationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#sni_validation_enabled ApplicationGateway#sni_validation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sniValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SniValidationEnabled
        {
            get => _sniValidationEnabled;
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
                _sniValidationEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#trusted_root_certificate_names ApplicationGateway#trusted_root_certificate_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedRootCertificateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedRootCertificateNames
        {
            get;
            set;
        }
    }
}
