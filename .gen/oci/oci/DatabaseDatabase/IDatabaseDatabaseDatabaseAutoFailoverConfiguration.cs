using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseDatabaseAutoFailoverConfiguration), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseAutoFailoverConfiguration")]
    public interface IDatabaseDatabaseDatabaseAutoFailoverConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#failover_targets DatabaseDatabase#failover_targets}.</summary>
        [JsiiProperty(name: "failoverTargets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FailoverTargets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#managed_auto_failover DatabaseDatabase#managed_auto_failover}.</summary>
        [JsiiProperty(name: "managedAutoFailover", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedAutoFailover
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseDatabaseAutoFailoverConfiguration), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseAutoFailoverConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabase.IDatabaseDatabaseDatabaseAutoFailoverConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#failover_targets DatabaseDatabase#failover_targets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failoverTargets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FailoverTargets
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_database#managed_auto_failover DatabaseDatabase#managed_auto_failover}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedAutoFailover", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedAutoFailover
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
