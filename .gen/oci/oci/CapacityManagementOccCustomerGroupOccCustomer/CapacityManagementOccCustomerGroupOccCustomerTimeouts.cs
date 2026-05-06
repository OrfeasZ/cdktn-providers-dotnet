using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccCustomerGroupOccCustomer
{
    [JsiiByValue(fqn: "oci.capacityManagementOccCustomerGroupOccCustomer.CapacityManagementOccCustomerGroupOccCustomerTimeouts")]
    public class CapacityManagementOccCustomerGroupOccCustomerTimeouts : oci.CapacityManagementOccCustomerGroupOccCustomer.ICapacityManagementOccCustomerGroupOccCustomerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#create CapacityManagementOccCustomerGroupOccCustomer#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#delete CapacityManagementOccCustomerGroupOccCustomer#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_customer_group_occ_customer#update CapacityManagementOccCustomerGroupOccCustomer#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
