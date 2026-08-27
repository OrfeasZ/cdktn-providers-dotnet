using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiByValue(fqn: "oci.databaseDatabase.DatabaseDatabaseDatabaseAutoFailoverConfiguration")]
    public class DatabaseDatabaseDatabaseAutoFailoverConfiguration : oci.DatabaseDatabase.IDatabaseDatabaseDatabaseAutoFailoverConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#failover_targets DatabaseDatabase#failover_targets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverTargets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FailoverTargets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_database#managed_auto_failover DatabaseDatabase#managed_auto_failover}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedAutoFailover", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedAutoFailover
        {
            get;
            set;
        }
    }
}
