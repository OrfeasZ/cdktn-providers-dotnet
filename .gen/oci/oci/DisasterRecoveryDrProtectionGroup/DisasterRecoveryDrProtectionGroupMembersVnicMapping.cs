using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVnicMapping")]
    public class DisasterRecoveryDrProtectionGroupMembersVnicMapping : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVnicMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_nsg_id_list DisasterRecoveryDrProtectionGroup#destination_nsg_id_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationNsgIdList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DestinationNsgIdList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_subnet_id DisasterRecoveryDrProtectionGroup#destination_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_vnic_id DisasterRecoveryDrProtectionGroup#source_vnic_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVnicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceVnicId
        {
            get;
            set;
        }
    }
}
