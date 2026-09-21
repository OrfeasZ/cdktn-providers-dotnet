using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayPolicyTableEntry
{
    [JsiiInterface(nativeType: typeof(IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata), fullyQualifiedName: "aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRuleMetadata")]
    public interface IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#key Ec2TransitGatewayPolicyTableEntry#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#value Ec2TransitGatewayPolicyTableEntry#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata), fullyQualifiedName: "aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRuleMetadata")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#key Ec2TransitGatewayPolicyTableEntry#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/ec2_transit_gateway_policy_table_entry#value Ec2TransitGatewayPolicyTableEntry#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
