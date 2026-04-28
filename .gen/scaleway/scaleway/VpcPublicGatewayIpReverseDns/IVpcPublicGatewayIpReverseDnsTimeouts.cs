using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPublicGatewayIpReverseDns
{
    [JsiiInterface(nativeType: typeof(IVpcPublicGatewayIpReverseDnsTimeouts), fullyQualifiedName: "scaleway.vpcPublicGatewayIpReverseDns.VpcPublicGatewayIpReverseDnsTimeouts")]
    public interface IVpcPublicGatewayIpReverseDnsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_public_gateway_ip_reverse_dns#create VpcPublicGatewayIpReverseDns#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_public_gateway_ip_reverse_dns#default VpcPublicGatewayIpReverseDns#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_public_gateway_ip_reverse_dns#update VpcPublicGatewayIpReverseDns#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPublicGatewayIpReverseDnsTimeouts), fullyQualifiedName: "scaleway.vpcPublicGatewayIpReverseDns.VpcPublicGatewayIpReverseDnsTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.VpcPublicGatewayIpReverseDns.IVpcPublicGatewayIpReverseDnsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_public_gateway_ip_reverse_dns#create VpcPublicGatewayIpReverseDns#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_public_gateway_ip_reverse_dns#default VpcPublicGatewayIpReverseDns#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_public_gateway_ip_reverse_dns#update VpcPublicGatewayIpReverseDns#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
