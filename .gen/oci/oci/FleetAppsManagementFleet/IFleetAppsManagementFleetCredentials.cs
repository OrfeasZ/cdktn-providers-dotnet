using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementFleetCredentials), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentials")]
    public interface IFleetAppsManagementFleetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#compartment_id FleetAppsManagementFleet#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#display_name FleetAppsManagementFleet#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>entity_specifics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#entity_specifics FleetAppsManagementFleet#entity_specifics}
        /// </remarks>
        [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecifics\"}")]
        oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics EntitySpecifics
        {
            get;
        }

        /// <summary>password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#password FleetAppsManagementFleet#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsPassword\"}")]
        oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsPassword Password
        {
            get;
        }

        /// <summary>user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#user FleetAppsManagementFleet#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsUser\"}")]
        oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsUser User
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementFleetCredentials), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentials
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#display_name FleetAppsManagementFleet#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>entity_specifics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#entity_specifics FleetAppsManagementFleet#entity_specifics}
            /// </remarks>
            [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecifics\"}")]
            public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics EntitySpecifics
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics>()!;
            }

            /// <summary>password block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#password FleetAppsManagementFleet#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsPassword\"}")]
            public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsPassword Password
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsPassword>()!;
            }

            /// <summary>user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#user FleetAppsManagementFleet#user}
            /// </remarks>
            [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsUser\"}")]
            public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsUser User
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsUser>()!;
            }
        }
    }
}
