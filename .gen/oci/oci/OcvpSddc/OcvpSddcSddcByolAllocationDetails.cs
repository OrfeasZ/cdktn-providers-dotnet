using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiByValue(fqn: "oci.ocvpSddc.OcvpSddcSddcByolAllocationDetails")]
    public class OcvpSddcSddcByolAllocationDetails : oci.OcvpSddc.IOcvpSddcSddcByolAllocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ocvp_sddc#load_balancer_byol_allocation_id OcvpSddc#load_balancer_byol_allocation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancerByolAllocationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ocvp_sddc#load_balancer_instance_count OcvpSddc#load_balancer_instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoadBalancerInstanceCount
        {
            get;
            set;
        }
    }
}
