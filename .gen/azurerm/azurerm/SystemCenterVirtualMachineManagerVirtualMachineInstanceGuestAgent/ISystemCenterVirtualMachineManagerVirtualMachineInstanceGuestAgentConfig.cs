using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent
{
    [JsiiInterface(nativeType: typeof(ISystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentConfig), fullyQualifiedName: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentConfig")]
    public interface ISystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#password SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#scoped_resource_id SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#scoped_resource_id}.</summary>
        [JsiiProperty(name: "scopedResourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ScopedResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#username SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#id SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#provisioning_action SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#provisioning_action}.</summary>
        [JsiiProperty(name: "provisioningAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProvisioningAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#timeouts SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.systemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.ISystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentConfig), fullyQualifiedName: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.ISystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#password SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#scoped_resource_id SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#scoped_resource_id}.</summary>
            [JsiiProperty(name: "scopedResourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopedResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#username SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#id SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#provisioning_action SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#provisioning_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provisioningAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProvisioningAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance_guest_agent#timeouts SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.systemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeouts\"}", isOptional: true)]
            public azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.ISystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgent.ISystemCenterVirtualMachineManagerVirtualMachineInstanceGuestAgentTimeouts?>();
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
