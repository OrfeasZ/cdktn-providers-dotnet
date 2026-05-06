using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyPolicyConfig), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyPolicyConfig")]
    public interface IWaasWaasPolicyPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#certificate_id WaasWaasPolicy#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#cipher_group WaasWaasPolicy#cipher_group}.</summary>
        [JsiiProperty(name: "cipherGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CipherGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#client_address_header WaasWaasPolicy#client_address_header}.</summary>
        [JsiiProperty(name: "clientAddressHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientAddressHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_checks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#health_checks WaasWaasPolicy#health_checks}
        /// </remarks>
        [JsiiProperty(name: "healthChecks", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfigHealthChecks\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigHealthChecks? HealthChecks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_behind_cdn WaasWaasPolicy#is_behind_cdn}.</summary>
        [JsiiProperty(name: "isBehindCdn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsBehindCdn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_cache_control_respected WaasWaasPolicy#is_cache_control_respected}.</summary>
        [JsiiProperty(name: "isCacheControlRespected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCacheControlRespected
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_https_enabled WaasWaasPolicy#is_https_enabled}.</summary>
        [JsiiProperty(name: "isHttpsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsHttpsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_https_forced WaasWaasPolicy#is_https_forced}.</summary>
        [JsiiProperty(name: "isHttpsForced", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsHttpsForced
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_origin_compression_enabled WaasWaasPolicy#is_origin_compression_enabled}.</summary>
        [JsiiProperty(name: "isOriginCompressionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsOriginCompressionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_response_buffering_enabled WaasWaasPolicy#is_response_buffering_enabled}.</summary>
        [JsiiProperty(name: "isResponseBufferingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsResponseBufferingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_sni_enabled WaasWaasPolicy#is_sni_enabled}.</summary>
        [JsiiProperty(name: "isSniEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSniEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancing_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#load_balancing_method WaasWaasPolicy#load_balancing_method}
        /// </remarks>
        [JsiiProperty(name: "loadBalancingMethod", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfigLoadBalancingMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigLoadBalancingMethod? LoadBalancingMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#tls_protocols WaasWaasPolicy#tls_protocols}.</summary>
        [JsiiProperty(name: "tlsProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TlsProtocols
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#websocket_path_prefixes WaasWaasPolicy#websocket_path_prefixes}.</summary>
        [JsiiProperty(name: "websocketPathPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WebsocketPathPrefixes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyPolicyConfig), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#certificate_id WaasWaasPolicy#certificate_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#cipher_group WaasWaasPolicy#cipher_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cipherGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CipherGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#client_address_header WaasWaasPolicy#client_address_header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientAddressHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientAddressHeader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>health_checks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#health_checks WaasWaasPolicy#health_checks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthChecks", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfigHealthChecks\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigHealthChecks? HealthChecks
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigHealthChecks?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_behind_cdn WaasWaasPolicy#is_behind_cdn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isBehindCdn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsBehindCdn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_cache_control_respected WaasWaasPolicy#is_cache_control_respected}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCacheControlRespected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCacheControlRespected
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_https_enabled WaasWaasPolicy#is_https_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isHttpsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsHttpsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_https_forced WaasWaasPolicy#is_https_forced}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isHttpsForced", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsHttpsForced
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_origin_compression_enabled WaasWaasPolicy#is_origin_compression_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isOriginCompressionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsOriginCompressionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_response_buffering_enabled WaasWaasPolicy#is_response_buffering_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isResponseBufferingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsResponseBufferingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_sni_enabled WaasWaasPolicy#is_sni_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSniEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSniEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>load_balancing_method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#load_balancing_method WaasWaasPolicy#load_balancing_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancingMethod", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfigLoadBalancingMethod\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigLoadBalancingMethod? LoadBalancingMethod
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigLoadBalancingMethod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#tls_protocols WaasWaasPolicy#tls_protocols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TlsProtocols
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#websocket_path_prefixes WaasWaasPolicy#websocket_path_prefixes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "websocketPathPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WebsocketPathPrefixes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
