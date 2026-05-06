using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiByValue(fqn: "oci.goldenGateDeployment.GoldenGateDeploymentMaintenanceConfiguration")]
    public class GoldenGateDeploymentMaintenanceConfiguration : oci.GoldenGateDeployment.IGoldenGateDeploymentMaintenanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#bundle_release_upgrade_period_in_days GoldenGateDeployment#bundle_release_upgrade_period_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bundleReleaseUpgradePeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BundleReleaseUpgradePeriodInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#interim_release_upgrade_period_in_days GoldenGateDeployment#interim_release_upgrade_period_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interimReleaseUpgradePeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InterimReleaseUpgradePeriodInDays
        {
            get;
            set;
        }

        private object? _isInterimReleaseAutoUpgradeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#is_interim_release_auto_upgrade_enabled GoldenGateDeployment#is_interim_release_auto_upgrade_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isInterimReleaseAutoUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsInterimReleaseAutoUpgradeEnabled
        {
            get => _isInterimReleaseAutoUpgradeEnabled;
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
                _isInterimReleaseAutoUpgradeEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#major_release_upgrade_period_in_days GoldenGateDeployment#major_release_upgrade_period_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "majorReleaseUpgradePeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MajorReleaseUpgradePeriodInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#security_patch_upgrade_period_in_days GoldenGateDeployment#security_patch_upgrade_period_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityPatchUpgradePeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SecurityPatchUpgradePeriodInDays
        {
            get;
            set;
        }
    }
}
