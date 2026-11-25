using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesInsert
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesInsertInsert), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesInsert.DistributedDatabaseDistributedAutonomousDatabasesInsertInsert")]
    public interface IDistributedDatabaseDistributedAutonomousDatabasesInsertInsert
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#selection DistributedDatabaseDistributedAutonomousDatabasesInsert#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        /// <summary>Sensitive JSON document matching the selected topology's create payload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#value DistributedDatabaseDistributedAutonomousDatabasesInsert#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesInsertInsert), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesInsert.DistributedDatabaseDistributedAutonomousDatabasesInsertInsert")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabasesInsert.IDistributedDatabaseDistributedAutonomousDatabasesInsertInsert
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#selection DistributedDatabaseDistributedAutonomousDatabasesInsert#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sensitive JSON document matching the selected topology's create payload.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#value DistributedDatabaseDistributedAutonomousDatabasesInsert#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
