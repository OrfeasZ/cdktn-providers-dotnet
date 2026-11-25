using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesRemove
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesRemoveRemove), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesRemove.DistributedDatabaseDistributedAutonomousDatabasesRemoveRemove")]
    public interface IDistributedDatabaseDistributedAutonomousDatabasesRemoveRemove
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove#selection DistributedDatabaseDistributedAutonomousDatabasesRemove#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesRemoveRemove), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesRemove.DistributedDatabaseDistributedAutonomousDatabasesRemoveRemove")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabasesRemove.IDistributedDatabaseDistributedAutonomousDatabasesRemoveRemove
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove#selection DistributedDatabaseDistributedAutonomousDatabasesRemove#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
