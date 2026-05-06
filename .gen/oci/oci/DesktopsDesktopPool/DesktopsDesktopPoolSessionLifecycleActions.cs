using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiByValue(fqn: "oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActions")]
    public class DesktopsDesktopPoolSessionLifecycleActions : oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActions
    {
        /// <summary>disconnect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#disconnect DesktopsDesktopPool#disconnect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disconnect", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect\"}", isOptional: true)]
        public oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect? Disconnect
        {
            get;
            set;
        }

        /// <summary>inactivity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#inactivity DesktopsDesktopPool#inactivity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inactivity", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsInactivity\"}", isOptional: true)]
        public oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsInactivity? Inactivity
        {
            get;
            set;
        }
    }
}
