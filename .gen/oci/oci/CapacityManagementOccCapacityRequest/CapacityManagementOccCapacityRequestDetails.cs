using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccCapacityRequest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestDetails")]
    public class CapacityManagementOccCapacityRequestDetails : oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#demand_quantity CapacityManagementOccCapacityRequest#demand_quantity}.</summary>
        [JsiiProperty(name: "demandQuantity", typeJson: "{\"primitive\":\"string\"}")]
        public string DemandQuantity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#resource_name CapacityManagementOccCapacityRequest#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#resource_type CapacityManagementOccCapacityRequest#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#workload_type CapacityManagementOccCapacityRequest#workload_type}.</summary>
        [JsiiProperty(name: "workloadType", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkloadType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#actual_handover_quantity CapacityManagementOccCapacityRequest#actual_handover_quantity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actualHandoverQuantity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActualHandoverQuantity
        {
            get;
            set;
        }

        private object? _associatedOccHandoverResourceBlockList;

        /// <summary>associated_occ_handover_resource_block_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#associated_occ_handover_resource_block_list CapacityManagementOccCapacityRequest#associated_occ_handover_resource_block_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "associatedOccHandoverResourceBlockList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AssociatedOccHandoverResourceBlockList
        {
            get => _associatedOccHandoverResourceBlockList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestDetailsAssociatedOccHandoverResourceBlockListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _associatedOccHandoverResourceBlockList = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#availability_domain CapacityManagementOccCapacityRequest#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#date_actual_handover CapacityManagementOccCapacityRequest#date_actual_handover}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dateActualHandover", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DateActualHandover
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#date_expected_handover CapacityManagementOccCapacityRequest#date_expected_handover}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dateExpectedHandover", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DateExpectedHandover
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#expected_handover_quantity CapacityManagementOccCapacityRequest#expected_handover_quantity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expectedHandoverQuantity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpectedHandoverQuantity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#source_workload_type CapacityManagementOccCapacityRequest#source_workload_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceWorkloadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceWorkloadType
        {
            get;
            set;
        }
    }
}
