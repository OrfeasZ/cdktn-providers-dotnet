using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayPolicyTableEntry
{
    [JsiiInterface(nativeType: typeof(IEc2TransitGatewayPolicyTableEntryPolicyRule), fullyQualifiedName: "aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRule")]
    public interface IEc2TransitGatewayPolicyTableEntryPolicyRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#destination_cidr_block Ec2TransitGatewayPolicyTableEntry#destination_cidr_block}.</summary>
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationCidrBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#destination_port_range Ec2TransitGatewayPolicyTableEntry#destination_port_range}.</summary>
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationPortRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#metadata Ec2TransitGatewayPolicyTableEntry#metadata}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRuleMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#protocol Ec2TransitGatewayPolicyTableEntry#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#source_cidr_block Ec2TransitGatewayPolicyTableEntry#source_cidr_block}.</summary>
        [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceCidrBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#source_port_range Ec2TransitGatewayPolicyTableEntry#source_port_range}.</summary>
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourcePortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2TransitGatewayPolicyTableEntryPolicyRule), fullyQualifiedName: "aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRule")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#destination_cidr_block Ec2TransitGatewayPolicyTableEntry#destination_cidr_block}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationCidrBlock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#destination_port_range Ec2TransitGatewayPolicyTableEntry#destination_port_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPortRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationPortRange
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metadata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#metadata Ec2TransitGatewayPolicyTableEntry#metadata}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRuleMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Metadata
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#protocol Ec2TransitGatewayPolicyTableEntry#protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#source_cidr_block Ec2TransitGatewayPolicyTableEntry#source_cidr_block}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceCidrBlock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#source_port_range Ec2TransitGatewayPolicyTableEntry#source_port_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourcePortRange
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
