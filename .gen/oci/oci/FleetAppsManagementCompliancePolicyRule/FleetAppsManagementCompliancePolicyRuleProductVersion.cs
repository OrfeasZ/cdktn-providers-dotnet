using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementCompliancePolicyRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetAppsManagementCompliancePolicyRule.FleetAppsManagementCompliancePolicyRuleProductVersion")]
    public class FleetAppsManagementCompliancePolicyRuleProductVersion : oci.FleetAppsManagementCompliancePolicyRule.IFleetAppsManagementCompliancePolicyRuleProductVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#version FleetAppsManagementCompliancePolicyRule#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        private object? _isApplicableForAllHigherVersions;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_compliance_policy_rule#is_applicable_for_all_higher_versions FleetAppsManagementCompliancePolicyRule#is_applicable_for_all_higher_versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isApplicableForAllHigherVersions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsApplicableForAllHigherVersions
        {
            get => _isApplicableForAllHigherVersions;
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
                _isApplicableForAllHigherVersions = value;
            }
        }
    }
}
