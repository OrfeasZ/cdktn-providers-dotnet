using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachineAvailabilityGroupListener
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineAvailabilityGroupListenerConfig), fullyQualifiedName: "azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerConfig")]
    public interface IMssqlVirtualMachineAvailabilityGroupListenerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#name MssqlVirtualMachineAvailabilityGroupListener#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>replica block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#replica MssqlVirtualMachineAvailabilityGroupListener#replica}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerReplica" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "replica", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerReplica\"},\"kind\":\"array\"}}]}}")]
        object Replica
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#sql_virtual_machine_group_id MssqlVirtualMachineAvailabilityGroupListener#sql_virtual_machine_group_id}.</summary>
        [JsiiProperty(name: "sqlVirtualMachineGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string SqlVirtualMachineGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#availability_group_name MssqlVirtualMachineAvailabilityGroupListener#availability_group_name}.</summary>
        [JsiiProperty(name: "availabilityGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#id MssqlVirtualMachineAvailabilityGroupListener#id}.</summary>
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

        /// <summary>load_balancer_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#load_balancer_configuration MssqlVirtualMachineAvailabilityGroupListener#load_balancer_configuration}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerConfiguration", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfiguration? LoadBalancerConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>multi_subnet_ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#multi_subnet_ip_configuration MssqlVirtualMachineAvailabilityGroupListener#multi_subnet_ip_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "multiSubnetIpConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultiSubnetIpConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#port MssqlVirtualMachineAvailabilityGroupListener#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#timeouts MssqlVirtualMachineAvailabilityGroupListener#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineAvailabilityGroupListenerConfig), fullyQualifiedName: "azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#name MssqlVirtualMachineAvailabilityGroupListener#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>replica block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#replica MssqlVirtualMachineAvailabilityGroupListener#replica}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerReplica" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "replica", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerReplica\"},\"kind\":\"array\"}}]}}")]
            public object Replica
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#sql_virtual_machine_group_id MssqlVirtualMachineAvailabilityGroupListener#sql_virtual_machine_group_id}.</summary>
            [JsiiProperty(name: "sqlVirtualMachineGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlVirtualMachineGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#availability_group_name MssqlVirtualMachineAvailabilityGroupListener#availability_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#id MssqlVirtualMachineAvailabilityGroupListener#id}.</summary>
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

            /// <summary>load_balancer_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#load_balancer_configuration MssqlVirtualMachineAvailabilityGroupListener#load_balancer_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerConfiguration", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfiguration\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfiguration? LoadBalancerConfiguration
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfiguration?>();
            }

            /// <summary>multi_subnet_ip_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#multi_subnet_ip_configuration MssqlVirtualMachineAvailabilityGroupListener#multi_subnet_ip_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiSubnetIpConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MultiSubnetIpConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#port MssqlVirtualMachineAvailabilityGroupListener#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/mssql_virtual_machine_availability_group_listener#timeouts MssqlVirtualMachineAvailabilityGroupListener#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachineAvailabilityGroupListener.MssqlVirtualMachineAvailabilityGroupListenerTimeouts\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachineAvailabilityGroupListener.IMssqlVirtualMachineAvailabilityGroupListenerTimeouts?>();
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
