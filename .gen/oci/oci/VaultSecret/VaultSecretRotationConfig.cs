using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vaultSecret.VaultSecretRotationConfig")]
    public class VaultSecretRotationConfig : oci.VaultSecret.IVaultSecretRotationConfig
    {
        /// <summary>target_system_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#target_system_details VaultSecret#target_system_details}
        /// </remarks>
        [JsiiProperty(name: "targetSystemDetails", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetails\"}")]
        public oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails TargetSystemDetails
        {
            get;
            set;
        }

        private object? _isScheduledRotationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#is_scheduled_rotation_enabled VaultSecret#is_scheduled_rotation_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isScheduledRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsScheduledRotationEnabled
        {
            get => _isScheduledRotationEnabled;
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
                _isScheduledRotationEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#rotation_interval VaultSecret#rotation_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rotationInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RotationInterval
        {
            get;
            set;
        }
    }
}
