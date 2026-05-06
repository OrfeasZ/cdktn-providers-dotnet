using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ComputeCloudAtCustomerCccUpgradeSchedule
{
    [JsiiByValue(fqn: "oci.computeCloudAtCustomerCccUpgradeSchedule.ComputeCloudAtCustomerCccUpgradeScheduleTimeouts")]
    public class ComputeCloudAtCustomerCccUpgradeScheduleTimeouts : oci.ComputeCloudAtCustomerCccUpgradeSchedule.IComputeCloudAtCustomerCccUpgradeScheduleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#create ComputeCloudAtCustomerCccUpgradeSchedule#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#delete ComputeCloudAtCustomerCccUpgradeSchedule#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/compute_cloud_at_customer_ccc_upgrade_schedule#update ComputeCloudAtCustomerCccUpgradeSchedule#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
