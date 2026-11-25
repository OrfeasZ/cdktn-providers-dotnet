using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode.DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts")]
    public interface IDistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#create DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#delete DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#update DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode.DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode.IDistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#create DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#delete DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#update DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
