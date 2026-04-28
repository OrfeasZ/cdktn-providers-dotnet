using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.CockpitAlertManager
{
    [JsiiInterface(nativeType: typeof(ICockpitAlertManagerContactPoints), fullyQualifiedName: "scaleway.cockpitAlertManager.CockpitAlertManagerContactPoints")]
    public interface ICockpitAlertManagerContactPoints
    {
        /// <summary>Email addresses for the alert receivers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_alert_manager#email CockpitAlertManager#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICockpitAlertManagerContactPoints), fullyQualifiedName: "scaleway.cockpitAlertManager.CockpitAlertManagerContactPoints")]
        internal sealed class _Proxy : DeputyBase, scaleway.CockpitAlertManager.ICockpitAlertManagerContactPoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Email addresses for the alert receivers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/cockpit_alert_manager#email CockpitAlertManager#email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Email
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
