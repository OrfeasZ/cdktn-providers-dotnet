using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicy")]
    public class CoreInstancePoolInstanceMaintenancePolicy : oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicy
    {
        /// <summary>launch_before_terminating block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#launch_before_terminating CoreInstancePool#launch_before_terminating}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchBeforeTerminating", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating\"}", isOptional: true)]
        public oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating? LaunchBeforeTerminating
        {
            get;
            set;
        }
    }
}
