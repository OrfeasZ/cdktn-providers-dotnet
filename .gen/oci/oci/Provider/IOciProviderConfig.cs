using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.Provider
{
    [JsiiInterface(nativeType: typeof(IOciProviderConfig), fullyQualifiedName: "oci.provider.OciProviderConfig")]
    public interface IOciProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#alias OciProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) The type of auth to use.</summary>
        /// <remarks>
        /// Options are 'ApiKey', 'InstancePrincipal', 'InstancePrincipalWithCerts', 'SecurityToken', 'ResourcePrincipal', 'OKEWorkloadIdentity', 'WorkloadIdentityFederation'. By default, 'ApiKey' will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#auth OciProvider#auth}
        /// </remarks>
        [JsiiProperty(name: "auth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Auth
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) The profile name to be used from config file, if not set it will be DEFAULT.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#config_file_profile OciProvider#config_file_profile}
        /// </remarks>
        [JsiiProperty(name: "configFileProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigFileProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Disable automatic retries for retriable errors.</summary>
        /// <remarks>
        /// Automatic retries were introduced to solve some eventual consistency problems but it also introduced performance issues on destroy operations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#disable_auto_retries OciProvider#disable_auto_retries}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disableAutoRetries", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableAutoRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) flags to enable Dual Stack endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#dual_stack_endpoint_enabled OciProvider#dual_stack_endpoint_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "dualStackEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DualStackEndpointEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) The fingerprint for the user's RSA key.</summary>
        /// <remarks>
        /// This can be found in user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#fingerprint OciProvider#fingerprint}
        /// </remarks>
        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fingerprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) List of defined tags keys that Terraform should ignore when planning creates and updates to the associated remote object.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#ignore_defined_tags OciProvider#ignore_defined_tags}
        /// </remarks>
        [JsiiProperty(name: "ignoreDefinedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IgnoreDefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) A PEM formatted RSA private key for the user.</summary>
        /// <remarks>
        /// A private_key or a private_key_path must be provided if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#private_key OciProvider#private_key}
        /// </remarks>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) The password used to secure the private key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#private_key_password OciProvider#private_key_password}
        /// </remarks>
        [JsiiProperty(name: "privateKeyPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKeyPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) The path to the user's PEM formatted private key.</summary>
        /// <remarks>
        /// A private_key or a private_key_path must be provided if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#private_key_path OciProvider#private_key_path}
        /// </remarks>
        [JsiiProperty(name: "privateKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKeyPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) flags to enable realm specific service endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#realm_specific_service_endpoint_template_enabled OciProvider#realm_specific_service_endpoint_template_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "realmSpecificServiceEndpointTemplateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RealmSpecificServiceEndpointTemplateEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Required) The region for API connections (e.g. us-ashburn-1).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#region OciProvider#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Config file which has the configuration for 4xx and 5xx retries in JSON format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#retries_config_file OciProvider#retries_config_file}
        /// </remarks>
        [JsiiProperty(name: "retriesConfigFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetriesConfigFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) The minimum duration (in seconds) to retry a resource operation in response to an error.</summary>
        /// <remarks>
        /// The actual retry duration may be longer due to jittering of retry operations. This value is ignored if the <c>disable_auto_retries</c> field is set to true.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#retry_duration_seconds OciProvider#retry_duration_seconds}
        /// </remarks>
        [JsiiProperty(name: "retryDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryDurationSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) The tenancy OCID for a user.</summary>
        /// <remarks>
        /// The tenancy OCID can be found at the bottom of user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#tenancy_ocid OciProvider#tenancy_ocid}
        /// </remarks>
        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenancyOcid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#test_time_maintenance_reboot_due OciProvider#test_time_maintenance_reboot_due}.</summary>
        [JsiiProperty(name: "testTimeMaintenanceRebootDue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TestTimeMaintenanceRebootDue
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Authentication method for the token-exchange client.</summary>
        /// <remarks>
        /// Valid values are 'OAuthClientCredentials' and 'InstancePrincipal'. Used only if auth is set to 'WorkloadIdentityFederation'. Defaults to 'OAuthClientCredentials'.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_auth OciProvider#token_exchange_auth}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangeAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangeAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Token-exchange client ID. Required when auth is set to 'WorkloadIdentityFederation' and token_exchange_auth is 'OAuthClientCredentials', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_client_id OciProvider#token_exchange_client_id}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangeClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangeClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Token-exchange client secret. Required when auth is set to 'WorkloadIdentityFederation' and token_exchange_auth is 'OAuthClientCredentials', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_client_secret OciProvider#token_exchange_client_secret}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangeClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangeClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) OCI IAM identity domain URL for token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_domain_url OciProvider#token_exchange_domain_url}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangeDomainUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangeDomainUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Public key used by the token-exchange flow, where applicable. Used only if auth is set to 'WorkloadIdentityFederation'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_public_key OciProvider#token_exchange_public_key}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangePublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangePublicKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Requested token type for token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_requested_token_type OciProvider#token_exchange_requested_token_type}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangeRequestedTokenType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangeRequestedTokenType
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Resource type used during token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_resource_type OciProvider#token_exchange_resource_type}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangeResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangeResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Requested RPST expiration for token exchange. Used only if auth is set to 'WorkloadIdentityFederation'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_rpst_exp OciProvider#token_exchange_rpst_exp}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangeRpstExp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangeRpstExp
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Subject token type for the Kubernetes service account JWT. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_subject_token_type OciProvider#token_exchange_subject_token_type}
        /// </remarks>
        [JsiiProperty(name: "tokenExchangeSubjectTokenType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenExchangeSubjectTokenType
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) The user OCID.</summary>
        /// <remarks>
        /// This can be found in user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#user_ocid OciProvider#user_ocid}
        /// </remarks>
        [JsiiProperty(name: "userOcid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserOcid
        {
            get
            {
                return null;
            }
        }

        /// <summary>(Optional) Path to the projected Kubernetes service account token. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#workload_identity_token_path OciProvider#workload_identity_token_path}
        /// </remarks>
        [JsiiProperty(name: "workloadIdentityTokenPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkloadIdentityTokenPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOciProviderConfig), fullyQualifiedName: "oci.provider.OciProviderConfig")]
        internal sealed class _Proxy : DeputyBase, oci.Provider.IOciProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#alias OciProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) The type of auth to use.</summary>
            /// <remarks>
            /// Options are 'ApiKey', 'InstancePrincipal', 'InstancePrincipalWithCerts', 'SecurityToken', 'ResourcePrincipal', 'OKEWorkloadIdentity', 'WorkloadIdentityFederation'. By default, 'ApiKey' will be used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#auth OciProvider#auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Auth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) The profile name to be used from config file, if not set it will be DEFAULT.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#config_file_profile OciProvider#config_file_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configFileProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigFileProfile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Disable automatic retries for retriable errors.</summary>
            /// <remarks>
            /// Automatic retries were introduced to solve some eventual consistency problems but it also introduced performance issues on destroy operations.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#disable_auto_retries OciProvider#disable_auto_retries}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableAutoRetries", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableAutoRetries
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>(Optional) flags to enable Dual Stack endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#dual_stack_endpoint_enabled OciProvider#dual_stack_endpoint_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dualStackEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DualStackEndpointEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>(Optional) The fingerprint for the user's RSA key.</summary>
            /// <remarks>
            /// This can be found in user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#fingerprint OciProvider#fingerprint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fingerprint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) List of defined tags keys that Terraform should ignore when planning creates and updates to the associated remote object.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#ignore_defined_tags OciProvider#ignore_defined_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreDefinedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IgnoreDefinedTags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>(Optional) A PEM formatted RSA private key for the user.</summary>
            /// <remarks>
            /// A private_key or a private_key_path must be provided if auth is set to 'ApiKey', ignored otherwise.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#private_key OciProvider#private_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) The password used to secure the private key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#private_key_password OciProvider#private_key_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateKeyPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKeyPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) The path to the user's PEM formatted private key.</summary>
            /// <remarks>
            /// A private_key or a private_key_path must be provided if auth is set to 'ApiKey', ignored otherwise.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#private_key_path OciProvider#private_key_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKeyPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) flags to enable realm specific service endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#realm_specific_service_endpoint_template_enabled OciProvider#realm_specific_service_endpoint_template_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "realmSpecificServiceEndpointTemplateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RealmSpecificServiceEndpointTemplateEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>(Required) The region for API connections (e.g. us-ashburn-1).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#region OciProvider#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Config file which has the configuration for 4xx and 5xx retries in JSON format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#retries_config_file OciProvider#retries_config_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retriesConfigFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetriesConfigFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) The minimum duration (in seconds) to retry a resource operation in response to an error.</summary>
            /// <remarks>
            /// The actual retry duration may be longer due to jittering of retry operations. This value is ignored if the <c>disable_auto_retries</c> field is set to true.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#retry_duration_seconds OciProvider#retry_duration_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryDurationSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>(Optional) The tenancy OCID for a user.</summary>
            /// <remarks>
            /// The tenancy OCID can be found at the bottom of user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#tenancy_ocid OciProvider#tenancy_ocid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenancyOcid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#test_time_maintenance_reboot_due OciProvider#test_time_maintenance_reboot_due}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "testTimeMaintenanceRebootDue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TestTimeMaintenanceRebootDue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Authentication method for the token-exchange client.</summary>
            /// <remarks>
            /// Valid values are 'OAuthClientCredentials' and 'InstancePrincipal'. Used only if auth is set to 'WorkloadIdentityFederation'. Defaults to 'OAuthClientCredentials'.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_auth OciProvider#token_exchange_auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangeAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangeAuth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Token-exchange client ID. Required when auth is set to 'WorkloadIdentityFederation' and token_exchange_auth is 'OAuthClientCredentials', ignored otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_client_id OciProvider#token_exchange_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangeClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangeClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Token-exchange client secret. Required when auth is set to 'WorkloadIdentityFederation' and token_exchange_auth is 'OAuthClientCredentials', ignored otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_client_secret OciProvider#token_exchange_client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangeClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangeClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) OCI IAM identity domain URL for token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_domain_url OciProvider#token_exchange_domain_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangeDomainUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangeDomainUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Public key used by the token-exchange flow, where applicable. Used only if auth is set to 'WorkloadIdentityFederation'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_public_key OciProvider#token_exchange_public_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangePublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangePublicKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Requested token type for token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_requested_token_type OciProvider#token_exchange_requested_token_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangeRequestedTokenType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangeRequestedTokenType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Resource type used during token exchange. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_resource_type OciProvider#token_exchange_resource_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangeResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangeResourceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Requested RPST expiration for token exchange. Used only if auth is set to 'WorkloadIdentityFederation'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_rpst_exp OciProvider#token_exchange_rpst_exp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangeRpstExp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangeRpstExp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Subject token type for the Kubernetes service account JWT. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#token_exchange_subject_token_type OciProvider#token_exchange_subject_token_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenExchangeSubjectTokenType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenExchangeSubjectTokenType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) The user OCID.</summary>
            /// <remarks>
            /// This can be found in user settings in the Oracle Cloud Infrastructure console. Required if auth is set to 'ApiKey', ignored otherwise.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#user_ocid OciProvider#user_ocid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userOcid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserOcid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>(Optional) Path to the projected Kubernetes service account token. Required if auth is set to 'WorkloadIdentityFederation', ignored otherwise.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs#workload_identity_token_path OciProvider#workload_identity_token_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workloadIdentityTokenPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkloadIdentityTokenPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
