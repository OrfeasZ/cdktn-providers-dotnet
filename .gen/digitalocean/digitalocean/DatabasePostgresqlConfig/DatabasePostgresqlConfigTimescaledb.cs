using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabasePostgresqlConfig
{
    [JsiiByValue(fqn: "digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledb")]
    public class DatabasePostgresqlConfigTimescaledb : digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_postgresql_config#max_background_workers DatabasePostgresqlConfig#max_background_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBackgroundWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBackgroundWorkers
        {
            get;
            set;
        }
    }
}
