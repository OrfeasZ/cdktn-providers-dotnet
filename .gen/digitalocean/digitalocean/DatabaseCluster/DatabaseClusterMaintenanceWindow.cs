using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.databaseCluster.DatabaseClusterMaintenanceWindow")]
    public class DatabaseClusterMaintenanceWindow : digitalocean.DatabaseCluster.IDatabaseClusterMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_cluster#day DatabaseCluster#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        public string Day
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_cluster#hour DatabaseCluster#hour}.</summary>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"string\"}")]
        public string Hour
        {
            get;
            set;
        }
    }
}
