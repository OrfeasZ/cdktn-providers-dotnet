using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiInterface(nativeType: typeof(IDesktopsDesktopPoolSessionLifecycleActions), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActions")]
    public interface IDesktopsDesktopPoolSessionLifecycleActions
    {
        /// <summary>disconnect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#disconnect DesktopsDesktopPool#disconnect}
        /// </remarks>
        [JsiiProperty(name: "disconnect", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect? Disconnect
        {
            get
            {
                return null;
            }
        }

        /// <summary>inactivity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#inactivity DesktopsDesktopPool#inactivity}
        /// </remarks>
        [JsiiProperty(name: "inactivity", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsInactivity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsInactivity? Inactivity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDesktopsDesktopPoolSessionLifecycleActions), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActions")]
        internal sealed class _Proxy : DeputyBase, oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>disconnect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#disconnect DesktopsDesktopPool#disconnect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disconnect", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect\"}", isOptional: true)]
            public oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect? Disconnect
            {
                get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect?>();
            }

            /// <summary>inactivity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#inactivity DesktopsDesktopPool#inactivity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inactivity", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsInactivity\"}", isOptional: true)]
            public oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsInactivity? Inactivity
            {
                get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsInactivity?>();
            }
        }
    }
}
