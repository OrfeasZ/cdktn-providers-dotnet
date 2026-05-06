using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabasePeerTargetDatabase
{
    [JsiiInterface(nativeType: typeof(IDataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails), fullyQualifiedName: "oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails")]
    public interface IDataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#database_type DataSafeTargetDatabasePeerTargetDatabase#database_type}.</summary>
        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#infrastructure_type DataSafeTargetDatabasePeerTargetDatabase#infrastructure_type}.</summary>
        [JsiiProperty(name: "infrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        string InfrastructureType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#autonomous_database_id DataSafeTargetDatabasePeerTargetDatabase#autonomous_database_id}.</summary>
        [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutonomousDatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#db_system_id DataSafeTargetDatabasePeerTargetDatabase#db_system_id}.</summary>
        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbSystemId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#instance_id DataSafeTargetDatabasePeerTargetDatabase#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#ip_addresses DataSafeTargetDatabasePeerTargetDatabase#ip_addresses}.</summary>
        [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#listener_port DataSafeTargetDatabasePeerTargetDatabase#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ListenerPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#pluggable_database_id DataSafeTargetDatabasePeerTargetDatabase#pluggable_database_id}.</summary>
        [JsiiProperty(name: "pluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PluggableDatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#service_name DataSafeTargetDatabasePeerTargetDatabase#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#vm_cluster_id DataSafeTargetDatabasePeerTargetDatabase#vm_cluster_id}.</summary>
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VmClusterId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails), fullyQualifiedName: "oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#database_type DataSafeTargetDatabasePeerTargetDatabase#database_type}.</summary>
            [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#infrastructure_type DataSafeTargetDatabasePeerTargetDatabase#infrastructure_type}.</summary>
            [JsiiProperty(name: "infrastructureType", typeJson: "{\"primitive\":\"string\"}")]
            public string InfrastructureType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#autonomous_database_id DataSafeTargetDatabasePeerTargetDatabase#autonomous_database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutonomousDatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#db_system_id DataSafeTargetDatabasePeerTargetDatabase#db_system_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbSystemId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#instance_id DataSafeTargetDatabasePeerTargetDatabase#instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#ip_addresses DataSafeTargetDatabasePeerTargetDatabase#ip_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#listener_port DataSafeTargetDatabasePeerTargetDatabase#listener_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ListenerPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#pluggable_database_id DataSafeTargetDatabasePeerTargetDatabase#pluggable_database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PluggableDatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#service_name DataSafeTargetDatabasePeerTargetDatabase#service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#vm_cluster_id DataSafeTargetDatabasePeerTargetDatabase#vm_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VmClusterId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
