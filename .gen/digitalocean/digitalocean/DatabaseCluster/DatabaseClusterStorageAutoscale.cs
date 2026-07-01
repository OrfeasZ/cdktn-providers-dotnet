using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.databaseCluster.DatabaseClusterStorageAutoscale")]
    public class DatabaseClusterStorageAutoscale : digitalocean.DatabaseCluster.IDatabaseClusterStorageAutoscale
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.93.0/docs/resources/database_cluster#enabled DatabaseCluster#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Storage increase step size in GiB (minimum 10 GiB, rounded to nearest 10 GiB).</summary>
        /// <remarks>
        /// If not specified, system auto-calculates (25% of current size, min 50 GiB, max 1024 GiB, rounded to 10 GiB steps). Cooldown: 1 hour between autoscale operations.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.93.0/docs/resources/database_cluster#increment_gib DatabaseCluster#increment_gib}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "incrementGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IncrementGib
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.93.0/docs/resources/database_cluster#threshold_percent DatabaseCluster#threshold_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdPercent
        {
            get;
            set;
        }
    }
}
