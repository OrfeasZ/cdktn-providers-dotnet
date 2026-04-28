using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SCluster
{
    [JsiiInterface(nativeType: typeof(IK8SClusterConfig), fullyQualifiedName: "scaleway.k8SCluster.K8SClusterConfig")]
    public interface IK8SClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The CNI plugin of the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#cni K8SCluster#cni}
        /// </remarks>
        [JsiiProperty(name: "cni", typeJson: "{\"primitive\":\"string\"}")]
        string Cni
        {
            get;
        }

        /// <summary>Delete additional resources like block volumes, load-balancers and the private network (if empty) on cluster deletion.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#delete_additional_resources K8SCluster#delete_additional_resources}
        /// </remarks>
        [JsiiProperty(name: "deleteAdditionalResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object DeleteAdditionalResources
        {
            get;
        }

        /// <summary>The name of the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#name K8SCluster#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The version of the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#version K8SCluster#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>The list of admission plugins to enable on the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#admission_plugins K8SCluster#admission_plugins}
        /// </remarks>
        [JsiiProperty(name: "admissionPlugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdmissionPlugins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional Subject Alternative Names for the Kubernetes API server certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#apiserver_cert_sans K8SCluster#apiserver_cert_sans}
        /// </remarks>
        [JsiiProperty(name: "apiserverCertSans", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApiserverCertSans
        {
            get
            {
                return null;
            }
        }

        /// <summary>autoscaler_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#autoscaler_config K8SCluster#autoscaler_config}
        /// </remarks>
        [JsiiProperty(name: "autoscalerConfig", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoscalerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.K8SCluster.IK8SClusterAutoscalerConfig? AutoscalerConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_upgrade block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#auto_upgrade K8SCluster#auto_upgrade}
        /// </remarks>
        [JsiiProperty(name: "autoUpgrade", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoUpgrade\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.K8SCluster.IK8SClusterAutoUpgrade? AutoUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>The description of the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#description K8SCluster#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of feature gates to enable on the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#feature_gates K8SCluster#feature_gates}
        /// </remarks>
        [JsiiProperty(name: "featureGates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FeatureGates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#id K8SCluster#id}.</summary>
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

        /// <summary>open_id_connect_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#open_id_connect_config K8SCluster#open_id_connect_config}
        /// </remarks>
        [JsiiProperty(name: "openIdConnectConfig", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterOpenIdConnectConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig? OpenIdConnectConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>The subnet used for the Pod CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#pod_cidr K8SCluster#pod_cidr}
        /// </remarks>
        [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PodCidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the cluster's private network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#private_network_id K8SCluster#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateNetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#project_id K8SCluster#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#region K8SCluster#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>The subnet used for the Service CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#service_cidr K8SCluster#service_cidr}
        /// </remarks>
        [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceCidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP used for the DNS Service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#service_dns_ip K8SCluster#service_dns_ip}
        /// </remarks>
        [JsiiProperty(name: "serviceDnsIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceDnsIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tags associated with the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#tags K8SCluster#tags}
        /// </remarks>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#timeouts K8SCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.K8SCluster.IK8SClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#type K8SCluster#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IK8SClusterConfig), fullyQualifiedName: "scaleway.k8SCluster.K8SClusterConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.K8SCluster.IK8SClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The CNI plugin of the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#cni K8SCluster#cni}
            /// </remarks>
            [JsiiProperty(name: "cni", typeJson: "{\"primitive\":\"string\"}")]
            public string Cni
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Delete additional resources like block volumes, load-balancers and the private network (if empty) on cluster deletion.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#delete_additional_resources K8SCluster#delete_additional_resources}
            /// </remarks>
            [JsiiProperty(name: "deleteAdditionalResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object DeleteAdditionalResources
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The name of the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#name K8SCluster#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The version of the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#version K8SCluster#version}
            /// </remarks>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The list of admission plugins to enable on the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#admission_plugins K8SCluster#admission_plugins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "admissionPlugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdmissionPlugins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Additional Subject Alternative Names for the Kubernetes API server certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#apiserver_cert_sans K8SCluster#apiserver_cert_sans}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiserverCertSans", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApiserverCertSans
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>autoscaler_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#autoscaler_config K8SCluster#autoscaler_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalerConfig", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoscalerConfig\"}", isOptional: true)]
            public scaleway.K8SCluster.IK8SClusterAutoscalerConfig? AutoscalerConfig
            {
                get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterAutoscalerConfig?>();
            }

            /// <summary>auto_upgrade block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#auto_upgrade K8SCluster#auto_upgrade}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoUpgrade", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoUpgrade\"}", isOptional: true)]
            public scaleway.K8SCluster.IK8SClusterAutoUpgrade? AutoUpgrade
            {
                get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterAutoUpgrade?>();
            }

            /// <summary>The description of the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#description K8SCluster#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The list of feature gates to enable on the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#feature_gates K8SCluster#feature_gates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "featureGates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FeatureGates
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#id K8SCluster#id}.</summary>
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

            /// <summary>open_id_connect_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#open_id_connect_config K8SCluster#open_id_connect_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openIdConnectConfig", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterOpenIdConnectConfig\"}", isOptional: true)]
            public scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig? OpenIdConnectConfig
            {
                get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig?>();
            }

            /// <summary>The subnet used for the Pod CIDR.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#pod_cidr K8SCluster#pod_cidr}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PodCidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the cluster's private network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#private_network_id K8SCluster#private_network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateNetworkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#project_id K8SCluster#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#region K8SCluster#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The subnet used for the Service CIDR.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#service_cidr K8SCluster#service_cidr}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceCidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The IP used for the DNS Service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#service_dns_ip K8SCluster#service_dns_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceDnsIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceDnsIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The tags associated with the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#tags K8SCluster#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#timeouts K8SCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterTimeouts\"}", isOptional: true)]
            public scaleway.K8SCluster.IK8SClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterTimeouts?>();
            }

            /// <summary>The type of cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/k8s_cluster#type K8SCluster#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
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
