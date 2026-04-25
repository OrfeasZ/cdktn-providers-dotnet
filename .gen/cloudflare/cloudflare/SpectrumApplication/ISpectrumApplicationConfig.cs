using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SpectrumApplication
{
    [JsiiInterface(nativeType: typeof(ISpectrumApplicationConfig), fullyQualifiedName: "cloudflare.spectrumApplication.SpectrumApplicationConfig")]
    public interface ISpectrumApplicationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The name and type of DNS record for the Spectrum application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#dns SpectrumApplication#dns}
        /// </remarks>
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.spectrumApplication.SpectrumApplicationDns\"}")]
        cloudflare.SpectrumApplication.ISpectrumApplicationDns Dns
        {
            get;
        }

        /// <summary>The port configuration at Cloudflare's edge.</summary>
        /// <remarks>
        /// May specify a single port, for example <c>"tcp/1000"</c>, or a range of ports, for example <c>"tcp/1000-2000"</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#protocol SpectrumApplication#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Enables Argo Smart Routing for this application. Notes: Only available for TCP applications with traffic_type set to "direct".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#argo_smart_routing SpectrumApplication#argo_smart_routing}
        /// </remarks>
        [JsiiProperty(name: "argoSmartRouting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ArgoSmartRouting
        {
            get
            {
                return null;
            }
        }

        /// <summary>The anycast edge IP configuration for the hostname of this application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#edge_ips SpectrumApplication#edge_ips}
        /// </remarks>
        [JsiiProperty(name: "edgeIps", typeJson: "{\"fqn\":\"cloudflare.spectrumApplication.SpectrumApplicationEdgeIps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.SpectrumApplication.ISpectrumApplicationEdgeIps? EdgeIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables IP Access Rules for this application. Notes: Only available for TCP applications.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#ip_firewall SpectrumApplication#ip_firewall}
        /// </remarks>
        [JsiiProperty(name: "ipFirewall", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpFirewall
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of origin IP addresses. Array may contain multiple IP addresses for load balancing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#origin_direct SpectrumApplication#origin_direct}
        /// </remarks>
        [JsiiProperty(name: "originDirect", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OriginDirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name and type of DNS record for the Spectrum application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#origin_dns SpectrumApplication#origin_dns}
        /// </remarks>
        [JsiiProperty(name: "originDns", typeJson: "{\"fqn\":\"cloudflare.spectrumApplication.SpectrumApplicationOriginDns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.SpectrumApplication.ISpectrumApplicationOriginDns? OriginDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>The destination port at the origin.</summary>
        /// <remarks>
        /// Only specified in conjunction with origin_dns. May use an integer to specify a single origin port, for example <c>1000</c>, or a string to specify a range of origin ports, for example <c>"1000-2000"</c>.
        /// Notes: If specifying a port range, the number of ports in the range must match the number of ports specified in the "protocol" field.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#origin_port SpectrumApplication#origin_port}
        /// </remarks>
        [JsiiProperty(name: "originPort", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? OriginPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables Proxy Protocol to the origin.</summary>
        /// <remarks>
        /// Refer to <a href="https://developers.cloudflare.com/spectrum/getting-started/proxy-protocol/">Enable Proxy protocol</a> for implementation details on PROXY Protocol V1, PROXY Protocol V2, and Simple Proxy Protocol.
        /// Available values: "off", "v1", "v2", "simple".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#proxy_protocol SpectrumApplication#proxy_protocol}
        /// </remarks>
        [JsiiProperty(name: "proxyProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProxyProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of TLS termination associated with the application. Available values: "off", "flexible", "full", "strict".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#tls SpectrumApplication#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines how data travels from the edge to your origin.</summary>
        /// <remarks>
        /// When set to "direct", Spectrum will send traffic directly to your origin, and the application's type is derived from the <c>protocol</c>. When set to "http" or "https", Spectrum will apply Cloudflare's HTTP/HTTPS features as it sends traffic to your origin, and the application type matches this property exactly.
        /// Available values: "direct", "http", "https".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#traffic_type SpectrumApplication#traffic_type}
        /// </remarks>
        [JsiiProperty(name: "trafficType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrafficType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Zone identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#zone_id SpectrumApplication#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpectrumApplicationConfig), fullyQualifiedName: "cloudflare.spectrumApplication.SpectrumApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.SpectrumApplication.ISpectrumApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name and type of DNS record for the Spectrum application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#dns SpectrumApplication#dns}
            /// </remarks>
            [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.spectrumApplication.SpectrumApplicationDns\"}")]
            public cloudflare.SpectrumApplication.ISpectrumApplicationDns Dns
            {
                get => GetInstanceProperty<cloudflare.SpectrumApplication.ISpectrumApplicationDns>()!;
            }

            /// <summary>The port configuration at Cloudflare's edge.</summary>
            /// <remarks>
            /// May specify a single port, for example <c>"tcp/1000"</c>, or a range of ports, for example <c>"tcp/1000-2000"</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#protocol SpectrumApplication#protocol}
            /// </remarks>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Enables Argo Smart Routing for this application. Notes: Only available for TCP applications with traffic_type set to "direct".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#argo_smart_routing SpectrumApplication#argo_smart_routing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "argoSmartRouting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ArgoSmartRouting
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The anycast edge IP configuration for the hostname of this application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#edge_ips SpectrumApplication#edge_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "edgeIps", typeJson: "{\"fqn\":\"cloudflare.spectrumApplication.SpectrumApplicationEdgeIps\"}", isOptional: true)]
            public cloudflare.SpectrumApplication.ISpectrumApplicationEdgeIps? EdgeIps
            {
                get => GetInstanceProperty<cloudflare.SpectrumApplication.ISpectrumApplicationEdgeIps?>();
            }

            /// <summary>Enables IP Access Rules for this application. Notes: Only available for TCP applications.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#ip_firewall SpectrumApplication#ip_firewall}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipFirewall", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IpFirewall
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of origin IP addresses. Array may contain multiple IP addresses for load balancing.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#origin_direct SpectrumApplication#origin_direct}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originDirect", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OriginDirect
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The name and type of DNS record for the Spectrum application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#origin_dns SpectrumApplication#origin_dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originDns", typeJson: "{\"fqn\":\"cloudflare.spectrumApplication.SpectrumApplicationOriginDns\"}", isOptional: true)]
            public cloudflare.SpectrumApplication.ISpectrumApplicationOriginDns? OriginDns
            {
                get => GetInstanceProperty<cloudflare.SpectrumApplication.ISpectrumApplicationOriginDns?>();
            }

            /// <summary>The destination port at the origin.</summary>
            /// <remarks>
            /// Only specified in conjunction with origin_dns. May use an integer to specify a single origin port, for example <c>1000</c>, or a string to specify a range of origin ports, for example <c>"1000-2000"</c>.
            /// Notes: If specifying a port range, the number of ports in the range must match the number of ports specified in the "protocol" field.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#origin_port SpectrumApplication#origin_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originPort", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? OriginPort
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>Enables Proxy Protocol to the origin.</summary>
            /// <remarks>
            /// Refer to <a href="https://developers.cloudflare.com/spectrum/getting-started/proxy-protocol/">Enable Proxy protocol</a> for implementation details on PROXY Protocol V1, PROXY Protocol V2, and Simple Proxy Protocol.
            /// Available values: "off", "v1", "v2", "simple".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#proxy_protocol SpectrumApplication#proxy_protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "proxyProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProxyProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of TLS termination associated with the application. Available values: "off", "flexible", "full", "strict".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#tls SpectrumApplication#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tls
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Determines how data travels from the edge to your origin.</summary>
            /// <remarks>
            /// When set to "direct", Spectrum will send traffic directly to your origin, and the application's type is derived from the <c>protocol</c>. When set to "http" or "https", Spectrum will apply Cloudflare's HTTP/HTTPS features as it sends traffic to your origin, and the application type matches this property exactly.
            /// Available values: "direct", "http", "https".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#traffic_type SpectrumApplication#traffic_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrafficType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Zone identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#zone_id SpectrumApplication#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
