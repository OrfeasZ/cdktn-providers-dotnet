using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NatGateway
{
    [JsiiByValue(fqn: "aws.natGateway.NatGatewayAvailabilityZoneAddress")]
    public class NatGatewayAvailabilityZoneAddress : aws.NatGateway.INatGatewayAvailabilityZoneAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/nat_gateway#allocation_ids NatGateway#allocation_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllocationIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/nat_gateway#availability_zone NatGateway#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/nat_gateway#availability_zone_id NatGateway#availability_zone_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZoneId
        {
            get;
            set;
        }
    }
}
