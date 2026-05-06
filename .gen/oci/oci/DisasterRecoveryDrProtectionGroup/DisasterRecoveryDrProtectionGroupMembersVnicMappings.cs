using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiByValue(fqn: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersVnicMappings")]
    public class DisasterRecoveryDrProtectionGroupMembersVnicMappings : oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersVnicMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_nsg_id_list DisasterRecoveryDrProtectionGroup#destination_nsg_id_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationNsgIdList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DestinationNsgIdList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_primary_private_ip_address DisasterRecoveryDrProtectionGroup#destination_primary_private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPrimaryPrivateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPrimaryPrivateIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_primary_private_ip_hostname_label DisasterRecoveryDrProtectionGroup#destination_primary_private_ip_hostname_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPrimaryPrivateIpHostnameLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPrimaryPrivateIpHostnameLabel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_reserved_public_ip_id DisasterRecoveryDrProtectionGroup#destination_reserved_public_ip_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationReservedPublicIpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationReservedPublicIpId
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
