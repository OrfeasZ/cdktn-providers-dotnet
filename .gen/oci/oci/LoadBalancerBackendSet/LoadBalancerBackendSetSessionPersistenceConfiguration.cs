using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loadBalancerBackendSet.LoadBalancerBackendSetSessionPersistenceConfiguration")]
    public class LoadBalancerBackendSetSessionPersistenceConfiguration : oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSessionPersistenceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#cookie_name LoadBalancerBackendSet#cookie_name}.</summary>
        [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}")]
        public string CookieName
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
    }
}
