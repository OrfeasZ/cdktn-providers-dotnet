using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterAddVirtualMachine
{
    [JsiiByValue(fqn: "oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineTimeouts")]
    public class DatabaseVmClusterAddVirtualMachineTimeouts : oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_add_virtual_machine#create DatabaseVmClusterAddVirtualMachine#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_add_virtual_machine#delete DatabaseVmClusterAddVirtualMachine#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_add_virtual_machine#update DatabaseVmClusterAddVirtualMachine#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
