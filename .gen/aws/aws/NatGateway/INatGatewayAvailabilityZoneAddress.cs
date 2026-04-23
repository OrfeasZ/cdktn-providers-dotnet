using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NatGateway
{
    [JsiiInterface(nativeType: typeof(INatGatewayAvailabilityZoneAddress), fullyQualifiedName: "aws.natGateway.NatGatewayAvailabilityZoneAddress")]
    public interface INatGatewayAvailabilityZoneAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway#allocation_ids NatGateway#allocation_ids}.</summary>
        [JsiiProperty(name: "allocationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllocationIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway#availability_zone NatGateway#availability_zone}.</summary>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway#availability_zone_id NatGateway#availability_zone_id}.</summary>
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INatGatewayAvailabilityZoneAddress), fullyQualifiedName: "aws.natGateway.NatGatewayAvailabilityZoneAddress")]
        internal sealed class _Proxy : DeputyBase, aws.NatGateway.INatGatewayAvailabilityZoneAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway#allocation_ids NatGateway#allocation_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllocationIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway#availability_zone NatGateway#availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway#availability_zone_id NatGateway#availability_zone_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZoneId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
