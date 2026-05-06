using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksStepProperties), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepProperties")]
    public interface IFleetAppsManagementRunbookVersionTasksStepProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#action_on_failure FleetAppsManagementRunbookVersion#action_on_failure}.</summary>
        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        string ActionOnFailure
        {
            get;
        }

        /// <summary>notification_preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#notification_preferences FleetAppsManagementRunbookVersion#notification_preferences}
        /// </remarks>
        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences? NotificationPreferences
        {
            get
            {
                return null;
            }
        }

        /// <summary>pause_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#pause_details FleetAppsManagementRunbookVersion#pause_details}
        /// </remarks>
        [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails? PauseDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#pre_condition FleetAppsManagementRunbookVersion#pre_condition}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#run_on FleetAppsManagementRunbookVersion#run_on}
        /// </remarks>
        [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOn? RunOn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksStepProperties), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepProperties")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#action_on_failure FleetAppsManagementRunbookVersion#action_on_failure}.</summary>
            [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionOnFailure
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>notification_preferences block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#notification_preferences FleetAppsManagementRunbookVersion#notification_preferences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences? NotificationPreferences
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences?>();
            }

            /// <summary>pause_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#pause_details FleetAppsManagementRunbookVersion#pause_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails? PauseDetails
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesPauseDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#pre_condition FleetAppsManagementRunbookVersion#pre_condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreCondition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>run_on block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#run_on FleetAppsManagementRunbookVersion#run_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesRunOn\"}", isOptional: true)]
            public oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOn? RunOn
            {
                get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesRunOn?>();
            }
        }
    }
}
