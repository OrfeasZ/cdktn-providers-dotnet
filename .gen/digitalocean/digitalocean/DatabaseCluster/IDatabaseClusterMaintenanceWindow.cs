using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseClusterMaintenanceWindow), fullyQualifiedName: "digitalocean.databaseCluster.DatabaseClusterMaintenanceWindow")]
    public interface IDatabaseClusterMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_cluster#day DatabaseCluster#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        string Day
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_cluster#hour DatabaseCluster#hour}.</summary>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"string\"}")]
        string Hour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseClusterMaintenanceWindow), fullyQualifiedName: "digitalocean.databaseCluster.DatabaseClusterMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseCluster.IDatabaseClusterMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_cluster#day DatabaseCluster#day}.</summary>
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
            public string Day
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_cluster#hour DatabaseCluster#hour}.</summary>
            [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"string\"}")]
            public string Hour
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
