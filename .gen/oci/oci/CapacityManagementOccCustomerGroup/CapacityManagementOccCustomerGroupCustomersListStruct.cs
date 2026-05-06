using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccCustomerGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.capacityManagementOccCustomerGroup.CapacityManagementOccCustomerGroupCustomersListStruct")]
    public class CapacityManagementOccCustomerGroupCustomersListStruct : oci.CapacityManagementOccCustomerGroup.ICapacityManagementOccCustomerGroupCustomersListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group#display_name CapacityManagementOccCustomerGroup#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group#tenancy_id CapacityManagementOccCustomerGroup#tenancy_id}.</summary>
        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public string TenancyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group#description CapacityManagementOccCustomerGroup#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group#status CapacityManagementOccCustomerGroup#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
