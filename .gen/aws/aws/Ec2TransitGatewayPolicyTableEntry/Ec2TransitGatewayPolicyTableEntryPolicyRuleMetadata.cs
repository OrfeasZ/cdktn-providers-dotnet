using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayPolicyTableEntry
{
    [JsiiByValue(fqn: "aws.ec2TransitGatewayPolicyTableEntry.Ec2TransitGatewayPolicyTableEntryPolicyRuleMetadata")]
    public class Ec2TransitGatewayPolicyTableEntryPolicyRuleMetadata : aws.Ec2TransitGatewayPolicyTableEntry.IEc2TransitGatewayPolicyTableEntryPolicyRuleMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/ec2_transit_gateway_policy_table_entry#key Ec2TransitGatewayPolicyTableEntry#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.65.0/docs/resources/ec2_transit_gateway_policy_table_entry#value Ec2TransitGatewayPolicyTableEntry#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
