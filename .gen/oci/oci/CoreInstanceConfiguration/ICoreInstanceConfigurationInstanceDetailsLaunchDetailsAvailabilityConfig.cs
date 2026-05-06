using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig")]
    public interface ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_live_migration_preferred CoreInstanceConfiguration#is_live_migration_preferred}.</summary>
        [JsiiProperty(name: "isLiveMigrationPreferred", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLiveMigrationPreferred
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#recovery_action CoreInstanceConfiguration#recovery_action}.</summary>
        [JsiiProperty(name: "recoveryAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecoveryAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsLaunchDetailsAvailabilityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#is_live_migration_preferred CoreInstanceConfiguration#is_live_migration_preferred}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isLiveMigrationPreferred", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLiveMigrationPreferred
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#recovery_action CoreInstanceConfiguration#recovery_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecoveryAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
