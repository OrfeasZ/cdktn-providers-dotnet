using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccCapacityRequest
{
    [JsiiInterface(nativeType: typeof(ICapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct), fullyQualifiedName: "oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct")]
    public interface ICapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#handover_quantity CapacityManagementOccCapacityRequest#handover_quantity}.</summary>
        [JsiiProperty(name: "handoverQuantity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HandoverQuantity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#occ_handover_resource_block_id CapacityManagementOccCapacityRequest#occ_handover_resource_block_id}.</summary>
        [JsiiProperty(name: "occHandoverResourceBlockId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OccHandoverResourceBlockId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct), fullyQualifiedName: "oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#handover_quantity CapacityManagementOccCapacityRequest#handover_quantity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "handoverQuantity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HandoverQuantity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#occ_handover_resource_block_id CapacityManagementOccCapacityRequest#occ_handover_resource_block_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "occHandoverResourceBlockId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OccHandoverResourceBlockId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
