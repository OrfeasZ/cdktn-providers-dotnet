using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcGatewayNetwork
{
    [JsiiByValue(fqn: "scaleway.vpcGatewayNetwork.VpcGatewayNetworkTimeouts")]
    public class VpcGatewayNetworkTimeouts : scaleway.VpcGatewayNetwork.IVpcGatewayNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_gateway_network#create VpcGatewayNetwork#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_gateway_network#default VpcGatewayNetwork#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_gateway_network#delete VpcGatewayNetwork#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_gateway_network#read VpcGatewayNetwork#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_gateway_network#update VpcGatewayNetwork#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
