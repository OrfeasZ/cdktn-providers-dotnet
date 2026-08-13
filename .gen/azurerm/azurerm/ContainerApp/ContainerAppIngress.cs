using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppIngress")]
    public class ContainerAppIngress : azurerm.ContainerApp.IContainerAppIngress
    {
        /// <summary>The target port on the container for the Ingress traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#target_port ContainerApp#target_port}
        /// </remarks>
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        public double TargetPort
        {
            get;
            set;
        }

        private object _trafficWeight;

        /// <summary>traffic_weight block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#traffic_weight ContainerApp#traffic_weight}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppIngressTrafficWeight" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "trafficWeight", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppIngressTrafficWeight\"},\"kind\":\"array\"}}]}}")]
        public object TrafficWeight
        {
            get => _trafficWeight;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppIngressTrafficWeight[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppIngressTrafficWeight).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppIngressTrafficWeight).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trafficWeight = value;
            }
        }

        private object? _allowInsecureConnections;

        /// <summary>Should this ingress allow insecure connections?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#allow_insecure_connections ContainerApp#allow_insecure_connections}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowInsecureConnections", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowInsecureConnections
        {
            get => _allowInsecureConnections;
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
                _allowInsecureConnections = value;
            }
        }

        /// <summary>Client certificate mode for mTLS authentication.</summary>
        /// <remarks>
        /// Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#client_certificate_mode ContainerApp#client_certificate_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificateMode
        {
            get;
            set;
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#cors ContainerApp#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.containerApp.ContainerAppIngressCors\"}", isOptional: true)]
        public azurerm.ContainerApp.IContainerAppIngressCors? Cors
        {
            get;
            set;
        }

        /// <summary>The exposed port on the container for the Ingress traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#exposed_port ContainerApp#exposed_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exposedPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExposedPort
        {
            get;
            set;
        }

        private object? _externalEnabled;

        /// <summary>Is this an external Ingress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#external_enabled ContainerApp#external_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExternalEnabled
        {
            get => _externalEnabled;
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
                _externalEnabled = value;
            }
        }

        private object? _ipSecurityRestriction;

        /// <summary>ip_security_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#ip_security_restriction ContainerApp#ip_security_restriction}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppIngressIpSecurityRestriction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSecurityRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppIngressIpSecurityRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpSecurityRestriction
        {
            get => _ipSecurityRestriction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppIngressIpSecurityRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppIngressIpSecurityRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipSecurityRestriction = value;
            }
        }

        /// <summary>The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/container_app#transport ContainerApp#transport}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Transport
        {
            get;
            set;
        }
    }
}
