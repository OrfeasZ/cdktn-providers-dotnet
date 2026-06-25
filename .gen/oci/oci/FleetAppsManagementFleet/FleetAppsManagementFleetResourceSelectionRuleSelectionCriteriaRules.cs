using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRules")]
    public class FleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRules : oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_apps_management_fleet#basis FleetAppsManagementFleet#basis}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "basis", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Basis
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_apps_management_fleet#compartment_id FleetAppsManagementFleet#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        private object? _compartmentIdInSubtree;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_apps_management_fleet#compartment_id_in_subtree FleetAppsManagementFleet#compartment_id_in_subtree}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CompartmentIdInSubtree
        {
            get => _compartmentIdInSubtree;
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
                _compartmentIdInSubtree = value;
            }
        }

        private object? _conditions;

        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_apps_management_fleet#conditions FleetAppsManagementFleet#conditions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRulesConditions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRulesConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Conditions
        {
            get => _conditions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRulesConditions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetResourceSelectionRuleSelectionCriteriaRulesConditions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_apps_management_fleet#match_condition FleetAppsManagementFleet#match_condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchCondition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/fleet_apps_management_fleet#resource_compartment_id FleetAppsManagementFleet#resource_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceCompartmentId
        {
            get;
            set;
        }
    }
}
