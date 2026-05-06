using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerBackendsetA
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerBackendsetASslConfiguration), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetASslConfiguration")]
    public interface ILoadBalancerBackendsetASslConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#certificate_ids LoadBalancerBackendsetA#certificate_ids}.</summary>
        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CertificateIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#certificate_name LoadBalancerBackendsetA#certificate_name}.</summary>
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#cipher_suite_name LoadBalancerBackendsetA#cipher_suite_name}.</summary>
        [JsiiProperty(name: "cipherSuiteName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CipherSuiteName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#protocols LoadBalancerBackendsetA#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Protocols
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#server_order_preference LoadBalancerBackendsetA#server_order_preference}.</summary>
        [JsiiProperty(name: "serverOrderPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerOrderPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#trusted_certificate_authority_ids LoadBalancerBackendsetA#trusted_certificate_authority_ids}.</summary>
        [JsiiProperty(name: "trustedCertificateAuthorityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedCertificateAuthorityIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#verify_depth LoadBalancerBackendsetA#verify_depth}.</summary>
        [JsiiProperty(name: "verifyDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VerifyDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#verify_peer_certificate LoadBalancerBackendsetA#verify_peer_certificate}.</summary>
        [JsiiProperty(name: "verifyPeerCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerifyPeerCertificate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerBackendsetASslConfiguration), fullyQualifiedName: "oci.loadBalancerBackendsetA.LoadBalancerBackendsetASslConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerBackendsetA.ILoadBalancerBackendsetASslConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#certificate_ids LoadBalancerBackendsetA#certificate_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CertificateIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#certificate_name LoadBalancerBackendsetA#certificate_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#cipher_suite_name LoadBalancerBackendsetA#cipher_suite_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cipherSuiteName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CipherSuiteName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#protocols LoadBalancerBackendsetA#protocols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Protocols
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#server_order_preference LoadBalancerBackendsetA#server_order_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverOrderPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerOrderPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#trusted_certificate_authority_ids LoadBalancerBackendsetA#trusted_certificate_authority_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedCertificateAuthorityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedCertificateAuthorityIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#verify_depth LoadBalancerBackendsetA#verify_depth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifyDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VerifyDepth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_backendset#verify_peer_certificate LoadBalancerBackendsetA#verify_peer_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifyPeerCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? VerifyPeerCertificate
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
