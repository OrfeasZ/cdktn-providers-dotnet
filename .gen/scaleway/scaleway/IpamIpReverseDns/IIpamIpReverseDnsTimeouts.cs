using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IpamIpReverseDns
{
    [JsiiInterface(nativeType: typeof(IIpamIpReverseDnsTimeouts), fullyQualifiedName: "scaleway.ipamIpReverseDns.IpamIpReverseDnsTimeouts")]
    public interface IIpamIpReverseDnsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip_reverse_dns#create IpamIpReverseDns#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip_reverse_dns#default IpamIpReverseDns#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip_reverse_dns#update IpamIpReverseDns#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIpamIpReverseDnsTimeouts), fullyQualifiedName: "scaleway.ipamIpReverseDns.IpamIpReverseDnsTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.IpamIpReverseDns.IIpamIpReverseDnsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip_reverse_dns#create IpamIpReverseDns#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip_reverse_dns#default IpamIpReverseDns#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/ipam_ip_reverse_dns#update IpamIpReverseDns#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
