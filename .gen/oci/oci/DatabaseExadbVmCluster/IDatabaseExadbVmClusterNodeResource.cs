using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadbVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseExadbVmClusterNodeResource), fullyQualifiedName: "oci.databaseExadbVmCluster.DatabaseExadbVmClusterNodeResource")]
    public interface IDatabaseExadbVmClusterNodeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadb_vm_cluster#node_name DatabaseExadbVmCluster#node_name}.</summary>
        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}")]
        string NodeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExadbVmClusterNodeResource), fullyQualifiedName: "oci.databaseExadbVmCluster.DatabaseExadbVmClusterNodeResource")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExadbVmCluster.IDatabaseExadbVmClusterNodeResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadb_vm_cluster#node_name DatabaseExadbVmCluster#node_name}.</summary>
            [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
