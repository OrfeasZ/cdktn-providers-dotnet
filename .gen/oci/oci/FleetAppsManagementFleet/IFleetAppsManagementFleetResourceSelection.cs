using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementFleetResourceSelection), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelection")]
    public interface IFleetAppsManagementFleetResourceSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#resource_selection_type FleetAppsManagementFleet#resource_selection_type}.</summary>
        [JsiiProperty(name: "resourceSelectionType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceSelectionType
        {
            get;
        }

        /// <summary>rule_selection_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#rule_selection_criteria FleetAppsManagementFleet#rule_selection_criteria}
        /// </remarks>
        [JsiiProperty(name: "ruleSelectionCriteria", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteria\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteria? RuleSelectionCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementFleetResourceSelection), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelection")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#resource_selection_type FleetAppsManagementFleet#resource_selection_type}.</summary>
            [JsiiProperty(name: "resourceSelectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceSelectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rule_selection_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet#rule_selection_criteria FleetAppsManagementFleet#rule_selection_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleSelectionCriteria", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteria\"}", isOptional: true)]
            public oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteria? RuleSelectionCriteria
            {
                get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteria?>();
            }
        }
    }
}
