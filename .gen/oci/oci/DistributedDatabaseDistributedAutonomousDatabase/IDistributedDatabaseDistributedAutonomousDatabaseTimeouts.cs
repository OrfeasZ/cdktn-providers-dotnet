using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseTimeouts), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeouts")]
    public interface IDistributedDatabaseDistributedAutonomousDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_autonomous_database#create DistributedDatabaseDistributedAutonomousDatabase#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_autonomous_database#delete DistributedDatabaseDistributedAutonomousDatabase#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_autonomous_database#update DistributedDatabaseDistributedAutonomousDatabase#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseTimeouts), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_autonomous_database#create DistributedDatabaseDistributedAutonomousDatabase#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_autonomous_database#delete DistributedDatabaseDistributedAutonomousDatabase#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_autonomous_database#update DistributedDatabaseDistributedAutonomousDatabase#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
