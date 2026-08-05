using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.Provider
{
    [JsiiByValue(fqn: "oci.provider.OciProviderConfig")]
    public class OciProviderConfig : oci.Provider.IOciProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#alias OciProvider#alias}
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
        /// Options are 'ApiKey', 'InstancePrincipal', 'InstancePrincipalWithCerts', 'SecurityToken', 'ResourcePrincipal', 'OKEWorkloadIdentity', 'WorkloadIdentityFederation'. By default, 'ApiKey' will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#auth OciProvider#auth}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#config_file_profile OciProvider#config_file_profile}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#disable_auto_retries OciProvider#disable_auto_retries}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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

        private object? _dualStackEndpointEnabled;

        /// <summary>(Optional) flags to enable Dual Stack endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#dual_stack_endpoint_enabled OciProvider#dual_stack_endpoint_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dualStackEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DualStackEndpointEnabled
        {
            get => _dualStackEndpointEnabled;
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
                _dualStackEndpointEnabled = value;
            }
        }

        /// <summary>(Optional) The fingerprint for the user's RSA key.</summary>
        /// <remarks>
        /// This can be found in user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#fingerprint OciProvider#fingerprint}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#ignore_defined_tags OciProvider#ignore_defined_tags}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#private_key OciProvider#private_key}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#private_key_password OciProvider#private_key_password}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#private_key_path OciProvider#private_key_path}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#realm_specific_service_endpoint_template_enabled OciProvider#realm_specific_service_endpoint_template_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#region OciProvider#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>(Optional) Config file which has the configuration for 4xx and 5xx retries in JSON format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#retries_config_file OciProvider#retries_config_file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retriesConfigFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetriesConfigFile
        {
            get;
            set;
        }

        /// <summary>(Optional) The minimum duration (in seconds) to retry a resource operation in response to an error.</summary>
        /// <remarks>
        /// The actual retry duration may be longer due to jittering of retry operations. This value is ignored if the <c>disable_auto_retries</c> field is set to true.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#retry_duration_seconds OciProvider#retry_duration_seconds}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#tenancy_ocid OciProvider#tenancy_ocid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenancyOcid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#test_time_maintenance_reboot_due OciProvider#test_time_maintenance_reboot_due}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testTimeMaintenanceRebootDue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestTimeMaintenanceRebootDue
        {
            get;
            set;
        }

        /// <summary>(Optional) Authentication method for the token-exchange client.</summary>
        /// <remarks>
        /// Valid values are 'OAuthClientCredentials' and 'InstancePrincipal'. Used only if auth is set to 'WorkloadIdentityFederation'. Defaults to 'OAuthClientCredentials'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_auth OciProvider#token_exchange_auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangeAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangeAuth
        {
            get;
            set;
        }

        /// <summary>(Optional) Token-exchange client ID. Required when auth is set to 'WorkloadIdentityFederation' and token_exchange_auth is 'OAuthClientCredentials', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_client_id OciProvider#token_exchange_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangeClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangeClientId
        {
            get;
            set;
        }

        /// <summary>(Optional) Token-exchange client secret. Required when auth is set to 'WorkloadIdentityFederation' and token_exchange_auth is 'OAuthClientCredentials', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_client_secret OciProvider#token_exchange_client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangeClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangeClientSecret
        {
            get;
            set;
        }

        /// <summary>(Optional) OCI IAM identity domain URL for token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_domain_url OciProvider#token_exchange_domain_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangeDomainUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangeDomainUrl
        {
            get;
            set;
        }

        /// <summary>(Optional) Public key used by the token-exchange flow, where applicable. Used only if auth is set to 'WorkloadIdentityFederation'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_public_key OciProvider#token_exchange_public_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangePublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangePublicKey
        {
            get;
            set;
        }

        /// <summary>(Optional) Requested token type for token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_requested_token_type OciProvider#token_exchange_requested_token_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangeRequestedTokenType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangeRequestedTokenType
        {
            get;
            set;
        }

        /// <summary>(Optional) Resource type used during token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_resource_type OciProvider#token_exchange_resource_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangeResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangeResourceType
        {
            get;
            set;
        }

        /// <summary>(Optional) Requested RPST expiration for token exchange. Used only if auth is set to 'WorkloadIdentityFederation'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_rpst_exp OciProvider#token_exchange_rpst_exp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangeRpstExp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangeRpstExp
        {
            get;
            set;
        }

        /// <summary>(Optional) Subject token type for the Kubernetes service account JWT. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#token_exchange_subject_token_type OciProvider#token_exchange_subject_token_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenExchangeSubjectTokenType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenExchangeSubjectTokenType
        {
            get;
            set;
        }

        /// <summary>(Optional) The user OCID.</summary>
        /// <remarks>
        /// This can be found in user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#user_ocid OciProvider#user_ocid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userOcid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserOcid
        {
            get;
            set;
        }

        /// <summary>(Optional) Path to the projected Kubernetes service account token. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs#workload_identity_token_path OciProvider#workload_identity_token_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workloadIdentityTokenPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkloadIdentityTokenPath
        {
            get;
            set;
        }
    }
}
