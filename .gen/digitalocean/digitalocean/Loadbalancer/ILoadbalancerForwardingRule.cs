using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    [JsiiInterface(nativeType: typeof(ILoadbalancerForwardingRule), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerForwardingRule")]
    public interface ILoadbalancerForwardingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#entry_port Loadbalancer#entry_port}.</summary>
        [JsiiProperty(name: "entryPort", typeJson: "{\"primitive\":\"number\"}")]
        double EntryPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#entry_protocol Loadbalancer#entry_protocol}.</summary>
        [JsiiProperty(name: "entryProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string EntryProtocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#target_port Loadbalancer#target_port}.</summary>
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        double TargetPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#target_protocol Loadbalancer#target_protocol}.</summary>
        [JsiiProperty(name: "targetProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string TargetProtocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#certificate_id Loadbalancer#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#certificate_name Loadbalancer#certificate_name}.</summary>
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#tls_passthrough Loadbalancer#tls_passthrough}.</summary>
        [JsiiProperty(name: "tlsPassthrough", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TlsPassthrough
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadbalancerForwardingRule), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerForwardingRule")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Loadbalancer.ILoadbalancerForwardingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#entry_port Loadbalancer#entry_port}.</summary>
            [JsiiProperty(name: "entryPort", typeJson: "{\"primitive\":\"number\"}")]
            public double EntryPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#entry_protocol Loadbalancer#entry_protocol}.</summary>
            [JsiiProperty(name: "entryProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string EntryProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#target_port Loadbalancer#target_port}.</summary>
            [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#target_protocol Loadbalancer#target_protocol}.</summary>
            [JsiiProperty(name: "targetProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#certificate_id Loadbalancer#certificate_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#certificate_name Loadbalancer#certificate_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/loadbalancer#tls_passthrough Loadbalancer#tls_passthrough}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsPassthrough", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? TlsPassthrough
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
