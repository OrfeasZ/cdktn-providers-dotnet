using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiInterface(nativeType: typeof(IDesktopsDesktopPoolSessionLifecycleActionsDisconnect), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect")]
    public interface IDesktopsDesktopPoolSessionLifecycleActionsDisconnect
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#action DesktopsDesktopPool#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#grace_period_in_minutes DesktopsDesktopPool#grace_period_in_minutes}.</summary>
        [JsiiProperty(name: "gracePeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GracePeriodInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDesktopsDesktopPoolSessionLifecycleActionsDisconnect), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect")]
        internal sealed class _Proxy : DeputyBase, oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#action DesktopsDesktopPool#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#grace_period_in_minutes DesktopsDesktopPool#grace_period_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gracePeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GracePeriodInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
