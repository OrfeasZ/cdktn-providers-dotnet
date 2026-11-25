using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesAddGdsControlNode
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasesAddGdsControlNode.DistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts")]
    public interface IDistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#create DistributedDatabaseDistributedDatabasesAddGdsControlNode#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#delete DistributedDatabaseDistributedDatabasesAddGdsControlNode#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#update DistributedDatabaseDistributedDatabasesAddGdsControlNode#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasesAddGdsControlNode.DistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabasesAddGdsControlNode.IDistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#create DistributedDatabaseDistributedDatabasesAddGdsControlNode#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#delete DistributedDatabaseDistributedDatabasesAddGdsControlNode#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#update DistributedDatabaseDistributedDatabasesAddGdsControlNode#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
