using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SCluster
{
    [JsiiInterface(nativeType: typeof(IK8SClusterAutoUpgrade), fullyQualifiedName: "scaleway.k8SCluster.K8SClusterAutoUpgrade")]
    public interface IK8SClusterAutoUpgrade
    {
        /// <summary>Enables the Kubernetes patch version auto upgrade.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#enable K8SCluster#enable}
        /// </remarks>
        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enable
        {
            get;
        }

        /// <summary>Day of the maintenance window.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#maintenance_window_day K8SCluster#maintenance_window_day}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindowDay", typeJson: "{\"primitive\":\"string\"}")]
        string MaintenanceWindowDay
        {
            get;
        }

        /// <summary>Start hour of the 2-hour maintenance window.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#maintenance_window_start_hour K8SCluster#maintenance_window_start_hour}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindowStartHour", typeJson: "{\"primitive\":\"number\"}")]
        double MaintenanceWindowStartHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IK8SClusterAutoUpgrade), fullyQualifiedName: "scaleway.k8SCluster.K8SClusterAutoUpgrade")]
        internal sealed class _Proxy : DeputyBase, scaleway.K8SCluster.IK8SClusterAutoUpgrade
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables the Kubernetes patch version auto upgrade.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#enable K8SCluster#enable}
            /// </remarks>
            [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enable
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Day of the maintenance window.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#maintenance_window_day K8SCluster#maintenance_window_day}
            /// </remarks>
            [JsiiProperty(name: "maintenanceWindowDay", typeJson: "{\"primitive\":\"string\"}")]
            public string MaintenanceWindowDay
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Start hour of the 2-hour maintenance window.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#maintenance_window_start_hour K8SCluster#maintenance_window_start_hour}
            /// </remarks>
            [JsiiProperty(name: "maintenanceWindowStartHour", typeJson: "{\"primitive\":\"number\"}")]
            public double MaintenanceWindowStartHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
