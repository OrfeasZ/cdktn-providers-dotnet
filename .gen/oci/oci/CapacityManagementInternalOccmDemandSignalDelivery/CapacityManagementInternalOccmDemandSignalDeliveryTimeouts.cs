using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementInternalOccmDemandSignalDelivery
{
    [JsiiByValue(fqn: "oci.capacityManagementInternalOccmDemandSignalDelivery.CapacityManagementInternalOccmDemandSignalDeliveryTimeouts")]
    public class CapacityManagementInternalOccmDemandSignalDeliveryTimeouts : oci.CapacityManagementInternalOccmDemandSignalDelivery.ICapacityManagementInternalOccmDemandSignalDeliveryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_internal_occm_demand_signal_delivery#create CapacityManagementInternalOccmDemandSignalDelivery#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_internal_occm_demand_signal_delivery#delete CapacityManagementInternalOccmDemandSignalDelivery#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_internal_occm_demand_signal_delivery#update CapacityManagementInternalOccmDemandSignalDelivery#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
