using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiByValue(fqn: "azurerm.provider.AzurermProviderFeatures")]
    public class AzurermProviderFeatures : azurerm.Provider.IAzurermProviderFeatures
    {
        private object? _apiManagement;

        /// <summary>api_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#api_management AzurermProvider#api_management}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesApiManagement" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiManagement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApiManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApiManagement
        {
            get => _apiManagement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesApiManagement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesApiManagement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _apiManagement = value;
            }
        }

        private object? _appConfiguration;

        /// <summary>app_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#app_configuration AzurermProvider#app_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesAppConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesAppConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AppConfiguration
        {
            get => _appConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesAppConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesAppConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _appConfiguration = value;
            }
        }

        private object? _applicationInsights;

        /// <summary>application_insights block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#application_insights AzurermProvider#application_insights}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesApplicationInsights" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationInsights", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApplicationInsights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApplicationInsights
        {
            get => _applicationInsights;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesApplicationInsights[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesApplicationInsights).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _applicationInsights = value;
            }
        }

        private object? _cognitiveAccount;

        /// <summary>cognitive_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#cognitive_account AzurermProvider#cognitive_account}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesCognitiveAccount" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitiveAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesCognitiveAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CognitiveAccount
        {
            get => _cognitiveAccount;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesCognitiveAccount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesCognitiveAccount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cognitiveAccount = value;
            }
        }

        private object? _databricksWorkspace;

        /// <summary>databricks_workspace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#databricks_workspace AzurermProvider#databricks_workspace}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesDatabricksWorkspace" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databricksWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesDatabricksWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DatabricksWorkspace
        {
            get => _databricksWorkspace;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesDatabricksWorkspace[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesDatabricksWorkspace).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _databricksWorkspace = value;
            }
        }

        private object? _enhancedValidation;

        /// <summary>enhanced_validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#enhanced_validation AzurermProvider#enhanced_validation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesEnhancedValidation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enhancedValidation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesEnhancedValidation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EnhancedValidation
        {
            get => _enhancedValidation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesEnhancedValidation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesEnhancedValidation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enhancedValidation = value;
            }
        }

        private object? _keyVault;

        /// <summary>key_vault block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#key_vault AzurermProvider#key_vault}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesKeyVault" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyVault", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesKeyVault\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KeyVault
        {
            get => _keyVault;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesKeyVault[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesKeyVault).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keyVault = value;
            }
        }

        private object? _logAnalyticsWorkspace;

        /// <summary>log_analytics_workspace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#log_analytics_workspace AzurermProvider#log_analytics_workspace}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesLogAnalyticsWorkspace" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogAnalyticsWorkspace
        {
            get => _logAnalyticsWorkspace;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesLogAnalyticsWorkspace[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesLogAnalyticsWorkspace).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logAnalyticsWorkspace = value;
            }
        }

        private object? _machineLearning;

        /// <summary>machine_learning block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#machine_learning AzurermProvider#machine_learning}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesMachineLearning" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "machineLearning", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesMachineLearning\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MachineLearning
        {
            get => _machineLearning;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesMachineLearning[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesMachineLearning).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _machineLearning = value;
            }
        }

        private object? _managedDisk;

        /// <summary>managed_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#managed_disk AzurermProvider#managed_disk}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesManagedDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesManagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ManagedDisk
        {
            get => _managedDisk;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesManagedDisk[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesManagedDisk).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedDisk = value;
            }
        }

        private object? _netapp;

        /// <summary>netapp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#netapp AzurermProvider#netapp}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesNetapp" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "netapp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesNetapp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Netapp
        {
            get => _netapp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesNetapp[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesNetapp).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _netapp = value;
            }
        }

        private object? _persistIdOnCreateBeforePollingForCompletion;

        /// <summary>Whether to set the resource ID into state before polling asynchronous operations for completion. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#persist_id_on_create_before_polling_for_completion AzurermProvider#persist_id_on_create_before_polling_for_completion}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "persistIdOnCreateBeforePollingForCompletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PersistIdOnCreateBeforePollingForCompletion
        {
            get => _persistIdOnCreateBeforePollingForCompletion;
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
                _persistIdOnCreateBeforePollingForCompletion = value;
            }
        }

        private object? _postgresqlFlexibleServer;

        /// <summary>postgresql_flexible_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#postgresql_flexible_server AzurermProvider#postgresql_flexible_server}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postgresqlFlexibleServer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PostgresqlFlexibleServer
        {
            get => _postgresqlFlexibleServer;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _postgresqlFlexibleServer = value;
            }
        }

        private object? _recoveryService;

        /// <summary>recovery_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#recovery_service AzurermProvider#recovery_service}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesRecoveryService" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryService", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RecoveryService
        {
            get => _recoveryService;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesRecoveryService[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesRecoveryService).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _recoveryService = value;
            }
        }

        private object? _recoveryServicesVaults;

        /// <summary>recovery_services_vaults block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#recovery_services_vaults AzurermProvider#recovery_services_vaults}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryServicesVaults", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RecoveryServicesVaults
        {
            get => _recoveryServicesVaults;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _recoveryServicesVaults = value;
            }
        }

        private object? _resourceGroup;

        /// <summary>resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#resource_group AzurermProvider#resource_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesResourceGroup" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesResourceGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceGroup
        {
            get => _resourceGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesResourceGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesResourceGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceGroup = value;
            }
        }

        private object? _servicebus;

        /// <summary>servicebus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#servicebus AzurermProvider#servicebus}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesServicebus" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "servicebus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesServicebus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Servicebus
        {
            get => _servicebus;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesServicebus[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesServicebus).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _servicebus = value;
            }
        }

        private object? _skipImportCheckOnCreateAndAllowOverwritingExistingResources;

        /// <summary>Whether to skip the import check and allow the provider to overwrite existing remote resources if present.</summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#skip_import_check_on_create_and_allow_overwriting_existing_resources AzurermProvider#skip_import_check_on_create_and_allow_overwriting_existing_resources}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skipImportCheckOnCreateAndAllowOverwritingExistingResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SkipImportCheckOnCreateAndAllowOverwritingExistingResources
        {
            get => _skipImportCheckOnCreateAndAllowOverwritingExistingResources;
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
                _skipImportCheckOnCreateAndAllowOverwritingExistingResources = value;
            }
        }

        private object? _storage;

        /// <summary>storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#storage AzurermProvider#storage}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesStorage" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Storage
        {
            get => _storage;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesStorage[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesStorage).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _storage = value;
            }
        }

        private object? _subscription;

        /// <summary>subscription block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#subscription AzurermProvider#subscription}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesSubscription" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscription", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Subscription
        {
            get => _subscription;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesSubscription[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesSubscription).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subscription = value;
            }
        }

        private object? _templateDeployment;

        /// <summary>template_deployment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#template_deployment AzurermProvider#template_deployment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateDeployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesTemplateDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TemplateDeployment
        {
            get => _templateDeployment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _templateDeployment = value;
            }
        }

        private object? _virtualMachine;

        /// <summary>virtual_machine block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#virtual_machine AzurermProvider#virtual_machine}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesVirtualMachine" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachine", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachine\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualMachine
        {
            get => _virtualMachine;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesVirtualMachine[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesVirtualMachine).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualMachine = value;
            }
        }

        private object? _virtualMachineScaleSet;

        /// <summary>virtual_machine_scale_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs#virtual_machine_scale_set AzurermProvider#virtual_machine_scale_set}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesVirtualMachineScaleSet" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachineScaleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualMachineScaleSet
        {
            get => _virtualMachineScaleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesVirtualMachineScaleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesVirtualMachineScaleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualMachineScaleSet = value;
            }
        }
    }
}
