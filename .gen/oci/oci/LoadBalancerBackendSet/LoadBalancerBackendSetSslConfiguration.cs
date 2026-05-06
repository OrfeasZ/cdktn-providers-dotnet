using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendSet
{
    [JsiiByValue(fqn: "oci.loadBalancerBackendSet.LoadBalancerBackendSetSslConfiguration")]
    public class LoadBalancerBackendSetSslConfiguration : oci.LoadBalancerBackendSet.ILoadBalancerBackendSetSslConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#certificate_ids LoadBalancerBackendSet#certificate_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CertificateIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#certificate_name LoadBalancerBackendSet#certificate_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#cipher_suite_name LoadBalancerBackendSet#cipher_suite_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cipherSuiteName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CipherSuiteName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#protocols LoadBalancerBackendSet#protocols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Protocols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#server_order_preference LoadBalancerBackendSet#server_order_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverOrderPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerOrderPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#trusted_certificate_authority_ids LoadBalancerBackendSet#trusted_certificate_authority_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedCertificateAuthorityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedCertificateAuthorityIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#verify_depth LoadBalancerBackendSet#verify_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifyDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VerifyDepth
        {
            get;
            set;
        }

        private object? _verifyPeerCertificate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backend_set#verify_peer_certificate LoadBalancerBackendSet#verify_peer_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifyPeerCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? VerifyPeerCertificate
        {
            get => _verifyPeerCertificate;
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
                _verifyPeerCertificate = value;
            }
        }
    }
}
