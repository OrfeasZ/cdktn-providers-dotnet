using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionTasksStepProperties), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepProperties")]
    public interface IFleetAppsManagementRunbookRunbookVersionTasksStepProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#action_on_failure FleetAppsManagementRunbook#action_on_failure}.</summary>
        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        string ActionOnFailure
        {
            get;
        }

        /// <summary>notification_preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#notification_preferences FleetAppsManagementRunbook#notification_preferences}
        /// </remarks>
        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesNotificationPreferences\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesNotificationPreferences? NotificationPreferences
        {
            get
            {
                return null;
            }
        }

        /// <summary>pause_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#pause_details FleetAppsManagementRunbook#pause_details}
        /// </remarks>
        [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails? PauseDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#pre_condition FleetAppsManagementRunbook#pre_condition}.</summary>
        [JsiiProperty(name: "preCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_on block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#run_on FleetAppsManagementRunbook#run_on}
        /// </remarks>
        [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOn? RunOn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionTasksStepProperties), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepProperties")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#action_on_failure FleetAppsManagementRunbook#action_on_failure}.</summary>
            [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionOnFailure
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>notification_preferences block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#notification_preferences FleetAppsManagementRunbook#notification_preferences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesNotificationPreferences\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesNotificationPreferences? NotificationPreferences
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesNotificationPreferences?>();
            }

            /// <summary>pause_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#pause_details FleetAppsManagementRunbook#pause_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails? PauseDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesPauseDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#pre_condition FleetAppsManagementRunbook#pre_condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreCondition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>run_on block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#run_on FleetAppsManagementRunbook#run_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOn\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOn? RunOn
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepPropertiesRunOn?>();
            }
        }
    }
}
