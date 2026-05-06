using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect")]
    public class DesktopsDesktopPoolSessionLifecycleActionsDisconnect : oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#action DesktopsDesktopPool#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#grace_period_in_minutes DesktopsDesktopPool#grace_period_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gracePeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GracePeriodInMinutes
        {
            get;
            set;
        }
    }
}
