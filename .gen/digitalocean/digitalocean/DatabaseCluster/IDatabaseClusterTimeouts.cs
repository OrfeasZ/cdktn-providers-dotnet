using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseClusterTimeouts), fullyQualifiedName: "digitalocean.databaseCluster.DatabaseClusterTimeouts")]
    public interface IDatabaseClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_cluster#create DatabaseCluster#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseClusterTimeouts), fullyQualifiedName: "digitalocean.databaseCluster.DatabaseClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseCluster.IDatabaseClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_cluster#create DatabaseCluster#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
