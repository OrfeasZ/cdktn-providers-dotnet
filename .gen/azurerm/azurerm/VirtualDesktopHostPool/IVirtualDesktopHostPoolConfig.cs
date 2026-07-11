using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualDesktopHostPool
{
    [JsiiInterface(nativeType: typeof(IVirtualDesktopHostPoolConfig), fullyQualifiedName: "azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolConfig")]
    public interface IVirtualDesktopHostPoolConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#load_balancer_type VirtualDesktopHostPool#load_balancer_type}.</summary>
        [JsiiProperty(name: "loadBalancerType", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#location VirtualDesktopHostPool#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#name VirtualDesktopHostPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#resource_group_name VirtualDesktopHostPool#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#type VirtualDesktopHostPool#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#custom_rdp_properties VirtualDesktopHostPool#custom_rdp_properties}.</summary>
        [JsiiProperty(name: "customRdpProperties", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomRdpProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#description VirtualDesktopHostPool#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#friendly_name VirtualDesktopHostPool#friendly_name}.</summary>
        [JsiiProperty(name: "friendlyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FriendlyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#id VirtualDesktopHostPool#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#maximum_sessions_allowed VirtualDesktopHostPool#maximum_sessions_allowed}.</summary>
        [JsiiProperty(name: "maximumSessionsAllowed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumSessionsAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#personal_desktop_assignment_type VirtualDesktopHostPool#personal_desktop_assignment_type}.</summary>
        [JsiiProperty(name: "personalDesktopAssignmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersonalDesktopAssignmentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Preferred App Group type to display.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#preferred_app_group_type VirtualDesktopHostPool#preferred_app_group_type}
        /// </remarks>
        [JsiiProperty(name: "preferredAppGroupType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredAppGroupType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#public_network_access VirtualDesktopHostPool#public_network_access}.</summary>
        [JsiiProperty(name: "publicNetworkAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicNetworkAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>scheduled_agent_updates block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#scheduled_agent_updates VirtualDesktopHostPool#scheduled_agent_updates}
        /// </remarks>
        [JsiiProperty(name: "scheduledAgentUpdates", typeJson: "{\"fqn\":\"azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolScheduledAgentUpdates\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolScheduledAgentUpdates? ScheduledAgentUpdates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#start_vm_on_connect VirtualDesktopHostPool#start_vm_on_connect}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "startVmOnConnect", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StartVmOnConnect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#tags VirtualDesktopHostPool#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#timeouts VirtualDesktopHostPool#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#validate_environment VirtualDesktopHostPool#validate_environment}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "validateEnvironment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ValidateEnvironment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#vm_template VirtualDesktopHostPool#vm_template}.</summary>
        [JsiiProperty(name: "vmTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VmTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualDesktopHostPoolConfig), fullyQualifiedName: "azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#load_balancer_type VirtualDesktopHostPool#load_balancer_type}.</summary>
            [JsiiProperty(name: "loadBalancerType", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#location VirtualDesktopHostPool#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#name VirtualDesktopHostPool#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#resource_group_name VirtualDesktopHostPool#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#type VirtualDesktopHostPool#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#custom_rdp_properties VirtualDesktopHostPool#custom_rdp_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customRdpProperties", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomRdpProperties
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#description VirtualDesktopHostPool#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#friendly_name VirtualDesktopHostPool#friendly_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "friendlyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FriendlyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#id VirtualDesktopHostPool#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#maximum_sessions_allowed VirtualDesktopHostPool#maximum_sessions_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumSessionsAllowed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumSessionsAllowed
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#personal_desktop_assignment_type VirtualDesktopHostPool#personal_desktop_assignment_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "personalDesktopAssignmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersonalDesktopAssignmentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Preferred App Group type to display.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#preferred_app_group_type VirtualDesktopHostPool#preferred_app_group_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredAppGroupType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredAppGroupType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#public_network_access VirtualDesktopHostPool#public_network_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicNetworkAccess
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scheduled_agent_updates block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#scheduled_agent_updates VirtualDesktopHostPool#scheduled_agent_updates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledAgentUpdates", typeJson: "{\"fqn\":\"azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolScheduledAgentUpdates\"}", isOptional: true)]
            public azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolScheduledAgentUpdates? ScheduledAgentUpdates
            {
                get => GetInstanceProperty<azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolScheduledAgentUpdates?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#start_vm_on_connect VirtualDesktopHostPool#start_vm_on_connect}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startVmOnConnect", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? StartVmOnConnect
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#tags VirtualDesktopHostPool#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#timeouts VirtualDesktopHostPool#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolTimeouts\"}", isOptional: true)]
            public azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#validate_environment VirtualDesktopHostPool#validate_environment}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validateEnvironment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ValidateEnvironment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/virtual_desktop_host_pool#vm_template VirtualDesktopHostPool#vm_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vmTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VmTemplate
            {
                get => GetInstanceProperty<string?>();
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
