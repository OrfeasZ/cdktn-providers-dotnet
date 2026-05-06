using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendSet
{
    [JsiiByValue(fqn: "oci.loadBalancerBackendSet.LoadBalancerBackendSetLbCookieSessionPersistenceConfiguration")]
    public class LoadBalancerBackendSetLbCookieSessionPersistenceConfiguration : oci.LoadBalancerBackendSet.ILoadBalancerBackendSetLbCookieSessionPersistenceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#cookie_name LoadBalancerBackendSet#cookie_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CookieName
        {
            get;
            set;
        }

        private object? _disableFallback;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#disable_fallback LoadBalancerBackendSet#disable_fallback}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableFallback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableFallback
        {
            get => _disableFallback;
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
                _disableFallback = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#domain LoadBalancerBackendSet#domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        private object? _isHttpOnly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#is_http_only LoadBalancerBackendSet#is_http_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isHttpOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsHttpOnly
        {
            get => _isHttpOnly;
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
                _isHttpOnly = value;
            }
        }

        private object? _isSecure;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#is_secure LoadBalancerBackendSet#is_secure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSecure
        {
            get => _isSecure;
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
                _isSecure = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#max_age_in_seconds LoadBalancerBackendSet#max_age_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAgeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAgeInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#path LoadBalancerBackendSet#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
