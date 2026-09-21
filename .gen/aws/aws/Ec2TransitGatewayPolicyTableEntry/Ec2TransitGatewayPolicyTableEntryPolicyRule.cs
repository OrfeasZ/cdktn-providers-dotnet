using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayPolicyTableEntry
{
    [JsiiByValue(fqn: "aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRule")]
    public class Ec2TransitGatewayPolicyTableEntryPolicyRule : aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#destination_cidr_block Ec2TransitGatewayPolicyTableEntry#destination_cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationCidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#destination_port_range Ec2TransitGatewayPolicyTableEntry#destination_port_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPortRange
        {
            get;
            set;
        }

        private object? _metadata;

        /// <summary>metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#metadata Ec2TransitGatewayPolicyTableEntry#metadata}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRuleMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Metadata
        {
            get => _metadata;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metadata = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#protocol Ec2TransitGatewayPolicyTableEntry#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#source_cidr_block Ec2TransitGatewayPolicyTableEntry#source_cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceCidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#source_port_range Ec2TransitGatewayPolicyTableEntry#source_port_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourcePortRange
        {
            get;
            set;
        }
    }
}
