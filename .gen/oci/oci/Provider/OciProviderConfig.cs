using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.Provider
{
    [JsiiByValue(fqn: "oci.provider.OciProviderConfig")]
    public class OciProviderConfig : oci.Provider.IOciProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#alias OciProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>(Optional) The type of auth to use.</summary>
        /// <remarks>
        /// Options are 'ApiKey', 'SecurityToken', 'InstancePrincipal', 'ResourcePrincipal' and 'OKEWorkloadIdentity'. By default, 'ApiKey' will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#auth OciProvider#auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Auth
        {
            get;
            set;
        }

        /// <summary>(Optional) The profile name to be used from config file, if not set it will be DEFAULT.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#config_file_profile OciProvider#config_file_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configFileProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigFileProfile
        {
            get;
            set;
        }

        private object? _disableAutoRetries;

        /// <summary>(Optional) Disable automatic retries for retriable errors.</summary>
        /// <remarks>
        /// Automatic retries were introduced to solve some eventual consistency problems but it also introduced performance issues on destroy operations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#disable_auto_retries OciProvider#disable_auto_retries}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disableAutoRetries", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableAutoRetries
        {
            get => _disableAutoRetries;
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
                _disableAutoRetries = value;
            }
        }

        /// <summary>(Optional) The fingerprint for the user's RSA key.</summary>
        /// <remarks>
        /// This can be found in user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#fingerprint OciProvider#fingerprint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fingerprint
        {
            get;
            set;
        }

        /// <summary>(Optional) List of defined tags keys that Terraform should ignore when planning creates and updates to the associated remote object.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#ignore_defined_tags OciProvider#ignore_defined_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreDefinedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IgnoreDefinedTags
        {
            get;
            set;
        }

        /// <summary>(Optional) A PEM formatted RSA private key for the user.</summary>
        /// <remarks>
        /// A private_key or a private_key_path must be provided if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#private_key OciProvider#private_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKey
        {
            get;
            set;
        }

        /// <summary>(Optional) The password used to secure the private key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#private_key_password OciProvider#private_key_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateKeyPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKeyPassword
        {
            get;
            set;
        }

        /// <summary>(Optional) The path to the user's PEM formatted private key.</summary>
        /// <remarks>
        /// A private_key or a private_key_path must be provided if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#private_key_path OciProvider#private_key_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKeyPath
        {
            get;
            set;
        }

        private object? _realmSpecificServiceEndpointTemplateEnabled;

        /// <summary>(Optional) flags to enable realm specific service endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#realm_specific_service_endpoint_template_enabled OciProvider#realm_specific_service_endpoint_template_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "realmSpecificServiceEndpointTemplateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RealmSpecificServiceEndpointTemplateEnabled
        {
            get => _realmSpecificServiceEndpointTemplateEnabled;
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
                _realmSpecificServiceEndpointTemplateEnabled = value;
            }
        }

        /// <summary>(Required) The region for API connections (e.g. us-ashburn-1).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#region OciProvider#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>(Optional) The minimum duration (in seconds) to retry a resource operation in response to an error.</summary>
        /// <remarks>
        /// The actual retry duration may be longer due to jittering of retry operations. This value is ignored if the <c>disable_auto_retries</c> field is set to true.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#retry_duration_seconds OciProvider#retry_duration_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryDurationSeconds
        {
            get;
            set;
        }

        /// <summary>(Optional) The tenancy OCID for a user.</summary>
        /// <remarks>
        /// The tenancy OCID can be found at the bottom of user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#tenancy_ocid OciProvider#tenancy_ocid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenancyOcid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#test_time_maintenance_reboot_due OciProvider#test_time_maintenance_reboot_due}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testTimeMaintenanceRebootDue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestTimeMaintenanceRebootDue
        {
            get;
            set;
        }

        /// <summary>(Optional) The user OCID.</summary>
        /// <remarks>
        /// This can be found in user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs#user_ocid OciProvider#user_ocid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userOcid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserOcid
        {
            get;
            set;
        }
    }
}
