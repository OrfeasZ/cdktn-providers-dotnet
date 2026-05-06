using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccCapacityRequest
{
    [JsiiByValue(fqn: "oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct")]
    public class CapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct : oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#handover_quantity CapacityManagementOccCapacityRequest#handover_quantity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "handoverQuantity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HandoverQuantity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#occ_handover_resource_block_id CapacityManagementOccCapacityRequest#occ_handover_resource_block_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "occHandoverResourceBlockId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OccHandoverResourceBlockId
        {
            get;
            set;
        }
    }
}
