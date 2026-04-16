using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.k8SCluster.K8SClusterAutoUpgrade")]
    public class K8SClusterAutoUpgrade : scaleway.K8SCluster.IK8SClusterAutoUpgrade
    {
        private object _enable;

        /// <summary>Enables the Kubernetes patch version auto upgrade.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#enable K8SCluster#enable}
        /// </remarks>
        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enable
        {
            get => _enable;
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
                _enable = value;
            }
        }

        /// <summary>Day of the maintenance window.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#maintenance_window_day K8SCluster#maintenance_window_day}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindowDay", typeJson: "{\"primitive\":\"string\"}")]
        public string MaintenanceWindowDay
        {
            get;
            set;
        }

        /// <summary>Start hour of the 2-hour maintenance window.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#maintenance_window_start_hour K8SCluster#maintenance_window_start_hour}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindowStartHour", typeJson: "{\"primitive\":\"number\"}")]
        public double MaintenanceWindowStartHour
        {
            get;
            set;
        }
    }
}
