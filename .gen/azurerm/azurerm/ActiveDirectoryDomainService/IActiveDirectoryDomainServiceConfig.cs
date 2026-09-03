using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ActiveDirectoryDomainService
{
    [JsiiInterface(nativeType: typeof(IActiveDirectoryDomainServiceConfig), fullyQualifiedName: "azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceConfig")]
    public interface IActiveDirectoryDomainServiceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#domain_name ActiveDirectoryDomainService#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>initial_replica_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#initial_replica_set ActiveDirectoryDomainService#initial_replica_set}
        /// </remarks>
        [JsiiProperty(name: "initialReplicaSet", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSet\"}")]
        azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceInitialReplicaSet InitialReplicaSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#location ActiveDirectoryDomainService#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#name ActiveDirectoryDomainService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#resource_group_name ActiveDirectoryDomainService#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#sku ActiveDirectoryDomainService#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        string Sku
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#domain_configuration_type ActiveDirectoryDomainService#domain_configuration_type}.</summary>
        [JsiiProperty(name: "domainConfigurationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainConfigurationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#filtered_sync_enabled ActiveDirectoryDomainService#filtered_sync_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "filteredSyncEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FilteredSyncEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#id ActiveDirectoryDomainService#id}.</summary>
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

        /// <summary>notifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#notifications ActiveDirectoryDomainService#notifications}
        /// </remarks>
        [JsiiProperty(name: "notifications", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceNotifications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceNotifications? Notifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>secure_ldap block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#secure_ldap ActiveDirectoryDomainService#secure_ldap}
        /// </remarks>
        [JsiiProperty(name: "secureLdap", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecureLdap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecureLdap? SecureLdap
        {
            get
            {
                return null;
            }
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#security ActiveDirectoryDomainService#security}
        /// </remarks>
        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecurity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecurity? Security
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#tags ActiveDirectoryDomainService#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#timeouts ActiveDirectoryDomainService#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActiveDirectoryDomainServiceConfig), fullyQualifiedName: "azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#domain_name ActiveDirectoryDomainService#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>initial_replica_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#initial_replica_set ActiveDirectoryDomainService#initial_replica_set}
            /// </remarks>
            [JsiiProperty(name: "initialReplicaSet", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSet\"}")]
            public azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceInitialReplicaSet InitialReplicaSet
            {
                get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceInitialReplicaSet>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#location ActiveDirectoryDomainService#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#name ActiveDirectoryDomainService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#resource_group_name ActiveDirectoryDomainService#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#sku ActiveDirectoryDomainService#sku}.</summary>
            [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
            public string Sku
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#domain_configuration_type ActiveDirectoryDomainService#domain_configuration_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainConfigurationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainConfigurationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#filtered_sync_enabled ActiveDirectoryDomainService#filtered_sync_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filteredSyncEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FilteredSyncEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#id ActiveDirectoryDomainService#id}.</summary>
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

            /// <summary>notifications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#notifications ActiveDirectoryDomainService#notifications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notifications", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceNotifications\"}", isOptional: true)]
            public azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceNotifications? Notifications
            {
                get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceNotifications?>();
            }

            /// <summary>secure_ldap block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#secure_ldap ActiveDirectoryDomainService#secure_ldap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secureLdap", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecureLdap\"}", isOptional: true)]
            public azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecureLdap? SecureLdap
            {
                get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecureLdap?>();
            }

            /// <summary>security block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#security ActiveDirectoryDomainService#security}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecurity\"}", isOptional: true)]
            public azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecurity? Security
            {
                get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecurity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#tags ActiveDirectoryDomainService#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/active_directory_domain_service#timeouts ActiveDirectoryDomainService#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceTimeouts\"}", isOptional: true)]
            public azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceTimeouts?>();
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
