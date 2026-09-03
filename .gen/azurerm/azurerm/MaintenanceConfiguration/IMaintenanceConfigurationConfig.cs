using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceConfiguration
{
    [JsiiInterface(nativeType: typeof(IMaintenanceConfigurationConfig), fullyQualifiedName: "azurerm.maintenanceConfiguration.MaintenanceConfigurationConfig")]
    public interface IMaintenanceConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#location MaintenanceConfiguration#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#name MaintenanceConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#resource_group_name MaintenanceConfiguration#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#scope MaintenanceConfiguration#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#id MaintenanceConfiguration#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#in_guest_user_patch_mode MaintenanceConfiguration#in_guest_user_patch_mode}.</summary>
        [JsiiProperty(name: "inGuestUserPatchMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InGuestUserPatchMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>install_patches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#install_patches MaintenanceConfiguration#install_patches}
        /// </remarks>
        [JsiiProperty(name: "installPatches", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatches\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatches? InstallPatches
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#properties MaintenanceConfiguration#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#tags MaintenanceConfiguration#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#timeouts MaintenanceConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MaintenanceConfiguration.IMaintenanceConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#visibility MaintenanceConfiguration#visibility}.</summary>
        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Visibility
        {
            get
            {
                return null;
            }
        }

        /// <summary>window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#window MaintenanceConfiguration#window}
        /// </remarks>
        [JsiiProperty(name: "window", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationWindow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MaintenanceConfiguration.IMaintenanceConfigurationWindow? Window
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMaintenanceConfigurationConfig), fullyQualifiedName: "azurerm.maintenanceConfiguration.MaintenanceConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.MaintenanceConfiguration.IMaintenanceConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#location MaintenanceConfiguration#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#name MaintenanceConfiguration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#resource_group_name MaintenanceConfiguration#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#scope MaintenanceConfiguration#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#id MaintenanceConfiguration#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#in_guest_user_patch_mode MaintenanceConfiguration#in_guest_user_patch_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inGuestUserPatchMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InGuestUserPatchMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>install_patches block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#install_patches MaintenanceConfiguration#install_patches}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "installPatches", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatches\"}", isOptional: true)]
            public azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatches? InstallPatches
            {
                get => GetInstanceProperty<azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatches?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#properties MaintenanceConfiguration#properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Properties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#tags MaintenanceConfiguration#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#timeouts MaintenanceConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationTimeouts\"}", isOptional: true)]
            public azurerm.MaintenanceConfiguration.IMaintenanceConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.MaintenanceConfiguration.IMaintenanceConfigurationTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#visibility MaintenanceConfiguration#visibility}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Visibility
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/maintenance_configuration#window MaintenanceConfiguration#window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "window", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationWindow\"}", isOptional: true)]
            public azurerm.MaintenanceConfiguration.IMaintenanceConfigurationWindow? Window
            {
                get => GetInstanceProperty<azurerm.MaintenanceConfiguration.IMaintenanceConfigurationWindow?>();
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
