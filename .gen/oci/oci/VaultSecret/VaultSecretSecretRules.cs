using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vaultSecret.VaultSecretSecretRules")]
    public class VaultSecretSecretRules : oci.VaultSecret.IVaultSecretSecretRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#rule_type VaultSecret#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleType
        {
            get;
            set;
        }

        private object? _isEnforcedOnDeletedSecretVersions;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#is_enforced_on_deleted_secret_versions VaultSecret#is_enforced_on_deleted_secret_versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEnforcedOnDeletedSecretVersions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnforcedOnDeletedSecretVersions
        {
            get => _isEnforcedOnDeletedSecretVersions;
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
                _isEnforcedOnDeletedSecretVersions = value;
            }
        }

        private object? _isSecretContentRetrievalBlockedOnExpiry;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#is_secret_content_retrieval_blocked_on_expiry VaultSecret#is_secret_content_retrieval_blocked_on_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSecretContentRetrievalBlockedOnExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSecretContentRetrievalBlockedOnExpiry
        {
            get => _isSecretContentRetrievalBlockedOnExpiry;
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
                _isSecretContentRetrievalBlockedOnExpiry = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#secret_version_expiry_interval VaultSecret#secret_version_expiry_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretVersionExpiryInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretVersionExpiryInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vault_secret#time_of_absolute_expiry VaultSecret#time_of_absolute_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfAbsoluteExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfAbsoluteExpiry
        {
            get;
            set;
        }
    }
}
