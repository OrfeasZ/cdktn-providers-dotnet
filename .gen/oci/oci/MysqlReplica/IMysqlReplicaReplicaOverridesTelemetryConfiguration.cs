using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlReplica
{
    [JsiiInterface(nativeType: typeof(IMysqlReplicaReplicaOverridesTelemetryConfiguration), fullyQualifiedName: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfiguration")]
    public interface IMysqlReplicaReplicaOverridesTelemetryConfiguration
    {
        /// <summary>logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_replica#logs MysqlReplica#logs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "logs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlReplicaReplicaOverridesTelemetryConfiguration), fullyQualifiedName: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/mysql_replica#logs MysqlReplica#logs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Logs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
