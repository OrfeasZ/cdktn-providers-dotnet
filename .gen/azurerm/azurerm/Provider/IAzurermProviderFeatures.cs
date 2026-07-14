using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeatures), fullyQualifiedName: "azurerm.provider.AzurermProviderFeatures")]
    public interface IAzurermProviderFeatures
    {
        /// <summary>api_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#api_management AzurermProvider#api_management}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesApiManagement" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "apiManagement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApiManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApiManagement
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#app_configuration AzurermProvider#app_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesAppConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "appConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesAppConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AppConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>application_insights block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#application_insights AzurermProvider#application_insights}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesApplicationInsights" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "applicationInsights", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApplicationInsights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplicationInsights
        {
            get
            {
                return null;
            }
        }

        /// <summary>cognitive_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#cognitive_account AzurermProvider#cognitive_account}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesCognitiveAccount" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cognitiveAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesCognitiveAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CognitiveAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>databricks_workspace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#databricks_workspace AzurermProvider#databricks_workspace}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesDatabricksWorkspace" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "databricksWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesDatabricksWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DatabricksWorkspace
        {
            get
            {
                return null;
            }
        }

        /// <summary>enhanced_validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#enhanced_validation AzurermProvider#enhanced_validation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesEnhancedValidation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "enhancedValidation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesEnhancedValidation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnhancedValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_vault block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#key_vault AzurermProvider#key_vault}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesKeyVault" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "keyVault", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesKeyVault\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeyVault
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_analytics_workspace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#log_analytics_workspace AzurermProvider#log_analytics_workspace}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesLogAnalyticsWorkspace" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogAnalyticsWorkspace
        {
            get
            {
                return null;
            }
        }

        /// <summary>machine_learning block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#machine_learning AzurermProvider#machine_learning}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesMachineLearning" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "machineLearning", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesMachineLearning\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MachineLearning
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#managed_disk AzurermProvider#managed_disk}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesManagedDisk" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "managedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesManagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>netapp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#netapp AzurermProvider#netapp}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesNetapp" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "netapp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesNetapp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Netapp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to set the resource ID into state before polling asynchronous operations for completion. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#persist_id_on_create_before_polling_for_completion AzurermProvider#persist_id_on_create_before_polling_for_completion}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "persistIdOnCreateBeforePollingForCompletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PersistIdOnCreateBeforePollingForCompletion
        {
            get
            {
                return null;
            }
        }

        /// <summary>postgresql_flexible_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#postgresql_flexible_server AzurermProvider#postgresql_flexible_server}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "postgresqlFlexibleServer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PostgresqlFlexibleServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>recovery_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#recovery_service AzurermProvider#recovery_service}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesRecoveryService" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "recoveryService", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoveryService
        {
            get
            {
                return null;
            }
        }

        /// <summary>recovery_services_vaults block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#recovery_services_vaults AzurermProvider#recovery_services_vaults}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "recoveryServicesVaults", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoveryServicesVaults
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#resource_group AzurermProvider#resource_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesResourceGroup" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesResourceGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>servicebus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#servicebus AzurermProvider#servicebus}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesServicebus" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "servicebus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesServicebus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Servicebus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to skip the import check and allow the provider to overwrite existing remote resources if present.</summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#skip_import_check_on_create_and_allow_overwriting_existing_resources AzurermProvider#skip_import_check_on_create_and_allow_overwriting_existing_resources}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "skipImportCheckOnCreateAndAllowOverwritingExistingResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipImportCheckOnCreateAndAllowOverwritingExistingResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#storage AzurermProvider#storage}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesStorage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Storage
        {
            get
            {
                return null;
            }
        }

        /// <summary>subscription block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#subscription AzurermProvider#subscription}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesSubscription" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "subscription", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Subscription
        {
            get
            {
                return null;
            }
        }

        /// <summary>template_deployment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#template_deployment AzurermProvider#template_deployment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "templateDeployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesTemplateDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TemplateDeployment
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_machine block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#virtual_machine AzurermProvider#virtual_machine}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesVirtualMachine" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "virtualMachine", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachine\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VirtualMachine
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_machine_scale_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#virtual_machine_scale_set AzurermProvider#virtual_machine_scale_set}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesVirtualMachineScaleSet" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachineScaleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VirtualMachineScaleSet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeatures), fullyQualifiedName: "azurerm.provider.AzurermProviderFeatures")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>api_management block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#api_management AzurermProvider#api_management}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesApiManagement" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiManagement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApiManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiManagement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>app_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#app_configuration AzurermProvider#app_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesAppConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesAppConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AppConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>application_insights block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#application_insights AzurermProvider#application_insights}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesApplicationInsights" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationInsights", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApplicationInsights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApplicationInsights
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cognitive_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#cognitive_account AzurermProvider#cognitive_account}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesCognitiveAccount" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitiveAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesCognitiveAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CognitiveAccount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>databricks_workspace block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#databricks_workspace AzurermProvider#databricks_workspace}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesDatabricksWorkspace" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databricksWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesDatabricksWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DatabricksWorkspace
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>enhanced_validation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#enhanced_validation AzurermProvider#enhanced_validation}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesEnhancedValidation" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enhancedValidation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesEnhancedValidation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EnhancedValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>key_vault block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#key_vault AzurermProvider#key_vault}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesKeyVault" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVault", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesKeyVault\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KeyVault
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_analytics_workspace block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#log_analytics_workspace AzurermProvider#log_analytics_workspace}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesLogAnalyticsWorkspace" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogAnalyticsWorkspace
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>machine_learning block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#machine_learning AzurermProvider#machine_learning}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesMachineLearning" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "machineLearning", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesMachineLearning\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MachineLearning
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>managed_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#managed_disk AzurermProvider#managed_disk}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesManagedDisk" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesManagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedDisk
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>netapp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#netapp AzurermProvider#netapp}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesNetapp" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "netapp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesNetapp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Netapp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to set the resource ID into state before polling asynchronous operations for completion. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#persist_id_on_create_before_polling_for_completion AzurermProvider#persist_id_on_create_before_polling_for_completion}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistIdOnCreateBeforePollingForCompletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PersistIdOnCreateBeforePollingForCompletion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>postgresql_flexible_server block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#postgresql_flexible_server AzurermProvider#postgresql_flexible_server}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postgresqlFlexibleServer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PostgresqlFlexibleServer
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>recovery_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#recovery_service AzurermProvider#recovery_service}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesRecoveryService" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryService", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecoveryService
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>recovery_services_vaults block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#recovery_services_vaults AzurermProvider#recovery_services_vaults}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryServicesVaults", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecoveryServicesVaults
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#resource_group AzurermProvider#resource_group}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesResourceGroup" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesResourceGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceGroup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>servicebus block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#servicebus AzurermProvider#servicebus}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesServicebus" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "servicebus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesServicebus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Servicebus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to skip the import check and allow the provider to overwrite existing remote resources if present.</summary>
            /// <remarks>
            /// Defaults to <c>false</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#skip_import_check_on_create_and_allow_overwriting_existing_resources AzurermProvider#skip_import_check_on_create_and_allow_overwriting_existing_resources}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipImportCheckOnCreateAndAllowOverwritingExistingResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SkipImportCheckOnCreateAndAllowOverwritingExistingResources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#storage AzurermProvider#storage}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesStorage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Storage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>subscription block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#subscription AzurermProvider#subscription}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesSubscription" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscription", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Subscription
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>template_deployment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#template_deployment AzurermProvider#template_deployment}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "templateDeployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesTemplateDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TemplateDeployment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>virtual_machine block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#virtual_machine AzurermProvider#virtual_machine}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesVirtualMachine" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualMachine", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachine\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VirtualMachine
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>virtual_machine_scale_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs#virtual_machine_scale_set AzurermProvider#virtual_machine_scale_set}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.Provider.IAzurermProviderFeaturesVirtualMachineScaleSet" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachineScaleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VirtualMachineScaleSet
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
