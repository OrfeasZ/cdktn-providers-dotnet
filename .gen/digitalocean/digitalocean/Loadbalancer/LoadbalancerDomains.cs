using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.loadbalancer.LoadbalancerDomains")]
    public class LoadbalancerDomains : digitalocean.Loadbalancer.ILoadbalancerDomains
    {
        /// <summary>domain name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#name Loadbalancer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>name of certificate required for TLS handshaking.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#certificate_name Loadbalancer#certificate_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateName
        {
            get;
            set;
        }

        private object? _isManaged;

        /// <summary>flag indicating if domain is managed by DigitalOcean.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/loadbalancer#is_managed Loadbalancer#is_managed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isManaged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsManaged
        {
            get => _isManaged;
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
                _isManaged = value;
            }
        }
    }
}
