using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiInterface(nativeType: typeof(IDesktopsDesktopPoolAvailabilityPolicy), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicy")]
    public interface IDesktopsDesktopPoolAvailabilityPolicy
    {
        /// <summary>start_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#start_schedule DesktopsDesktopPool#start_schedule}
        /// </remarks>
        [JsiiProperty(name: "startSchedule", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStartSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStartSchedule? StartSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>stop_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#stop_schedule DesktopsDesktopPool#stop_schedule}
        /// </remarks>
        [JsiiProperty(name: "stopSchedule", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule? StopSchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDesktopsDesktopPoolAvailabilityPolicy), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>start_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#start_schedule DesktopsDesktopPool#start_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startSchedule", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStartSchedule\"}", isOptional: true)]
            public oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStartSchedule? StartSchedule
            {
                get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStartSchedule?>();
            }

            /// <summary>stop_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#stop_schedule DesktopsDesktopPool#stop_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stopSchedule", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopSchedule\"}", isOptional: true)]
            public oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule? StopSchedule
            {
                get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule?>();
            }
        }
    }
}
