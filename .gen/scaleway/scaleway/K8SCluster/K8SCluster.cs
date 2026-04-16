using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster scaleway_k8s_cluster}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.K8SCluster.K8SCluster), fullyQualifiedName: "scaleway.k8SCluster.K8SCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.k8SCluster.K8SClusterConfig\"}}]")]
    public class K8SCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster scaleway_k8s_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public K8SCluster(Constructs.Construct scope, string id, scaleway.K8SCluster.IK8SClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.K8SCluster.IK8SClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected K8SCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected K8SCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a K8SCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the K8SCluster to import.</param>
        /// <param name="importFromId">The id of the existing K8SCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the K8SCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the K8SCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing K8SCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the K8SCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.K8SCluster.K8SCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoscalerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoscalerConfig\"}}]")]
        public virtual void PutAutoscalerConfig(scaleway.K8SCluster.IK8SClusterAutoscalerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.K8SCluster.IK8SClusterAutoscalerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoUpgrade", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoUpgrade\"}}]")]
        public virtual void PutAutoUpgrade(scaleway.K8SCluster.IK8SClusterAutoUpgrade @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.K8SCluster.IK8SClusterAutoUpgrade)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenIdConnectConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.k8SCluster.K8SClusterOpenIdConnectConfig\"}}]")]
        public virtual void PutOpenIdConnectConfig(scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.k8SCluster.K8SClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.K8SCluster.IK8SClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.K8SCluster.IK8SClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdmissionPlugins")]
        public virtual void ResetAdmissionPlugins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiserverCertSans")]
        public virtual void ResetApiserverCertSans()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalerConfig")]
        public virtual void ResetAutoscalerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoUpgrade")]
        public virtual void ResetAutoUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatureGates")]
        public virtual void ResetFeatureGates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenIdConnectConfig")]
        public virtual void ResetOpenIdConnectConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPodCidr")]
        public virtual void ResetPodCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateNetworkId")]
        public virtual void ResetPrivateNetworkId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceCidr")]
        public virtual void ResetServiceCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceDnsIp")]
        public virtual void ResetServiceDnsIp()
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

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(scaleway.K8SCluster.K8SCluster))!;

        [JsiiProperty(name: "apiserverUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiserverUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoscalerConfig", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoscalerConfigOutputReference\"}")]
        public virtual scaleway.K8SCluster.K8SClusterAutoscalerConfigOutputReference AutoscalerConfig
        {
            get => GetInstanceProperty<scaleway.K8SCluster.K8SClusterAutoscalerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "autoUpgrade", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoUpgradeOutputReference\"}")]
        public virtual scaleway.K8SCluster.K8SClusterAutoUpgradeOutputReference AutoUpgrade
        {
            get => GetInstanceProperty<scaleway.K8SCluster.K8SClusterAutoUpgradeOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubeconfig", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterKubeconfigList\"}")]
        public virtual scaleway.K8SCluster.K8SClusterKubeconfigList Kubeconfig
        {
            get => GetInstanceProperty<scaleway.K8SCluster.K8SClusterKubeconfigList>()!;
        }

        [JsiiProperty(name: "openIdConnectConfig", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterOpenIdConnectConfigOutputReference\"}")]
        public virtual scaleway.K8SCluster.K8SClusterOpenIdConnectConfigOutputReference OpenIdConnectConfig
        {
            get => GetInstanceProperty<scaleway.K8SCluster.K8SClusterOpenIdConnectConfigOutputReference>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterTimeoutsOutputReference\"}")]
        public virtual scaleway.K8SCluster.K8SClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.K8SCluster.K8SClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UpgradeAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "wildcardDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WildcardDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "admissionPluginsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AdmissionPluginsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiserverCertSansInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApiserverCertSansInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalerConfigInput", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoscalerConfig\"}", isOptional: true)]
        public virtual scaleway.K8SCluster.IK8SClusterAutoscalerConfig? AutoscalerConfigInput
        {
            get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterAutoscalerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoUpgradeInput", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoUpgrade\"}", isOptional: true)]
        public virtual scaleway.K8SCluster.IK8SClusterAutoUpgrade? AutoUpgradeInput
        {
            get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterAutoUpgrade?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cniInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CniInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAdditionalResourcesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteAdditionalResourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureGatesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? FeatureGatesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openIdConnectConfigInput", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterOpenIdConnectConfig\"}", isOptional: true)]
        public virtual scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig? OpenIdConnectConfigInput
        {
            get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PodCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateNetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceDnsIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceDnsIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.k8SCluster.K8SClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "admissionPlugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdmissionPlugins
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "apiserverCertSans", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApiserverCertSans
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cni", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cni
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteAdditionalResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeleteAdditionalResources
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "featureGates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] FeatureGates
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PodCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateNetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
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

        [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceDnsIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceDnsIp
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
