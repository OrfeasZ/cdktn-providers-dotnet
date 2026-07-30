using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningComputeInstance
{
    [JsiiInterface(nativeType: typeof(IMachineLearningComputeInstanceConfig), fullyQualifiedName: "azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceConfig")]
    public interface IMachineLearningComputeInstanceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#machine_learning_workspace_id MachineLearningComputeInstance#machine_learning_workspace_id}.</summary>
        [JsiiProperty(name: "machineLearningWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string MachineLearningWorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#name MachineLearningComputeInstance#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#virtual_machine_size MachineLearningComputeInstance#virtual_machine_size}.</summary>
        [JsiiProperty(name: "virtualMachineSize", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualMachineSize
        {
            get;
        }

        /// <summary>assign_to_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#assign_to_user MachineLearningComputeInstance#assign_to_user}
        /// </remarks>
        [JsiiProperty(name: "assignToUser", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceAssignToUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceAssignToUser? AssignToUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#authorization_type MachineLearningComputeInstance#authorization_type}.</summary>
        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#description MachineLearningComputeInstance#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#id MachineLearningComputeInstance#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#identity MachineLearningComputeInstance#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#local_auth_enabled MachineLearningComputeInstance#local_auth_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "localAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LocalAuthEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#node_public_ip_enabled MachineLearningComputeInstance#node_public_ip_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "nodePublicIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NodePublicIpEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssh block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#ssh MachineLearningComputeInstance#ssh}
        /// </remarks>
        [JsiiProperty(name: "ssh", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceSsh\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh? Ssh
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#subnet_resource_id MachineLearningComputeInstance#subnet_resource_id}.</summary>
        [JsiiProperty(name: "subnetResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#tags MachineLearningComputeInstance#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#timeouts MachineLearningComputeInstance#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMachineLearningComputeInstanceConfig), fullyQualifiedName: "azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#machine_learning_workspace_id MachineLearningComputeInstance#machine_learning_workspace_id}.</summary>
            [JsiiProperty(name: "machineLearningWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string MachineLearningWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#name MachineLearningComputeInstance#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#virtual_machine_size MachineLearningComputeInstance#virtual_machine_size}.</summary>
            [JsiiProperty(name: "virtualMachineSize", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualMachineSize
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>assign_to_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#assign_to_user MachineLearningComputeInstance#assign_to_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assignToUser", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceAssignToUser\"}", isOptional: true)]
            public azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceAssignToUser? AssignToUser
            {
                get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceAssignToUser?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#authorization_type MachineLearningComputeInstance#authorization_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#description MachineLearningComputeInstance#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#id MachineLearningComputeInstance#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#identity MachineLearningComputeInstance#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceIdentity\"}", isOptional: true)]
            public azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#local_auth_enabled MachineLearningComputeInstance#local_auth_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "localAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LocalAuthEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#node_public_ip_enabled MachineLearningComputeInstance#node_public_ip_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodePublicIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? NodePublicIpEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssh block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#ssh MachineLearningComputeInstance#ssh}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssh", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceSsh\"}", isOptional: true)]
            public azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh? Ssh
            {
                get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#subnet_resource_id MachineLearningComputeInstance#subnet_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#tags MachineLearningComputeInstance#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_compute_instance#timeouts MachineLearningComputeInstance#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceTimeouts\"}", isOptional: true)]
            public azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceTimeouts?>();
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
