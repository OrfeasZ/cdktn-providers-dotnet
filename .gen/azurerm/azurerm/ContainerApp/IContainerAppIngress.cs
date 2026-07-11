using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppIngress), fullyQualifiedName: "azurerm.containerApp.ContainerAppIngress")]
    public interface IContainerAppIngress
    {
        /// <summary>The target port on the container for the Ingress traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#target_port ContainerApp#target_port}
        /// </remarks>
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        double TargetPort
        {
            get;
        }

        /// <summary>traffic_weight block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#traffic_weight ContainerApp#traffic_weight}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppIngressTrafficWeight" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "trafficWeight", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppIngressTrafficWeight\"},\"kind\":\"array\"}}]}}")]
        object TrafficWeight
        {
            get;
        }

        /// <summary>Should this ingress allow insecure connections?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#allow_insecure_connections ContainerApp#allow_insecure_connections}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowInsecureConnections", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowInsecureConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Client certificate mode for mTLS authentication.</summary>
        /// <remarks>
        /// Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#client_certificate_mode ContainerApp#client_certificate_mode}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#cors ContainerApp#cors}
        /// </remarks>
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.containerApp.ContainerAppIngressCors\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerApp.IContainerAppIngressCors? Cors
        {
            get
            {
                return null;
            }
        }

        /// <summary>The exposed port on the container for the Ingress traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#exposed_port ContainerApp#exposed_port}
        /// </remarks>
        [JsiiProperty(name: "exposedPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExposedPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Is this an external Ingress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#external_enabled ContainerApp#external_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "externalEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_security_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#ip_security_restriction ContainerApp#ip_security_restriction}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppIngressIpSecurityRestriction" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipSecurityRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppIngressIpSecurityRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpSecurityRestriction
        {
            get
            {
                return null;
            }
        }

        /// <summary>The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#transport ContainerApp#transport}
        /// </remarks>
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Transport
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppIngress), fullyQualifiedName: "azurerm.containerApp.ContainerAppIngress")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppIngress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The target port on the container for the Ingress traffic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#target_port ContainerApp#target_port}
            /// </remarks>
            [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>traffic_weight block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#traffic_weight ContainerApp#traffic_weight}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppIngressTrafficWeight" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "trafficWeight", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppIngressTrafficWeight\"},\"kind\":\"array\"}}]}}")]
            public object TrafficWeight
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Should this ingress allow insecure connections?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#allow_insecure_connections ContainerApp#allow_insecure_connections}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowInsecureConnections", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowInsecureConnections
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Client certificate mode for mTLS authentication.</summary>
            /// <remarks>
            /// Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#client_certificate_mode ContainerApp#client_certificate_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#cors ContainerApp#cors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.containerApp.ContainerAppIngressCors\"}", isOptional: true)]
            public azurerm.ContainerApp.IContainerAppIngressCors? Cors
            {
                get => GetInstanceProperty<azurerm.ContainerApp.IContainerAppIngressCors?>();
            }

            /// <summary>The exposed port on the container for the Ingress traffic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#exposed_port ContainerApp#exposed_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exposedPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExposedPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Is this an external Ingress.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#external_enabled ContainerApp#external_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExternalEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ip_security_restriction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#ip_security_restriction ContainerApp#ip_security_restriction}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppIngressIpSecurityRestriction" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSecurityRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppIngressIpSecurityRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IpSecurityRestriction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app#transport ContainerApp#transport}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Transport
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
