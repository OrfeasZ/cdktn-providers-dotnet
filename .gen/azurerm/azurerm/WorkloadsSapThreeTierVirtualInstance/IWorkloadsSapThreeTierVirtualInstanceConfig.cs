using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiInterface(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceConfig), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceConfig")]
    public interface IWorkloadsSapThreeTierVirtualInstanceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#app_location WorkloadsSapThreeTierVirtualInstance#app_location}.</summary>
        [JsiiProperty(name: "appLocation", typeJson: "{\"primitive\":\"string\"}")]
        string AppLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#environment WorkloadsSapThreeTierVirtualInstance#environment}.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        string Environment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#location WorkloadsSapThreeTierVirtualInstance#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#name WorkloadsSapThreeTierVirtualInstance#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#resource_group_name WorkloadsSapThreeTierVirtualInstance#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#sap_fqdn WorkloadsSapThreeTierVirtualInstance#sap_fqdn}.</summary>
        [JsiiProperty(name: "sapFqdn", typeJson: "{\"primitive\":\"string\"}")]
        string SapFqdn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#sap_product WorkloadsSapThreeTierVirtualInstance#sap_product}.</summary>
        [JsiiProperty(name: "sapProduct", typeJson: "{\"primitive\":\"string\"}")]
        string SapProduct
        {
            get;
        }

        /// <summary>three_tier_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#three_tier_configuration WorkloadsSapThreeTierVirtualInstance#three_tier_configuration}
        /// </remarks>
        [JsiiProperty(name: "threeTierConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration\"}")]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration ThreeTierConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#id WorkloadsSapThreeTierVirtualInstance#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#identity WorkloadsSapThreeTierVirtualInstance#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#managed_resource_group_name WorkloadsSapThreeTierVirtualInstance#managed_resource_group_name}.</summary>
        [JsiiProperty(name: "managedResourceGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedResourceGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#managed_resources_network_access_type WorkloadsSapThreeTierVirtualInstance#managed_resources_network_access_type}.</summary>
        [JsiiProperty(name: "managedResourcesNetworkAccessType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedResourcesNetworkAccessType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#tags WorkloadsSapThreeTierVirtualInstance#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#timeouts WorkloadsSapThreeTierVirtualInstance#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceConfig), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#app_location WorkloadsSapThreeTierVirtualInstance#app_location}.</summary>
            [JsiiProperty(name: "appLocation", typeJson: "{\"primitive\":\"string\"}")]
            public string AppLocation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#environment WorkloadsSapThreeTierVirtualInstance#environment}.</summary>
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
            public string Environment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#location WorkloadsSapThreeTierVirtualInstance#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#name WorkloadsSapThreeTierVirtualInstance#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#resource_group_name WorkloadsSapThreeTierVirtualInstance#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#sap_fqdn WorkloadsSapThreeTierVirtualInstance#sap_fqdn}.</summary>
            [JsiiProperty(name: "sapFqdn", typeJson: "{\"primitive\":\"string\"}")]
            public string SapFqdn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#sap_product WorkloadsSapThreeTierVirtualInstance#sap_product}.</summary>
            [JsiiProperty(name: "sapProduct", typeJson: "{\"primitive\":\"string\"}")]
            public string SapProduct
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>three_tier_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#three_tier_configuration WorkloadsSapThreeTierVirtualInstance#three_tier_configuration}
            /// </remarks>
            [JsiiProperty(name: "threeTierConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration\"}")]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration ThreeTierConfiguration
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#id WorkloadsSapThreeTierVirtualInstance#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#identity WorkloadsSapThreeTierVirtualInstance#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceIdentity\"}", isOptional: true)]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#managed_resource_group_name WorkloadsSapThreeTierVirtualInstance#managed_resource_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedResourceGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedResourceGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#managed_resources_network_access_type WorkloadsSapThreeTierVirtualInstance#managed_resources_network_access_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedResourcesNetworkAccessType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedResourcesNetworkAccessType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#tags WorkloadsSapThreeTierVirtualInstance#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/workloads_sap_three_tier_virtual_instance#timeouts WorkloadsSapThreeTierVirtualInstance#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceTimeouts\"}", isOptional: true)]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceTimeouts?>();
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
