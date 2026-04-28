using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SCluster
{
    [JsiiInterface(nativeType: typeof(IK8SClusterAutoscalerConfig), fullyQualifiedName: "scaleway.k8SCluster.K8SClusterAutoscalerConfig")]
    public interface IK8SClusterAutoscalerConfig
    {
        /// <summary>Detect similar node groups and balance the number of nodes between them.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#balance_similar_node_groups K8SCluster#balance_similar_node_groups}
        /// </remarks>
        [JsiiProperty(name: "balanceSimilarNodeGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BalanceSimilarNodeGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disable the scale down feature of the autoscaler.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#disable_scale_down K8SCluster#disable_scale_down}
        /// </remarks>
        [JsiiProperty(name: "disableScaleDown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableScaleDown
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of resource estimator to be used in scale up.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#estimator K8SCluster#estimator}
        /// </remarks>
        [JsiiProperty(name: "estimator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Estimator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of node group expander to be used in scale up.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#expander K8SCluster#expander}
        /// </remarks>
        [JsiiProperty(name: "expander", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expander
        {
            get
            {
                return null;
            }
        }

        /// <summary>Pods with priority below cutoff will be expendable.</summary>
        /// <remarks>
        /// They can be killed without any consideration during scale down and they don't cause scale up. Pods with null priority (PodPriority disabled) are non expendable
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#expendable_pods_priority_cutoff K8SCluster#expendable_pods_priority_cutoff}
        /// </remarks>
        [JsiiProperty(name: "expendablePodsPriorityCutoff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpendablePodsPriorityCutoff
        {
            get
            {
                return null;
            }
        }

        /// <summary>Ignore DaemonSet pods when calculating resource utilization for scaling down.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#ignore_daemonsets_utilization K8SCluster#ignore_daemonsets_utilization}
        /// </remarks>
        [JsiiProperty(name: "ignoreDaemonsetsUtilization", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreDaemonsetsUtilization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum number of seconds the cluster autoscaler waits for pod termination when trying to scale down a node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#max_graceful_termination_sec K8SCluster#max_graceful_termination_sec}
        /// </remarks>
        [JsiiProperty(name: "maxGracefulTerminationSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxGracefulTerminationSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>How long after scale up that scale down evaluation resumes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#scale_down_delay_after_add K8SCluster#scale_down_delay_after_add}
        /// </remarks>
        [JsiiProperty(name: "scaleDownDelayAfterAdd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownDelayAfterAdd
        {
            get
            {
                return null;
            }
        }

        /// <summary>How long a node should be unneeded before it is eligible for scale down.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#scale_down_unneeded_time K8SCluster#scale_down_unneeded_time}
        /// </remarks>
        [JsiiProperty(name: "scaleDownUnneededTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownUnneededTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Node utilization level, defined as sum of requested resources divided by capacity, below which a node can be considered for scale down.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#scale_down_utilization_threshold K8SCluster#scale_down_utilization_threshold}
        /// </remarks>
        [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleDownUtilizationThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IK8SClusterAutoscalerConfig), fullyQualifiedName: "scaleway.k8SCluster.K8SClusterAutoscalerConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.K8SCluster.IK8SClusterAutoscalerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Detect similar node groups and balance the number of nodes between them.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#balance_similar_node_groups K8SCluster#balance_similar_node_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "balanceSimilarNodeGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BalanceSimilarNodeGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Disable the scale down feature of the autoscaler.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#disable_scale_down K8SCluster#disable_scale_down}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableScaleDown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableScaleDown
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Type of resource estimator to be used in scale up.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#estimator K8SCluster#estimator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "estimator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Estimator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of node group expander to be used in scale up.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#expander K8SCluster#expander}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expander", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expander
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Pods with priority below cutoff will be expendable.</summary>
            /// <remarks>
            /// They can be killed without any consideration during scale down and they don't cause scale up. Pods with null priority (PodPriority disabled) are non expendable
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#expendable_pods_priority_cutoff K8SCluster#expendable_pods_priority_cutoff}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expendablePodsPriorityCutoff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpendablePodsPriorityCutoff
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Ignore DaemonSet pods when calculating resource utilization for scaling down.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#ignore_daemonsets_utilization K8SCluster#ignore_daemonsets_utilization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreDaemonsetsUtilization", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreDaemonsetsUtilization
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Maximum number of seconds the cluster autoscaler waits for pod termination when trying to scale down a node.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#max_graceful_termination_sec K8SCluster#max_graceful_termination_sec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxGracefulTerminationSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxGracefulTerminationSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>How long after scale up that scale down evaluation resumes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#scale_down_delay_after_add K8SCluster#scale_down_delay_after_add}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownDelayAfterAdd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownDelayAfterAdd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>How long a node should be unneeded before it is eligible for scale down.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#scale_down_unneeded_time K8SCluster#scale_down_unneeded_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownUnneededTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownUnneededTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Node utilization level, defined as sum of requested resources divided by capacity, below which a node can be considered for scale down.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#scale_down_utilization_threshold K8SCluster#scale_down_utilization_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleDownUtilizationThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
