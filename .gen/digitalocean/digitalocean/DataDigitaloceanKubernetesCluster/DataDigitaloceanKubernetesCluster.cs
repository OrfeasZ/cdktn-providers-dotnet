using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanKubernetesCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster digitalocean_kubernetes_cluster}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesCluster), fullyQualifiedName: "digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterConfig\"}}]")]
    public class DataDigitaloceanKubernetesCluster : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster digitalocean_kubernetes_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataDigitaloceanKubernetesCluster(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanKubernetesCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanKubernetesCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataDigitaloceanKubernetesCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataDigitaloceanKubernetesCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataDigitaloceanKubernetesCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataDigitaloceanKubernetesCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataDigitaloceanKubernetesCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/kubernetes_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataDigitaloceanKubernetesCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataDigitaloceanKubernetesCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAmdGpuDeviceMetricsExporterPlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}}]")]
        public virtual void PutAmdGpuDeviceMetricsExporterPlugin(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAmdGpuDevicePlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDevicePlugin\"}}]")]
        public virtual void PutAmdGpuDevicePlugin(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDevicePlugin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDevicePlugin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClusterAutoscalerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClusterAutoscalerConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvidiaGpuDevicePlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin\"}}]")]
        public virtual void PutNvidiaGpuDevicePlugin(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRdmaSharedDevicePlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin\"}}]")]
        public virtual void PutRdmaSharedDevicePlugin(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutingAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRoutingAgent\"}}]")]
        public virtual void PutRoutingAgent(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRoutingAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRoutingAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSso", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterSso\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSso(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterSso[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterSso).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterSso).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmdGpuDeviceMetricsExporterPlugin")]
        public virtual void ResetAmdGpuDeviceMetricsExporterPlugin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAmdGpuDevicePlugin")]
        public virtual void ResetAmdGpuDevicePlugin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterAutoscalerConfiguration")]
        public virtual void ResetClusterAutoscalerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubeconfigExpireSeconds")]
        public virtual void ResetKubeconfigExpireSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNvidiaGpuDevicePlugin")]
        public virtual void ResetNvidiaGpuDevicePlugin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRdmaSharedDevicePlugin")]
        public virtual void ResetRdmaSharedDevicePlugin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingAgent")]
        public virtual void ResetRoutingAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSso")]
        public virtual void ResetSso()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesCluster))!;

        [JsiiProperty(name: "amdGpuDeviceMetricsExporterPlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPluginOutputReference\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPluginOutputReference AmdGpuDeviceMetricsExporterPlugin
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPluginOutputReference>()!;
        }

        [JsiiProperty(name: "amdGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDevicePluginOutputReference\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDevicePluginOutputReference AmdGpuDevicePlugin
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDevicePluginOutputReference>()!;
        }

        [JsiiProperty(name: "autoUpgrade", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoUpgrade
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clusterAutoscalerConfiguration", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfigurationList\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfigurationList ClusterAutoscalerConfiguration
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfigurationList>()!;
        }

        [JsiiProperty(name: "clusterSubnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterSubnet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "controlPlaneFirewall", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterControlPlaneFirewallList\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterControlPlaneFirewallList ControlPlaneFirewall
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterControlPlaneFirewallList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ha", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Ha
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ipv4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubeConfig", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterKubeConfigList\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterKubeConfigList KubeConfig
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterKubeConfigList>()!;
        }

        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterMaintenancePolicyList\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterMaintenancePolicyList MaintenancePolicy
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterMaintenancePolicyList>()!;
        }

        [JsiiProperty(name: "nodePool", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNodePoolList\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNodePoolList NodePool
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNodePoolList>()!;
        }

        [JsiiProperty(name: "nvidiaGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNvidiaGpuDevicePluginOutputReference\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNvidiaGpuDevicePluginOutputReference NvidiaGpuDevicePlugin
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNvidiaGpuDevicePluginOutputReference>()!;
        }

        [JsiiProperty(name: "rdmaSharedDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRdmaSharedDevicePluginOutputReference\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRdmaSharedDevicePluginOutputReference RdmaSharedDevicePlugin
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRdmaSharedDevicePluginOutputReference>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routingAgent", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRoutingAgentOutputReference\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRoutingAgentOutputReference RoutingAgent
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRoutingAgentOutputReference>()!;
        }

        [JsiiProperty(name: "serviceSubnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceSubnet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sso", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterSsoList\"}")]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterSsoList Sso
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterSsoList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "surgeUpgrade", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SurgeUpgrade
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Urn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amdGpuDeviceMetricsExporterPluginInput", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin? AmdGpuDeviceMetricsExporterPluginInput
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDeviceMetricsExporterPlugin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "amdGpuDevicePluginInput", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterAmdGpuDevicePlugin\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDevicePlugin? AmdGpuDevicePluginInput
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterAmdGpuDevicePlugin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterAutoscalerConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClusterAutoscalerConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubeconfigExpireSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? KubeconfigExpireSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nvidiaGpuDevicePluginInput", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin? NvidiaGpuDevicePluginInput
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterNvidiaGpuDevicePlugin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rdmaSharedDevicePluginInput", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin? RdmaSharedDevicePluginInput
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRdmaSharedDevicePlugin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingAgentInput", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterRoutingAgent\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRoutingAgent? RoutingAgentInput
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanKubernetesCluster.IDataDigitaloceanKubernetesClusterRoutingAgent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanKubernetesCluster.DataDigitaloceanKubernetesClusterSso\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SsoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kubeconfigExpireSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KubeconfigExpireSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
