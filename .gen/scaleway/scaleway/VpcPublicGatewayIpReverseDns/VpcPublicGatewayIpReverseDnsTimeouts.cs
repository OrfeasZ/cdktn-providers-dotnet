using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPublicGatewayIpReverseDns
{
    [JsiiByValue(fqn: "scaleway.vpcPublicGatewayIpReverseDns.VpcPublicGatewayIpReverseDnsTimeouts")]
    public class VpcPublicGatewayIpReverseDnsTimeouts : scaleway.VpcPublicGatewayIpReverseDns.IVpcPublicGatewayIpReverseDnsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_ip_reverse_dns#create VpcPublicGatewayIpReverseDns#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_ip_reverse_dns#default VpcPublicGatewayIpReverseDns#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_ip_reverse_dns#update VpcPublicGatewayIpReverseDns#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
