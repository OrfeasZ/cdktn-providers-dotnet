using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementFleetNotificationPreferences), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferences")]
    public interface IFleetAppsManagementFleetNotificationPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#compartment_id FleetAppsManagementFleet#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#topic_id FleetAppsManagementFleet#topic_id}.</summary>
        [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}")]
        string TopicId
        {
            get;
        }

        /// <summary>preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#preferences FleetAppsManagementFleet#preferences}
        /// </remarks>
        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesPreferences\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferencesPreferences? Preferences
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementFleetNotificationPreferences), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferences")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#compartment_id FleetAppsManagementFleet#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#topic_id FleetAppsManagementFleet#topic_id}.</summary>
            [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>preferences block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#preferences FleetAppsManagementFleet#preferences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesPreferences\"}", isOptional: true)]
            public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferencesPreferences? Preferences
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferencesPreferences?>();
            }
        }
    }
}
