using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanKubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterConfig")]
    public class DataDigitaloceanKubernetesClusterConfig : digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#name DataDigitaloceanKubernetesCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>amd_gpu_device_metrics_exporter_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#amd_gpu_device_metrics_exporter_plugin DataDigitaloceanKubernetesCluster#amd_gpu_device_metrics_exporter_plugin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amdGpuDeviceMetricsExporterPlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}", isOptional: true)]
        public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin? AmdGpuDeviceMetricsExporterPlugin
        {
            get;
            set;
        }

        /// <summary>amd_gpu_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#amd_gpu_device_plugin DataDigitaloceanKubernetesCluster#amd_gpu_device_plugin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amdGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDevicePlugin\"}", isOptional: true)]
        public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDevicePlugin? AmdGpuDevicePlugin
        {
            get;
            set;
        }

        private object? _clusterAutoscalerConfiguration;

        /// <summary>cluster_autoscaler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#cluster_autoscaler_configuration DataDigitaloceanKubernetesCluster#cluster_autoscaler_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterAutoscalerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClusterAutoscalerConfiguration
        {
            get => _clusterAutoscalerConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clusterAutoscalerConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#id DataDigitaloceanKubernetesCluster#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#kubeconfig_expire_seconds DataDigitaloceanKubernetesCluster#kubeconfig_expire_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kubeconfigExpireSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KubeconfigExpireSeconds
        {
            get;
            set;
        }

        /// <summary>nvidia_gpu_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#nvidia_gpu_device_plugin DataDigitaloceanKubernetesCluster#nvidia_gpu_device_plugin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvidiaGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin\"}", isOptional: true)]
        public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin? NvidiaGpuDevicePlugin
        {
            get;
            set;
        }

        /// <summary>rdma_shared_device_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#rdma_shared_device_plugin DataDigitaloceanKubernetesCluster#rdma_shared_device_plugin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rdmaSharedDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin\"}", isOptional: true)]
        public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin? RdmaSharedDevicePlugin
        {
            get;
            set;
        }

        /// <summary>routing_agent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#routing_agent DataDigitaloceanKubernetesCluster#routing_agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routingAgent", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRoutingAgent\"}", isOptional: true)]
        public digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRoutingAgent? RoutingAgent
        {
            get;
            set;
        }

        private object? _sso;

        /// <summary>sso block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#sso DataDigitaloceanKubernetesCluster#sso}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sso", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterSso\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Sso
        {
            get => _sso;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterSso[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterSso).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sso = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#tags DataDigitaloceanKubernetesCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Tags
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
