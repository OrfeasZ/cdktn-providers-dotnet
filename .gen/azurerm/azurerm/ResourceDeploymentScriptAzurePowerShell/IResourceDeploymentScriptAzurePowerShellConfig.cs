using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceDeploymentScriptAzurePowerShell
{
    [JsiiInterface(nativeType: typeof(IResourceDeploymentScriptAzurePowerShellConfig), fullyQualifiedName: "azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellConfig")]
    public interface IResourceDeploymentScriptAzurePowerShellConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#location ResourceDeploymentScriptAzurePowerShell#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#name ResourceDeploymentScriptAzurePowerShell#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#resource_group_name ResourceDeploymentScriptAzurePowerShell#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#retention_interval ResourceDeploymentScriptAzurePowerShell#retention_interval}.</summary>
        [JsiiProperty(name: "retentionInterval", typeJson: "{\"primitive\":\"string\"}")]
        string RetentionInterval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#version ResourceDeploymentScriptAzurePowerShell#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#cleanup_preference ResourceDeploymentScriptAzurePowerShell#cleanup_preference}.</summary>
        [JsiiProperty(name: "cleanupPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CleanupPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#command_line ResourceDeploymentScriptAzurePowerShell#command_line}.</summary>
        [JsiiProperty(name: "commandLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommandLine
        {
            get
            {
                return null;
            }
        }

        /// <summary>container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#container ResourceDeploymentScriptAzurePowerShell#container}
        /// </remarks>
        [JsiiProperty(name: "container", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellContainer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellContainer? Container
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment_variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#environment_variable ResourceDeploymentScriptAzurePowerShell#environment_variable}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellEnvironmentVariable" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellEnvironmentVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnvironmentVariable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#force_update_tag ResourceDeploymentScriptAzurePowerShell#force_update_tag}.</summary>
        [JsiiProperty(name: "forceUpdateTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForceUpdateTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#id ResourceDeploymentScriptAzurePowerShell#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#identity ResourceDeploymentScriptAzurePowerShell#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#primary_script_uri ResourceDeploymentScriptAzurePowerShell#primary_script_uri}.</summary>
        [JsiiProperty(name: "primaryScriptUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryScriptUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#script_content ResourceDeploymentScriptAzurePowerShell#script_content}.</summary>
        [JsiiProperty(name: "scriptContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScriptContent
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#storage_account ResourceDeploymentScriptAzurePowerShell#storage_account}
        /// </remarks>
        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellStorageAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellStorageAccount? StorageAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#supporting_script_uris ResourceDeploymentScriptAzurePowerShell#supporting_script_uris}.</summary>
        [JsiiProperty(name: "supportingScriptUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SupportingScriptUris
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#tags ResourceDeploymentScriptAzurePowerShell#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#timeout ResourceDeploymentScriptAzurePowerShell#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#timeouts ResourceDeploymentScriptAzurePowerShell#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceDeploymentScriptAzurePowerShellConfig), fullyQualifiedName: "azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#location ResourceDeploymentScriptAzurePowerShell#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#name ResourceDeploymentScriptAzurePowerShell#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#resource_group_name ResourceDeploymentScriptAzurePowerShell#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#retention_interval ResourceDeploymentScriptAzurePowerShell#retention_interval}.</summary>
            [JsiiProperty(name: "retentionInterval", typeJson: "{\"primitive\":\"string\"}")]
            public string RetentionInterval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#version ResourceDeploymentScriptAzurePowerShell#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#cleanup_preference ResourceDeploymentScriptAzurePowerShell#cleanup_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cleanupPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CleanupPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#command_line ResourceDeploymentScriptAzurePowerShell#command_line}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commandLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommandLine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>container block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#container ResourceDeploymentScriptAzurePowerShell#container}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "container", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellContainer\"}", isOptional: true)]
            public azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellContainer? Container
            {
                get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellContainer?>();
            }

            /// <summary>environment_variable block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#environment_variable ResourceDeploymentScriptAzurePowerShell#environment_variable}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellEnvironmentVariable" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellEnvironmentVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EnvironmentVariable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#force_update_tag ResourceDeploymentScriptAzurePowerShell#force_update_tag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceUpdateTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForceUpdateTag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#id ResourceDeploymentScriptAzurePowerShell#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#identity ResourceDeploymentScriptAzurePowerShell#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellIdentity\"}", isOptional: true)]
            public azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#primary_script_uri ResourceDeploymentScriptAzurePowerShell#primary_script_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryScriptUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryScriptUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#script_content ResourceDeploymentScriptAzurePowerShell#script_content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scriptContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScriptContent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storage_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#storage_account ResourceDeploymentScriptAzurePowerShell#storage_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellStorageAccount\"}", isOptional: true)]
            public azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellStorageAccount? StorageAccount
            {
                get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellStorageAccount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#supporting_script_uris ResourceDeploymentScriptAzurePowerShell#supporting_script_uris}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportingScriptUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SupportingScriptUris
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#tags ResourceDeploymentScriptAzurePowerShell#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#timeout ResourceDeploymentScriptAzurePowerShell#timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/resource_deployment_script_azure_power_shell#timeouts ResourceDeploymentScriptAzurePowerShell#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellTimeouts\"}", isOptional: true)]
            public azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ResourceDeploymentScriptAzurePowerShell.IResourceDeploymentScriptAzurePowerShellTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
