using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseClusterStorageAutoscale), fullyQualifiedName: "digitalocean.databaseCluster.DatabaseClusterStorageAutoscale")]
    public interface IDatabaseClusterStorageAutoscale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.95.0/docs/resources/database_cluster#enabled DatabaseCluster#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Storage increase step size in GiB (minimum 10 GiB, rounded to nearest 10 GiB).</summary>
        /// <remarks>
        /// If not specified, system auto-calculates (25% of current size, min 50 GiB, max 1024 GiB, rounded to 10 GiB steps). Cooldown: 1 hour between autoscale operations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.95.0/docs/resources/database_cluster#increment_gib DatabaseCluster#increment_gib}
        /// </remarks>
        [JsiiProperty(name: "incrementGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IncrementGib
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.95.0/docs/resources/database_cluster#threshold_percent DatabaseCluster#threshold_percent}.</summary>
        [JsiiProperty(name: "thresholdPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThresholdPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseClusterStorageAutoscale), fullyQualifiedName: "digitalocean.databaseCluster.DatabaseClusterStorageAutoscale")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseCluster.IDatabaseClusterStorageAutoscale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.95.0/docs/resources/database_cluster#enabled DatabaseCluster#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Storage increase step size in GiB (minimum 10 GiB, rounded to nearest 10 GiB).</summary>
            /// <remarks>
            /// If not specified, system auto-calculates (25% of current size, min 50 GiB, max 1024 GiB, rounded to 10 GiB steps). Cooldown: 1 hour between autoscale operations.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.95.0/docs/resources/database_cluster#increment_gib DatabaseCluster#increment_gib}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "incrementGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IncrementGib
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.95.0/docs/resources/database_cluster#threshold_percent DatabaseCluster#threshold_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thresholdPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThresholdPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
