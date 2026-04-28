using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanKubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanKubernetesClusterConfig), fullyQualifiedName: "digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterConfig")]
    public interface IDataDigitaloceanKubernetesClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#name DataDigitaloceanKubernetesCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>amd_gpu_device_metrics_exporter_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#amd_gpu_device_metrics_exporter_plugin DataDigitaloceanKubernetesCluster#amd_gpu_device_metrics_exporter_plugin}
        /// </remarks>
        [JsiiProperty(name: "amdGpuDeviceMetricsExporterPlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin? AmdGpuDeviceMetricsExporterPlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>amd_gpu_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#amd_gpu_device_plugin DataDigitaloceanKubernetesCluster#amd_gpu_device_plugin}
        /// </remarks>
        [JsiiProperty(name: "amdGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDevicePlugin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDevicePlugin? AmdGpuDevicePlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>cluster_autoscaler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#cluster_autoscaler_configuration DataDigitaloceanKubernetesCluster#cluster_autoscaler_configuration}
        /// </remarks>
        [JsiiProperty(name: "clusterAutoscalerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClusterAutoscalerConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#id DataDigitaloceanKubernetesCluster#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#kubeconfig_expire_seconds DataDigitaloceanKubernetesCluster#kubeconfig_expire_seconds}.</summary>
        [JsiiProperty(name: "kubeconfigExpireSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KubeconfigExpireSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>nvidia_gpu_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#nvidia_gpu_device_plugin DataDigitaloceanKubernetesCluster#nvidia_gpu_device_plugin}
        /// </remarks>
        [JsiiProperty(name: "nvidiaGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin? NvidiaGpuDevicePlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>rdma_shared_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#rdma_shared_device_plugin DataDigitaloceanKubernetesCluster#rdma_shared_device_plugin}
        /// </remarks>
        [JsiiProperty(name: "rdmaSharedDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin? RdmaSharedDevicePlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>routing_agent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#routing_agent DataDigitaloceanKubernetesCluster#routing_agent}
        /// </remarks>
        [JsiiProperty(name: "routingAgent", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRoutingAgent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRoutingAgent? RoutingAgent
        {
            get
            {
                return null;
            }
        }

        /// <summary>sso block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#sso DataDigitaloceanKubernetesCluster#sso}
        /// </remarks>
        [JsiiProperty(name: "sso", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterSso\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sso
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#tags DataDigitaloceanKubernetesCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanKubernetesClusterConfig), fullyQualifiedName: "digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#name DataDigitaloceanKubernetesCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>amd_gpu_device_metrics_exporter_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#amd_gpu_device_metrics_exporter_plugin DataDigitaloceanKubernetesCluster#amd_gpu_device_metrics_exporter_plugin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amdGpuDeviceMetricsExporterPlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}", isOptional: true)]
            public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin? AmdGpuDeviceMetricsExporterPlugin
            {
                get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin?>();
            }

            /// <summary>amd_gpu_device_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#amd_gpu_device_plugin DataDigitaloceanKubernetesCluster#amd_gpu_device_plugin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amdGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDevicePlugin\"}", isOptional: true)]
            public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDevicePlugin? AmdGpuDevicePlugin
            {
                get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDevicePlugin?>();
            }

            /// <summary>cluster_autoscaler_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#cluster_autoscaler_configuration DataDigitaloceanKubernetesCluster#cluster_autoscaler_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterAutoscalerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClusterAutoscalerConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#id DataDigitaloceanKubernetesCluster#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#kubeconfig_expire_seconds DataDigitaloceanKubernetesCluster#kubeconfig_expire_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kubeconfigExpireSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KubeconfigExpireSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>nvidia_gpu_device_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#nvidia_gpu_device_plugin DataDigitaloceanKubernetesCluster#nvidia_gpu_device_plugin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nvidiaGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin\"}", isOptional: true)]
            public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin? NvidiaGpuDevicePlugin
            {
                get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin?>();
            }

            /// <summary>rdma_shared_device_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#rdma_shared_device_plugin DataDigitaloceanKubernetesCluster#rdma_shared_device_plugin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rdmaSharedDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin\"}", isOptional: true)]
            public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin? RdmaSharedDevicePlugin
            {
                get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin?>();
            }

            /// <summary>routing_agent block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#routing_agent DataDigitaloceanKubernetesCluster#routing_agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingAgent", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRoutingAgent\"}", isOptional: true)]
            public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRoutingAgent? RoutingAgent
            {
                get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRoutingAgent?>();
            }

            /// <summary>sso block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#sso DataDigitaloceanKubernetesCluster#sso}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sso", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterSso\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Sso
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/kubernetes_cluster#tags DataDigitaloceanKubernetesCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
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
