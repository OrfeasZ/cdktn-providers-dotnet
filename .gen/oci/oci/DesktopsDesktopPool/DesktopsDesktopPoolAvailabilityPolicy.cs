using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiByValue(fqn: "oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicy")]
    public class DesktopsDesktopPoolAvailabilityPolicy : oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicy
    {
        /// <summary>start_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#start_schedule DesktopsDesktopPool#start_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startSchedule", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStartSchedule\"}", isOptional: true)]
        public oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStartSchedule? StartSchedule
        {
            get;
            set;
        }

        /// <summary>stop_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#stop_schedule DesktopsDesktopPool#stop_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stopSchedule", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopSchedule\"}", isOptional: true)]
        public oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule? StopSchedule
        {
            get;
            set;
        }
    }
}
