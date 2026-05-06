using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyPolicyConfig")]
    public class WaasWaasPolicyPolicyConfig : oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#certificate_id WaasWaasPolicy#certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#cipher_group WaasWaasPolicy#cipher_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cipherGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CipherGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#client_address_header WaasWaasPolicy#client_address_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientAddressHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientAddressHeader
        {
            get;
            set;
        }

        /// <summary>health_checks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#health_checks WaasWaasPolicy#health_checks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthChecks", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfigHealthChecks\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigHealthChecks? HealthChecks
        {
            get;
            set;
        }

        private object? _isBehindCdn;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_behind_cdn WaasWaasPolicy#is_behind_cdn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isBehindCdn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsBehindCdn
        {
            get => _isBehindCdn;
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
                _isBehindCdn = value;
            }
        }

        private object? _isCacheControlRespected;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_cache_control_respected WaasWaasPolicy#is_cache_control_respected}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isCacheControlRespected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCacheControlRespected
        {
            get => _isCacheControlRespected;
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
                _isCacheControlRespected = value;
            }
        }

        private object? _isHttpsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_https_enabled WaasWaasPolicy#is_https_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isHttpsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsHttpsEnabled
        {
            get => _isHttpsEnabled;
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
                _isHttpsEnabled = value;
            }
        }

        private object? _isHttpsForced;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_https_forced WaasWaasPolicy#is_https_forced}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isHttpsForced", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsHttpsForced
        {
            get => _isHttpsForced;
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
                _isHttpsForced = value;
            }
        }

        private object? _isOriginCompressionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_origin_compression_enabled WaasWaasPolicy#is_origin_compression_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isOriginCompressionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsOriginCompressionEnabled
        {
            get => _isOriginCompressionEnabled;
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
                _isOriginCompressionEnabled = value;
            }
        }

        private object? _isResponseBufferingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_response_buffering_enabled WaasWaasPolicy#is_response_buffering_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isResponseBufferingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsResponseBufferingEnabled
        {
            get => _isResponseBufferingEnabled;
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
                _isResponseBufferingEnabled = value;
            }
        }

        private object? _isSniEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_sni_enabled WaasWaasPolicy#is_sni_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSniEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSniEnabled
        {
            get => _isSniEnabled;
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
                _isSniEnabled = value;
            }
        }

        /// <summary>load_balancing_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#load_balancing_method WaasWaasPolicy#load_balancing_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingMethod", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfigLoadBalancingMethod\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigLoadBalancingMethod? LoadBalancingMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#tls_protocols WaasWaasPolicy#tls_protocols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TlsProtocols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#websocket_path_prefixes WaasWaasPolicy#websocket_path_prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "websocketPathPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WebsocketPathPrefixes
        {
            get;
            set;
        }
    }
}
