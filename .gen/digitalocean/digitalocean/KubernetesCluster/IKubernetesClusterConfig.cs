using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterConfig), fullyQualifiedName: "digitalocean.kubernetesCluster.KubernetesClusterConfig")]
    public interface IKubernetesClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#name KubernetesCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>node_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#node_pool KubernetesCluster#node_pool}
        /// </remarks>
        [JsiiProperty(name: "nodePool", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNodePool\"}")]
        digitalocean.KubernetesCluster.IKubernetesClusterNodePool NodePool
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#region KubernetesCluster#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#version KubernetesCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>amd_gpu_device_metrics_exporter_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#amd_gpu_device_metrics_exporter_plugin KubernetesCluster#amd_gpu_device_metrics_exporter_plugin}
        /// </remarks>
        [JsiiProperty(name: "amdGpuDeviceMetricsExporterPlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDeviceMetricsExporterPlugin? AmdGpuDeviceMetricsExporterPlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>amd_gpu_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#amd_gpu_device_plugin KubernetesCluster#amd_gpu_device_plugin}
        /// </remarks>
        [JsiiProperty(name: "amdGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDevicePlugin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDevicePlugin? AmdGpuDevicePlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#auto_upgrade KubernetesCluster#auto_upgrade}.</summary>
        [JsiiProperty(name: "autoUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>cluster_autoscaler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#cluster_autoscaler_configuration KubernetesCluster#cluster_autoscaler_configuration}
        /// </remarks>
        [JsiiProperty(name: "clusterAutoscalerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClusterAutoscalerConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#cluster_subnet KubernetesCluster#cluster_subnet}.</summary>
        [JsiiProperty(name: "clusterSubnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterSubnet
        {
            get
            {
                return null;
            }
        }

        /// <summary>control_plane_firewall block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#control_plane_firewall KubernetesCluster#control_plane_firewall}
        /// </remarks>
        [JsiiProperty(name: "controlPlaneFirewall", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterControlPlaneFirewall\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.KubernetesCluster.IKubernetesClusterControlPlaneFirewall? ControlPlaneFirewall
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#destroy_all_associated_resources KubernetesCluster#destroy_all_associated_resources}.</summary>
        [JsiiProperty(name: "destroyAllAssociatedResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DestroyAllAssociatedResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#ha KubernetesCluster#ha}.</summary>
        [JsiiProperty(name: "ha", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ha
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#id KubernetesCluster#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#kubeconfig_expire_seconds KubernetesCluster#kubeconfig_expire_seconds}.</summary>
        [JsiiProperty(name: "kubeconfigExpireSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KubeconfigExpireSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#maintenance_policy KubernetesCluster#maintenance_policy}
        /// </remarks>
        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterMaintenancePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.KubernetesCluster.IKubernetesClusterMaintenancePolicy? MaintenancePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>nvidia_gpu_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#nvidia_gpu_device_plugin KubernetesCluster#nvidia_gpu_device_plugin}
        /// </remarks>
        [JsiiProperty(name: "nvidiaGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNvidiaGpuDevicePlugin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.KubernetesCluster.IKubernetesClusterNvidiaGpuDevicePlugin? NvidiaGpuDevicePlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>rdma_shared_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#rdma_shared_device_plugin KubernetesCluster#rdma_shared_device_plugin}
        /// </remarks>
        [JsiiProperty(name: "rdmaSharedDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRdmaSharedDevicePlugin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.KubernetesCluster.IKubernetesClusterRdmaSharedDevicePlugin? RdmaSharedDevicePlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#registry_integration KubernetesCluster#registry_integration}.</summary>
        [JsiiProperty(name: "registryIntegration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RegistryIntegration
        {
            get
            {
                return null;
            }
        }

        /// <summary>routing_agent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#routing_agent KubernetesCluster#routing_agent}
        /// </remarks>
        [JsiiProperty(name: "routingAgent", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRoutingAgent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.KubernetesCluster.IKubernetesClusterRoutingAgent? RoutingAgent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#service_subnet KubernetesCluster#service_subnet}.</summary>
        [JsiiProperty(name: "serviceSubnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceSubnet
        {
            get
            {
                return null;
            }
        }

        /// <summary>sso block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#sso KubernetesCluster#sso}
        /// </remarks>
        [JsiiProperty(name: "sso", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterSso\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sso
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#surge_upgrade KubernetesCluster#surge_upgrade}.</summary>
        [JsiiProperty(name: "surgeUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SurgeUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#tags KubernetesCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#timeouts KubernetesCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.KubernetesCluster.IKubernetesClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#vpc_uuid KubernetesCluster#vpc_uuid}.</summary>
        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcUuid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterConfig), fullyQualifiedName: "digitalocean.kubernetesCluster.KubernetesClusterConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.KubernetesCluster.IKubernetesClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#name KubernetesCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>node_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#node_pool KubernetesCluster#node_pool}
            /// </remarks>
            [JsiiProperty(name: "nodePool", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNodePool\"}")]
            public digitalocean.KubernetesCluster.IKubernetesClusterNodePool NodePool
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterNodePool>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#region KubernetesCluster#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#version KubernetesCluster#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>amd_gpu_device_metrics_exporter_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#amd_gpu_device_metrics_exporter_plugin KubernetesCluster#amd_gpu_device_metrics_exporter_plugin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amdGpuDeviceMetricsExporterPlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}", isOptional: true)]
            public digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDeviceMetricsExporterPlugin? AmdGpuDeviceMetricsExporterPlugin
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDeviceMetricsExporterPlugin?>();
            }

            /// <summary>amd_gpu_device_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#amd_gpu_device_plugin KubernetesCluster#amd_gpu_device_plugin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amdGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDevicePlugin\"}", isOptional: true)]
            public digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDevicePlugin? AmdGpuDevicePlugin
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDevicePlugin?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#auto_upgrade KubernetesCluster#auto_upgrade}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoUpgrade
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cluster_autoscaler_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#cluster_autoscaler_configuration KubernetesCluster#cluster_autoscaler_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterAutoscalerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClusterAutoscalerConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#cluster_subnet KubernetesCluster#cluster_subnet}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterSubnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterSubnet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>control_plane_firewall block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#control_plane_firewall KubernetesCluster#control_plane_firewall}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controlPlaneFirewall", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterControlPlaneFirewall\"}", isOptional: true)]
            public digitalocean.KubernetesCluster.IKubernetesClusterControlPlaneFirewall? ControlPlaneFirewall
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterControlPlaneFirewall?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#destroy_all_associated_resources KubernetesCluster#destroy_all_associated_resources}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destroyAllAssociatedResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DestroyAllAssociatedResources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#ha KubernetesCluster#ha}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ha", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ha
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#id KubernetesCluster#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#kubeconfig_expire_seconds KubernetesCluster#kubeconfig_expire_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kubeconfigExpireSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KubeconfigExpireSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>maintenance_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#maintenance_policy KubernetesCluster#maintenance_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterMaintenancePolicy\"}", isOptional: true)]
            public digitalocean.KubernetesCluster.IKubernetesClusterMaintenancePolicy? MaintenancePolicy
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterMaintenancePolicy?>();
            }

            /// <summary>nvidia_gpu_device_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#nvidia_gpu_device_plugin KubernetesCluster#nvidia_gpu_device_plugin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nvidiaGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNvidiaGpuDevicePlugin\"}", isOptional: true)]
            public digitalocean.KubernetesCluster.IKubernetesClusterNvidiaGpuDevicePlugin? NvidiaGpuDevicePlugin
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterNvidiaGpuDevicePlugin?>();
            }

            /// <summary>rdma_shared_device_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#rdma_shared_device_plugin KubernetesCluster#rdma_shared_device_plugin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rdmaSharedDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRdmaSharedDevicePlugin\"}", isOptional: true)]
            public digitalocean.KubernetesCluster.IKubernetesClusterRdmaSharedDevicePlugin? RdmaSharedDevicePlugin
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterRdmaSharedDevicePlugin?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#registry_integration KubernetesCluster#registry_integration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registryIntegration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RegistryIntegration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>routing_agent block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#routing_agent KubernetesCluster#routing_agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingAgent", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRoutingAgent\"}", isOptional: true)]
            public digitalocean.KubernetesCluster.IKubernetesClusterRoutingAgent? RoutingAgent
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterRoutingAgent?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#service_subnet KubernetesCluster#service_subnet}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceSubnet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceSubnet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>sso block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#sso KubernetesCluster#sso}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sso", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterSso\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Sso
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#surge_upgrade KubernetesCluster#surge_upgrade}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "surgeUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SurgeUpgrade
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#tags KubernetesCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#timeouts KubernetesCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterTimeouts\"}", isOptional: true)]
            public digitalocean.KubernetesCluster.IKubernetesClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#vpc_uuid KubernetesCluster#vpc_uuid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
