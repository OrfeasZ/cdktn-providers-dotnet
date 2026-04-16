using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.loadbalancer.LoadbalancerForwardingRule")]
    public class LoadbalancerForwardingRule : digitalocean.Loadbalancer.ILoadbalancerForwardingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#entry_port Loadbalancer#entry_port}.</summary>
        [JsiiProperty(name: "entryPort", typeJson: "{\"primitive\":\"number\"}")]
        public double EntryPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#entry_protocol Loadbalancer#entry_protocol}.</summary>
        [JsiiProperty(name: "entryProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string EntryProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#target_port Loadbalancer#target_port}.</summary>
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        public double TargetPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#target_protocol Loadbalancer#target_protocol}.</summary>
        [JsiiProperty(name: "targetProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#certificate_id Loadbalancer#certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#certificate_name Loadbalancer#certificate_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateName
        {
            get;
            set;
        }

        private object? _tlsPassthrough;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#tls_passthrough Loadbalancer#tls_passthrough}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsPassthrough", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? TlsPassthrough
        {
            get => _tlsPassthrough;
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
                _tlsPassthrough = value;
            }
        }
    }
}
