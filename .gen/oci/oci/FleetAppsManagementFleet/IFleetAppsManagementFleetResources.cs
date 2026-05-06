using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementFleetResources), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetResources")]
    public interface IFleetAppsManagementFleetResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#compartment_id FleetAppsManagementFleet#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#resource_id FleetAppsManagementFleet#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#tenancy_id FleetAppsManagementFleet#tenancy_id}.</summary>
        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        string TenancyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#fleet_resource_type FleetAppsManagementFleet#fleet_resource_type}.</summary>
        [JsiiProperty(name: "fleetResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FleetResourceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementFleetResources), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetResources")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResources
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#resource_id FleetAppsManagementFleet#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#tenancy_id FleetAppsManagementFleet#tenancy_id}.</summary>
            [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
            public string TenancyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#fleet_resource_type FleetAppsManagementFleet#fleet_resource_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fleetResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FleetResourceType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
