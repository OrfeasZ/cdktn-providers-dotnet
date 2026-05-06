using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiInterface(nativeType: typeof(IDesktopsDesktopPoolAvailabilityPolicyStopSchedule), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopSchedule")]
    public interface IDesktopsDesktopPoolAvailabilityPolicyStopSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#cron_expression DesktopsDesktopPool#cron_expression}.</summary>
        [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
        string CronExpression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#timezone DesktopsDesktopPool#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDesktopsDesktopPoolAvailabilityPolicyStopSchedule), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopSchedule")]
        internal sealed class _Proxy : DeputyBase, oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#cron_expression DesktopsDesktopPool#cron_expression}.</summary>
            [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string CronExpression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#timezone DesktopsDesktopPool#timezone}.</summary>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
