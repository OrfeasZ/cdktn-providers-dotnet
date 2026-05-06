using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleUpgradeDetails")]
    public class FleetSoftwareUpdateFsuCycleUpgradeDetails : oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleUpgradeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#collection_type FleetSoftwareUpdateFsuCycle#collection_type}.</summary>
        [JsiiProperty(name: "collectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string CollectionType
        {
            get;
            set;
        }

        private object? _isIgnorePostUpgradeErrors;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_ignore_post_upgrade_errors FleetSoftwareUpdateFsuCycle#is_ignore_post_upgrade_errors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isIgnorePostUpgradeErrors", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsIgnorePostUpgradeErrors
        {
            get => _isIgnorePostUpgradeErrors;
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
                _isIgnorePostUpgradeErrors = value;
            }
        }

        private object? _isIgnorePrerequisites;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_ignore_prerequisites FleetSoftwareUpdateFsuCycle#is_ignore_prerequisites}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isIgnorePrerequisites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsIgnorePrerequisites
        {
            get => _isIgnorePrerequisites;
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
                _isIgnorePrerequisites = value;
            }
        }

        private object? _isRecompileInvalidObjects;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_recompile_invalid_objects FleetSoftwareUpdateFsuCycle#is_recompile_invalid_objects}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isRecompileInvalidObjects", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRecompileInvalidObjects
        {
            get => _isRecompileInvalidObjects;
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
                _isRecompileInvalidObjects = value;
            }
        }

        private object? _isTimeZoneUpgrade;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#is_time_zone_upgrade FleetSoftwareUpdateFsuCycle#is_time_zone_upgrade}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isTimeZoneUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsTimeZoneUpgrade
        {
            get => _isTimeZoneUpgrade;
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
                _isTimeZoneUpgrade = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#max_drain_timeout_in_seconds FleetSoftwareUpdateFsuCycle#max_drain_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDrainTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDrainTimeoutInSeconds
        {
            get;
            set;
        }
    }
}
