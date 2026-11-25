using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesRemove
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabasesRemoveRemove), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasesRemove.DistributedDatabaseDistributedDatabasesRemoveRemove")]
    public interface IDistributedDatabaseDistributedDatabasesRemoveRemove
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_remove#selection DistributedDatabaseDistributedDatabasesRemove#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabasesRemoveRemove), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasesRemove.DistributedDatabaseDistributedDatabasesRemoveRemove")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabasesRemove.IDistributedDatabaseDistributedDatabasesRemoveRemove
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_remove#selection DistributedDatabaseDistributedDatabasesRemove#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
