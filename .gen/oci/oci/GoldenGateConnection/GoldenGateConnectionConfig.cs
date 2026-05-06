using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateConnection.GoldenGateConnectionConfig")]
    public class GoldenGateConnectionConfig : oci.GoldenGateConnection.IGoldenGateConnectionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#compartment_id GoldenGateConnection#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#connection_type GoldenGateConnection#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#display_name GoldenGateConnection#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#technology_type GoldenGateConnection#technology_type}.</summary>
        [JsiiProperty(name: "technologyType", typeJson: "{\"primitive\":\"string\"}")]
        public string TechnologyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#access_key_id GoldenGateConnection#access_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#account_key GoldenGateConnection#account_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#account_key_secret_id GoldenGateConnection#account_key_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountKeySecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#account_name GoldenGateConnection#account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountName
        {
            get;
            set;
        }

        private object? _additionalAttributes;

        /// <summary>additional_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#additional_attributes GoldenGateConnection#additional_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionAdditionalAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalAttributes
        {
            get => _additionalAttributes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GoldenGateConnection.IGoldenGateConnectionAdditionalAttributes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GoldenGateConnection.IGoldenGateConnectionAdditionalAttributes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalAttributes = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#authentication_mode GoldenGateConnection#authentication_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#authentication_type GoldenGateConnection#authentication_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#azure_authority_host GoldenGateConnection#azure_authority_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureAuthorityHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzureAuthorityHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#azure_tenant_id GoldenGateConnection#azure_tenant_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzureTenantId
        {
            get;
            set;
        }

        private object? _bootstrapServers;

        /// <summary>bootstrap_servers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#bootstrap_servers GoldenGateConnection#bootstrap_servers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootstrapServers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionBootstrapServers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BootstrapServers
        {
            get => _bootstrapServers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GoldenGateConnection.IGoldenGateConnectionBootstrapServers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GoldenGateConnection.IGoldenGateConnectionBootstrapServers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bootstrapServers = value;
            }
        }

        /// <summary>catalog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#catalog GoldenGateConnection#catalog}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "catalog", typeJson: "{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionCatalog\"}", isOptional: true)]
        public oci.GoldenGateConnection.IGoldenGateConnectionCatalog? Catalog
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#client_id GoldenGateConnection#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#client_secret GoldenGateConnection#client_secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#client_secret_secret_id GoldenGateConnection#client_secret_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecretSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecretSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#cluster_id GoldenGateConnection#cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#cluster_placement_group_id GoldenGateConnection#cluster_placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterPlacementGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#connection_factory GoldenGateConnection#connection_factory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionFactory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionFactory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#connection_string GoldenGateConnection#connection_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#connection_url GoldenGateConnection#connection_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#consumer_properties GoldenGateConnection#consumer_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "consumerProperties", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConsumerProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#core_site_xml GoldenGateConnection#core_site_xml}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreSiteXml", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CoreSiteXml
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#database_id GoldenGateConnection#database_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#database_name GoldenGateConnection#database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#db_system_id GoldenGateConnection#db_system_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#defined_tags GoldenGateConnection#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#deployment_id GoldenGateConnection#deployment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeploymentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#description GoldenGateConnection#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _doesUseSecretIds;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#does_use_secret_ids GoldenGateConnection#does_use_secret_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "doesUseSecretIds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DoesUseSecretIds
        {
            get => _doesUseSecretIds;
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
                _doesUseSecretIds = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#endpoint GoldenGateConnection#endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#fingerprint GoldenGateConnection#fingerprint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fingerprint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#freeform_tags GoldenGateConnection#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#host GoldenGateConnection#host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#id GoldenGateConnection#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        private object? _isLockOverride;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#is_lock_override GoldenGateConnection#is_lock_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isLockOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsLockOverride
        {
            get => _isLockOverride;
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
                _isLockOverride = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#jndi_connection_factory GoldenGateConnection#jndi_connection_factory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jndiConnectionFactory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JndiConnectionFactory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#jndi_initial_context_factory GoldenGateConnection#jndi_initial_context_factory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jndiInitialContextFactory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JndiInitialContextFactory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#jndi_provider_url GoldenGateConnection#jndi_provider_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jndiProviderUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JndiProviderUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#jndi_security_credentials GoldenGateConnection#jndi_security_credentials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jndiSecurityCredentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JndiSecurityCredentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#jndi_security_credentials_secret_id GoldenGateConnection#jndi_security_credentials_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jndiSecurityCredentialsSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JndiSecurityCredentialsSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#jndi_security_principal GoldenGateConnection#jndi_security_principal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jndiSecurityPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JndiSecurityPrincipal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#key_id GoldenGateConnection#key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#key_store GoldenGateConnection#key_store}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyStore
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#key_store_password GoldenGateConnection#key_store_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyStorePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyStorePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#key_store_password_secret_id GoldenGateConnection#key_store_password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyStorePasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyStorePasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#key_store_secret_id GoldenGateConnection#key_store_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyStoreSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyStoreSecretId
        {
            get;
            set;
        }

        private object? _locks;

        /// <summary>locks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#locks GoldenGateConnection#locks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Locks
        {
            get => _locks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GoldenGateConnection.IGoldenGateConnectionLocks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GoldenGateConnection.IGoldenGateConnectionLocks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _locks = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#nsg_ids GoldenGateConnection#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#password GoldenGateConnection#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#password_secret_id GoldenGateConnection#password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#port GoldenGateConnection#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#private_ip GoldenGateConnection#private_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#private_key_file GoldenGateConnection#private_key_file}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateKeyFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKeyFile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#private_key_file_secret_id GoldenGateConnection#private_key_file_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateKeyFileSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKeyFileSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#private_key_passphrase GoldenGateConnection#private_key_passphrase}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateKeyPassphrase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKeyPassphrase
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#private_key_passphrase_secret_id GoldenGateConnection#private_key_passphrase_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateKeyPassphraseSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKeyPassphraseSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#producer_properties GoldenGateConnection#producer_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "producerProperties", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProducerProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#public_key_fingerprint GoldenGateConnection#public_key_fingerprint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicKeyFingerprint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#redis_cluster_id GoldenGateConnection#redis_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redisClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedisClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#region GoldenGateConnection#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#routing_method GoldenGateConnection#routing_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routingMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#sas_token GoldenGateConnection#sas_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sasToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SasToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#sas_token_secret_id GoldenGateConnection#sas_token_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sasTokenSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SasTokenSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#secret_access_key GoldenGateConnection#secret_access_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretAccessKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#secret_access_key_secret_id GoldenGateConnection#secret_access_key_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretAccessKeySecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#security_attributes GoldenGateConnection#security_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SecurityAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#security_protocol GoldenGateConnection#security_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#servers GoldenGateConnection#servers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "servers", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Servers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#service_account_key_file GoldenGateConnection#service_account_key_file}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountKeyFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccountKeyFile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#service_account_key_file_secret_id GoldenGateConnection#service_account_key_file_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountKeyFileSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccountKeyFileSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#session_mode GoldenGateConnection#session_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionMode
        {
            get;
            set;
        }

        private object? _shouldUseJndi;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#should_use_jndi GoldenGateConnection#should_use_jndi}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldUseJndi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldUseJndi
        {
            get => _shouldUseJndi;
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
                _shouldUseJndi = value;
            }
        }

        private object? _shouldUseResourcePrincipal;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#should_use_resource_principal GoldenGateConnection#should_use_resource_principal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldUseResourcePrincipal", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldUseResourcePrincipal
        {
            get => _shouldUseResourcePrincipal;
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
                _shouldUseResourcePrincipal = value;
            }
        }

        private object? _shouldValidateServerCertificate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#should_validate_server_certificate GoldenGateConnection#should_validate_server_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldValidateServerCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldValidateServerCertificate
        {
            get => _shouldValidateServerCertificate;
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
                _shouldValidateServerCertificate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_ca GoldenGateConnection#ssl_ca}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslCa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslCa
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_cert GoldenGateConnection#ssl_cert}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslCert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslCert
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_client_keystash GoldenGateConnection#ssl_client_keystash}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslClientKeystash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslClientKeystash
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_client_keystash_secret_id GoldenGateConnection#ssl_client_keystash_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslClientKeystashSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslClientKeystashSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_client_keystoredb GoldenGateConnection#ssl_client_keystoredb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslClientKeystoredb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslClientKeystoredb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_client_keystoredb_secret_id GoldenGateConnection#ssl_client_keystoredb_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslClientKeystoredbSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslClientKeystoredbSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_crl GoldenGateConnection#ssl_crl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslCrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslCrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_key GoldenGateConnection#ssl_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_key_password GoldenGateConnection#ssl_key_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslKeyPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslKeyPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_key_password_secret_id GoldenGateConnection#ssl_key_password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslKeyPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslKeyPasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_key_secret_id GoldenGateConnection#ssl_key_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslKeySecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslKeySecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_mode GoldenGateConnection#ssl_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#ssl_server_certificate GoldenGateConnection#ssl_server_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslServerCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslServerCertificate
        {
            get;
            set;
        }

        /// <summary>storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#storage GoldenGateConnection#storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionStorage\"}", isOptional: true)]
        public oci.GoldenGateConnection.IGoldenGateConnectionStorage? Storage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#storage_credential_name GoldenGateConnection#storage_credential_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageCredentialName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageCredentialName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#stream_pool_id GoldenGateConnection#stream_pool_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamPoolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamPoolId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#subnet_id GoldenGateConnection#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#subscription_id GoldenGateConnection#subscription_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubscriptionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#tenancy_id GoldenGateConnection#tenancy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenancyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#tenant_id GoldenGateConnection#tenant_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenantId
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#timeouts GoldenGateConnection#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionTimeouts\"}", isOptional: true)]
        public oci.GoldenGateConnection.IGoldenGateConnectionTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#tls_ca_file GoldenGateConnection#tls_ca_file}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsCaFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsCaFile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#tls_certificate_key_file GoldenGateConnection#tls_certificate_key_file}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsCertificateKeyFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsCertificateKeyFile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#tls_certificate_key_file_password GoldenGateConnection#tls_certificate_key_file_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsCertificateKeyFilePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsCertificateKeyFilePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#tls_certificate_key_file_password_secret_id GoldenGateConnection#tls_certificate_key_file_password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsCertificateKeyFilePasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsCertificateKeyFilePasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#tls_certificate_key_file_secret_id GoldenGateConnection#tls_certificate_key_file_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsCertificateKeyFileSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsCertificateKeyFileSecretId
        {
            get;
            set;
        }

        private object? _triggerRefresh;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#trigger_refresh GoldenGateConnection#trigger_refresh}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "triggerRefresh", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? TriggerRefresh
        {
            get => _triggerRefresh;
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
                _triggerRefresh = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#trust_store GoldenGateConnection#trust_store}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustStore
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#trust_store_password GoldenGateConnection#trust_store_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustStorePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustStorePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#trust_store_password_secret_id GoldenGateConnection#trust_store_password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustStorePasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustStorePasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#trust_store_secret_id GoldenGateConnection#trust_store_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustStoreSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustStoreSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#url GoldenGateConnection#url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#user_id GoldenGateConnection#user_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#username GoldenGateConnection#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#vault_id GoldenGateConnection#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#wallet GoldenGateConnection#wallet}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "wallet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Wallet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_connection#wallet_secret_id GoldenGateConnection#wallet_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "walletSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WalletSecretId
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
