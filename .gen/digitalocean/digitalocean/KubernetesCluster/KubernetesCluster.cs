using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.KubernetesCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster digitalocean_kubernetes_cluster}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.KubernetesCluster.KubernetesCluster), fullyQualifiedName: "digitalocean.kubernetesCluster.KubernetesCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterConfig\"}}]")]
    public class KubernetesCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster digitalocean_kubernetes_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KubernetesCluster(Constructs.Construct scope, string id, digitalocean.KubernetesCluster.IKubernetesClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.KubernetesCluster.IKubernetesClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a KubernetesCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KubernetesCluster to import.</param>
        /// <param name="importFromId">The id of the existing KubernetesCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KubernetesCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KubernetesCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/kubernetes_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KubernetesCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KubernetesCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.KubernetesCluster.KubernetesCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAmdGpuDeviceMetricsExporterPlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}}]")]
        public virtual void PutAmdGpuDeviceMetricsExporterPlugin(digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDeviceMetricsExporterPlugin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDeviceMetricsExporterPlugin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAmdGpuDevicePlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDevicePlugin\"}}]")]
        public virtual void PutAmdGpuDevicePlugin(digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDevicePlugin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDevicePlugin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClusterAutoscalerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClusterAutoscalerConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.KubernetesCluster.IKubernetesClusterClusterAutoscalerConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.KubernetesCluster.IKubernetesClusterClusterAutoscalerConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.KubernetesCluster.IKubernetesClusterClusterAutoscalerConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putControlPlaneFirewall", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterControlPlaneFirewall\"}}]")]
        public virtual void PutControlPlaneFirewall(digitalocean.KubernetesCluster.IKubernetesClusterControlPlaneFirewall @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterControlPlaneFirewall)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenancePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterMaintenancePolicy\"}}]")]
        public virtual void PutMaintenancePolicy(digitalocean.KubernetesCluster.IKubernetesClusterMaintenancePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterMaintenancePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodePool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNodePool\"}}]")]
        public virtual void PutNodePool(digitalocean.KubernetesCluster.IKubernetesClusterNodePool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterNodePool)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvidiaGpuDevicePlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNvidiaGpuDevicePlugin\"}}]")]
        public virtual void PutNvidiaGpuDevicePlugin(digitalocean.KubernetesCluster.IKubernetesClusterNvidiaGpuDevicePlugin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterNvidiaGpuDevicePlugin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRdmaSharedDevicePlugin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRdmaSharedDevicePlugin\"}}]")]
        public virtual void PutRdmaSharedDevicePlugin(digitalocean.KubernetesCluster.IKubernetesClusterRdmaSharedDevicePlugin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterRdmaSharedDevicePlugin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutingAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRoutingAgent\"}}]")]
        public virtual void PutRoutingAgent(digitalocean.KubernetesCluster.IKubernetesClusterRoutingAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterRoutingAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSso", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterSso\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSso(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.KubernetesCluster.IKubernetesClusterSso[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.KubernetesCluster.IKubernetesClusterSso).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.KubernetesCluster.IKubernetesClusterSso).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(digitalocean.KubernetesCluster.IKubernetesClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.KubernetesCluster.IKubernetesClusterTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetAutoUpgrade")]
        public virtual void ResetAutoUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterAutoscalerConfiguration")]
        public virtual void ResetClusterAutoscalerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterSubnet")]
        public virtual void ResetClusterSubnet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetControlPlaneFirewall")]
        public virtual void ResetControlPlaneFirewall()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestroyAllAssociatedResources")]
        public virtual void ResetDestroyAllAssociatedResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHa")]
        public virtual void ResetHa()
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

        [JsiiMethod(name: "resetMaintenancePolicy")]
        public virtual void ResetMaintenancePolicy()
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

        [JsiiMethod(name: "resetRegistryIntegration")]
        public virtual void ResetRegistryIntegration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingAgent")]
        public virtual void ResetRoutingAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceSubnet")]
        public virtual void ResetServiceSubnet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSso")]
        public virtual void ResetSso()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSurgeUpgrade")]
        public virtual void ResetSurgeUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcUuid")]
        public virtual void ResetVpcUuid()
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
        = GetStaticProperty<string>(typeof(digitalocean.KubernetesCluster.KubernetesCluster))!;

        [JsiiProperty(name: "amdGpuDeviceMetricsExporterPlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDeviceMetricsExporterPluginOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterAmdGpuDeviceMetricsExporterPluginOutputReference AmdGpuDeviceMetricsExporterPlugin
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterAmdGpuDeviceMetricsExporterPluginOutputReference>()!;
        }

        [JsiiProperty(name: "amdGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDevicePluginOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterAmdGpuDevicePluginOutputReference AmdGpuDevicePlugin
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterAmdGpuDevicePluginOutputReference>()!;
        }

        [JsiiProperty(name: "clusterAutoscalerConfiguration", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterClusterAutoscalerConfigurationList\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterClusterAutoscalerConfigurationList ClusterAutoscalerConfiguration
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterClusterAutoscalerConfigurationList>()!;
        }

        [JsiiProperty(name: "controlPlaneFirewall", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterControlPlaneFirewallOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterControlPlaneFirewallOutputReference ControlPlaneFirewall
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterControlPlaneFirewallOutputReference>()!;
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

        [JsiiProperty(name: "ipv4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv4Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubeConfig", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterKubeConfigList\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterKubeConfigList KubeConfig
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterKubeConfigList>()!;
        }

        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterMaintenancePolicyOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterMaintenancePolicyOutputReference MaintenancePolicy
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterMaintenancePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "nodePool", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNodePoolOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterNodePoolOutputReference NodePool
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterNodePoolOutputReference>()!;
        }

        [JsiiProperty(name: "nvidiaGpuDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNvidiaGpuDevicePluginOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterNvidiaGpuDevicePluginOutputReference NvidiaGpuDevicePlugin
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterNvidiaGpuDevicePluginOutputReference>()!;
        }

        [JsiiProperty(name: "rdmaSharedDevicePlugin", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRdmaSharedDevicePluginOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterRdmaSharedDevicePluginOutputReference RdmaSharedDevicePlugin
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterRdmaSharedDevicePluginOutputReference>()!;
        }

        [JsiiProperty(name: "routingAgent", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRoutingAgentOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterRoutingAgentOutputReference RoutingAgent
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterRoutingAgentOutputReference>()!;
        }

        [JsiiProperty(name: "sso", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterSsoList\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterSsoList Sso
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterSsoList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterTimeoutsOutputReference\"}")]
        public virtual digitalocean.KubernetesCluster.KubernetesClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.KubernetesClusterTimeoutsOutputReference>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "amdGpuDeviceMetricsExporterPluginInput", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDeviceMetricsExporterPlugin\"}", isOptional: true)]
        public virtual digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDeviceMetricsExporterPlugin? AmdGpuDeviceMetricsExporterPluginInput
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDeviceMetricsExporterPlugin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "amdGpuDevicePluginInput", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterAmdGpuDevicePlugin\"}", isOptional: true)]
        public virtual digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDevicePlugin? AmdGpuDevicePluginInput
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterAmdGpuDevicePlugin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoUpgradeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoUpgradeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterAutoscalerConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterClusterAutoscalerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClusterAutoscalerConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterSubnetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterSubnetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "controlPlaneFirewallInput", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterControlPlaneFirewall\"}", isOptional: true)]
        public virtual digitalocean.KubernetesCluster.IKubernetesClusterControlPlaneFirewall? ControlPlaneFirewallInput
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterControlPlaneFirewall?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destroyAllAssociatedResourcesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DestroyAllAssociatedResourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "haInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HaInput
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
        [JsiiProperty(name: "maintenancePolicyInput", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterMaintenancePolicy\"}", isOptional: true)]
        public virtual digitalocean.KubernetesCluster.IKubernetesClusterMaintenancePolicy? MaintenancePolicyInput
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterMaintenancePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodePoolInput", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNodePool\"}", isOptional: true)]
        public virtual digitalocean.KubernetesCluster.IKubernetesClusterNodePool? NodePoolInput
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterNodePool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nvidiaGpuDevicePluginInput", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterNvidiaGpuDevicePlugin\"}", isOptional: true)]
        public virtual digitalocean.KubernetesCluster.IKubernetesClusterNvidiaGpuDevicePlugin? NvidiaGpuDevicePluginInput
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterNvidiaGpuDevicePlugin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rdmaSharedDevicePluginInput", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRdmaSharedDevicePlugin\"}", isOptional: true)]
        public virtual digitalocean.KubernetesCluster.IKubernetesClusterRdmaSharedDevicePlugin? RdmaSharedDevicePluginInput
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterRdmaSharedDevicePlugin?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryIntegrationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RegistryIntegrationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingAgentInput", typeJson: "{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterRoutingAgent\"}", isOptional: true)]
        public virtual digitalocean.KubernetesCluster.IKubernetesClusterRoutingAgent? RoutingAgentInput
        {
            get => GetInstanceProperty<digitalocean.KubernetesCluster.IKubernetesClusterRoutingAgent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceSubnetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceSubnetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterSso\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SsoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "surgeUpgradeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SurgeUpgradeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.kubernetesCluster.KubernetesClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcUuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcUuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AutoUpgrade
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "clusterSubnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterSubnet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destroyAllAssociatedResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DestroyAllAssociatedResources
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "ha", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Ha
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registryIntegration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RegistryIntegration
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "serviceSubnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceSubnet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "surgeUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SurgeUpgrade
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcUuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
