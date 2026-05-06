using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule")]
    public class FleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule : oci.FleetAppsManagementFleet.IFleetAppsManagementFleetNotificationPreferencesPreferencesUpcomingSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#notify_before FleetAppsManagementFleet#notify_before}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notifyBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotifyBefore
        {
            get;
            set;
        }

        private object? _onUpcomingSchedule;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#on_upcoming_schedule FleetAppsManagementFleet#on_upcoming_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onUpcomingSchedule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OnUpcomingSchedule
        {
            get => _onUpcomingSchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _onUpcomingSchedule = value;
            }
        }
    }
}
