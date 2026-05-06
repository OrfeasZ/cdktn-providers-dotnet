using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterRemoveVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IDatabaseVmClusterRemoveVirtualMachineConfig), fullyQualifiedName: "oci.databaseVmClusterRemoveVirtualMachine.DatabaseVmClusterRemoveVirtualMachineConfig")]
    public interface IDatabaseVmClusterRemoveVirtualMachineConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>db_servers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#db_servers DatabaseVmClusterRemoveVirtualMachine#db_servers}
        /// </remarks>
        [JsiiProperty(name: "dbServers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseVmClusterRemoveVirtualMachine.DatabaseVmClusterRemoveVirtualMachineDbServers\"},\"kind\":\"array\"}}]}}")]
        object DbServers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#vm_cluster_id DatabaseVmClusterRemoveVirtualMachine#vm_cluster_id}.</summary>
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string VmClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#id DatabaseVmClusterRemoveVirtualMachine#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#timeouts DatabaseVmClusterRemoveVirtualMachine#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseVmClusterRemoveVirtualMachine.DatabaseVmClusterRemoveVirtualMachineTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseVmClusterRemoveVirtualMachine.IDatabaseVmClusterRemoveVirtualMachineTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseVmClusterRemoveVirtualMachineConfig), fullyQualifiedName: "oci.databaseVmClusterRemoveVirtualMachine.DatabaseVmClusterRemoveVirtualMachineConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseVmClusterRemoveVirtualMachine.IDatabaseVmClusterRemoveVirtualMachineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>db_servers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#db_servers DatabaseVmClusterRemoveVirtualMachine#db_servers}
            /// </remarks>
            [JsiiProperty(name: "dbServers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseVmClusterRemoveVirtualMachine.DatabaseVmClusterRemoveVirtualMachineDbServers\"},\"kind\":\"array\"}}]}}")]
            public object DbServers
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#vm_cluster_id DatabaseVmClusterRemoveVirtualMachine#vm_cluster_id}.</summary>
            [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string VmClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#id DatabaseVmClusterRemoveVirtualMachine#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#timeouts DatabaseVmClusterRemoveVirtualMachine#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseVmClusterRemoveVirtualMachine.DatabaseVmClusterRemoveVirtualMachineTimeouts\"}", isOptional: true)]
            public oci.DatabaseVmClusterRemoveVirtualMachine.IDatabaseVmClusterRemoveVirtualMachineTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseVmClusterRemoveVirtualMachine.IDatabaseVmClusterRemoveVirtualMachineTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
