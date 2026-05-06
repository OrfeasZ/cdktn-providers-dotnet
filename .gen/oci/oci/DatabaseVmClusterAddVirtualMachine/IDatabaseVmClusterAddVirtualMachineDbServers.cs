using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterAddVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IDatabaseVmClusterAddVirtualMachineDbServers), fullyQualifiedName: "oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDbServers")]
    public interface IDatabaseVmClusterAddVirtualMachineDbServers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_add_virtual_machine#db_server_id DatabaseVmClusterAddVirtualMachine#db_server_id}.</summary>
        [JsiiProperty(name: "dbServerId", typeJson: "{\"primitive\":\"string\"}")]
        string DbServerId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseVmClusterAddVirtualMachineDbServers), fullyQualifiedName: "oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDbServers")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineDbServers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_add_virtual_machine#db_server_id DatabaseVmClusterAddVirtualMachine#db_server_id}.</summary>
            [JsiiProperty(name: "dbServerId", typeJson: "{\"primitive\":\"string\"}")]
            public string DbServerId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
