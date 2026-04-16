using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.CockpitAlertManager
{
    [JsiiByValue(fqn: "scaleway.cockpitAlertManager.CockpitAlertManagerContactPoints")]
    public class CockpitAlertManagerContactPoints : scaleway.CockpitAlertManager.ICockpitAlertManagerContactPoints
    {
        /// <summary>Email addresses for the alert receivers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/cockpit_alert_manager#email CockpitAlertManager#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }
    }
}
