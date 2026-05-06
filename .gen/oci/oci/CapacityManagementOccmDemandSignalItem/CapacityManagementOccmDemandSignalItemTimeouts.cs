using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccmDemandSignalItem
{
    [JsiiByValue(fqn: "oci.capacityManagementOccmDemandSignalItem.CapacityManagementOccmDemandSignalItemTimeouts")]
    public class CapacityManagementOccmDemandSignalItemTimeouts : oci.CapacityManagementOccmDemandSignalItem.ICapacityManagementOccmDemandSignalItemTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occm_demand_signal_item#create CapacityManagementOccmDemandSignalItem#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occm_demand_signal_item#delete CapacityManagementOccmDemandSignalItem#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occm_demand_signal_item#update CapacityManagementOccmDemandSignalItem#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
