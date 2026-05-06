using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsAvailabilityConfig")]
    public class CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsAvailabilityConfig : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetailsAvailabilityConfig
    {
        private object? _isLiveMigrationPreferred;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_live_migration_preferred CoreInstanceConfiguration#is_live_migration_preferred}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isLiveMigrationPreferred", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsLiveMigrationPreferred
        {
            get => _isLiveMigrationPreferred;
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
                _isLiveMigrationPreferred = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#recovery_action CoreInstanceConfiguration#recovery_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecoveryAction
        {
            get;
            set;
        }
    }
}
