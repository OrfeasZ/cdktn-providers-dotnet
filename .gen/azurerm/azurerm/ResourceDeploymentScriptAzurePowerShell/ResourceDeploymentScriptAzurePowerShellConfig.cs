using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceDeploymentScriptAzurePowerShell
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellConfig")]
    public class ResourceDeploymentScriptAzurePowerShellConfig : azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#location ResourceDeploymentScriptAzurePowerShell#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#name ResourceDeploymentScriptAzurePowerShell#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#resource_group_name ResourceDeploymentScriptAzurePowerShell#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#retention_interval ResourceDeploymentScriptAzurePowerShell#retention_interval}.</summary>
        [JsiiProperty(name: "retentionInterval", typeJson: "{\"primitive\":\"string\"}")]
        public string RetentionInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#version ResourceDeploymentScriptAzurePowerShell#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#cleanup_preference ResourceDeploymentScriptAzurePowerShell#cleanup_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cleanupPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CleanupPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#command_line ResourceDeploymentScriptAzurePowerShell#command_line}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commandLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommandLine
        {
            get;
            set;
        }

        /// <summary>container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#container ResourceDeploymentScriptAzurePowerShell#container}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "container", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellContainer\"}", isOptional: true)]
        public azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellContainer? Container
        {
            get;
            set;
        }

        private object? _environmentVariable;

        /// <summary>environment_variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#environment_variable ResourceDeploymentScriptAzurePowerShell#environment_variable}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellEnvironmentVariable" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellEnvironmentVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EnvironmentVariable
        {
            get => _environmentVariable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellEnvironmentVariable[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellEnvironmentVariable).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _environmentVariable = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#force_update_tag ResourceDeploymentScriptAzurePowerShell#force_update_tag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceUpdateTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForceUpdateTag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#id ResourceDeploymentScriptAzurePowerShell#id}.</summary>
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

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#identity ResourceDeploymentScriptAzurePowerShell#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellIdentity\"}", isOptional: true)]
        public azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellIdentity? Identity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#primary_script_uri ResourceDeploymentScriptAzurePowerShell#primary_script_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryScriptUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryScriptUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#script_content ResourceDeploymentScriptAzurePowerShell#script_content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scriptContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScriptContent
        {
            get;
            set;
        }

        /// <summary>storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#storage_account ResourceDeploymentScriptAzurePowerShell#storage_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellStorageAccount\"}", isOptional: true)]
        public azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellStorageAccount? StorageAccount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#supporting_script_uris ResourceDeploymentScriptAzurePowerShell#supporting_script_uris}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "supportingScriptUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SupportingScriptUris
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#tags ResourceDeploymentScriptAzurePowerShell#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#timeout ResourceDeploymentScriptAzurePowerShell#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timeout
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_deployment_script_azure_power_shell#timeouts ResourceDeploymentScriptAzurePowerShell#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellTimeouts\"}", isOptional: true)]
        public azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
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
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
