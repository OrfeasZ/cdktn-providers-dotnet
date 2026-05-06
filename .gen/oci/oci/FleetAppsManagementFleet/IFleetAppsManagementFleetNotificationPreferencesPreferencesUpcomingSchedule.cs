using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule")]
    public interface IFleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#notify_before FleetAppsManagementFleet#notify_before}.</summary>
        [JsiiProperty(name: "notifyBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotifyBefore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#on_upcoming_schedule FleetAppsManagementFleet#on_upcoming_schedule}.</summary>
        [JsiiProperty(name: "onUpcomingSchedule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnUpcomingSchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#notify_before FleetAppsManagementFleet#notify_before}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notifyBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotifyBefore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#on_upcoming_schedule FleetAppsManagementFleet#on_upcoming_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onUpcomingSchedule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OnUpcomingSchedule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
