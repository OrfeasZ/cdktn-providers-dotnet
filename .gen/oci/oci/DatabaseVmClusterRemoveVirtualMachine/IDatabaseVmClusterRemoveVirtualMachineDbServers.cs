using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterRemoveVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IDatabaseVmClusterRemoveVirtualMachineDbServers), fullyQualifiedName: "oci.databaseVmClusterRemoveVirtualMachine.DatabaseVmClusterRemoveVirtualMachineDbServers")]
    public interface IDatabaseVmClusterRemoveVirtualMachineDbServers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#db_server_id DatabaseVmClusterRemoveVirtualMachine#db_server_id}.</summary>
        [JsiiProperty(name: "dbServerId", typeJson: "{\"primitive\":\"string\"}")]
        string DbServerId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseVmClusterRemoveVirtualMachineDbServers), fullyQualifiedName: "oci.databaseVmClusterRemoveVirtualMachine.DatabaseVmClusterRemoveVirtualMachineDbServers")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseVmClusterRemoveVirtualMachine.IDatabaseVmClusterRemoveVirtualMachineDbServers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_remove_virtual_machine#db_server_id DatabaseVmClusterRemoveVirtualMachine#db_server_id}.</summary>
            [JsiiProperty(name: "dbServerId", typeJson: "{\"primitive\":\"string\"}")]
            public string DbServerId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
