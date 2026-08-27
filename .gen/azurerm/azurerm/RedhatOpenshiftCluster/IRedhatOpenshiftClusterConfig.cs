using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    [JsiiInterface(nativeType: typeof(IRedhatOpenshiftClusterConfig), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterConfig")]
    public interface IRedhatOpenshiftClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>api_server_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#api_server_profile RedhatOpenshiftCluster#api_server_profile}
        /// </remarks>
        [JsiiProperty(name: "apiServerProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterApiServerProfile\"}")]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterApiServerProfile ApiServerProfile
        {
            get;
        }

        /// <summary>cluster_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#cluster_profile RedhatOpenshiftCluster#cluster_profile}
        /// </remarks>
        [JsiiProperty(name: "clusterProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterClusterProfile\"}")]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterClusterProfile ClusterProfile
        {
            get;
        }

        /// <summary>ingress_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#ingress_profile RedhatOpenshiftCluster#ingress_profile}
        /// </remarks>
        [JsiiProperty(name: "ingressProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfile\"}")]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIngressProfile IngressProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#location RedhatOpenshiftCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>main_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#main_profile RedhatOpenshiftCluster#main_profile}
        /// </remarks>
        [JsiiProperty(name: "mainProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterMainProfile\"}")]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterMainProfile MainProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#name RedhatOpenshiftCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>network_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#network_profile RedhatOpenshiftCluster#network_profile}
        /// </remarks>
        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfile\"}")]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile NetworkProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#resource_group_name RedhatOpenshiftCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>worker_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#worker_profile RedhatOpenshiftCluster#worker_profile}
        /// </remarks>
        [JsiiProperty(name: "workerProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterWorkerProfile\"}")]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterWorkerProfile WorkerProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#id RedhatOpenshiftCluster#id}.</summary>
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

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#identity RedhatOpenshiftCluster#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>platform_workload_identity_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#platform_workload_identity_profile RedhatOpenshiftCluster#platform_workload_identity_profile}
        /// </remarks>
        [JsiiProperty(name: "platformWorkloadIdentityProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile? PlatformWorkloadIdentityProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#service_principal RedhatOpenshiftCluster#service_principal}
        /// </remarks>
        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterServicePrincipal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterServicePrincipal? ServicePrincipal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#tags RedhatOpenshiftCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#timeouts RedhatOpenshiftCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedhatOpenshiftClusterConfig), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>api_server_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#api_server_profile RedhatOpenshiftCluster#api_server_profile}
            /// </remarks>
            [JsiiProperty(name: "apiServerProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterApiServerProfile\"}")]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterApiServerProfile ApiServerProfile
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterApiServerProfile>()!;
            }

            /// <summary>cluster_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#cluster_profile RedhatOpenshiftCluster#cluster_profile}
            /// </remarks>
            [JsiiProperty(name: "clusterProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterClusterProfile\"}")]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterClusterProfile ClusterProfile
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterClusterProfile>()!;
            }

            /// <summary>ingress_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#ingress_profile RedhatOpenshiftCluster#ingress_profile}
            /// </remarks>
            [JsiiProperty(name: "ingressProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfile\"}")]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIngressProfile IngressProfile
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIngressProfile>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#location RedhatOpenshiftCluster#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>main_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#main_profile RedhatOpenshiftCluster#main_profile}
            /// </remarks>
            [JsiiProperty(name: "mainProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterMainProfile\"}")]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterMainProfile MainProfile
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterMainProfile>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#name RedhatOpenshiftCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>network_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#network_profile RedhatOpenshiftCluster#network_profile}
            /// </remarks>
            [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfile\"}")]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile NetworkProfile
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterNetworkProfile>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#resource_group_name RedhatOpenshiftCluster#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>worker_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#worker_profile RedhatOpenshiftCluster#worker_profile}
            /// </remarks>
            [JsiiProperty(name: "workerProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterWorkerProfile\"}")]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterWorkerProfile WorkerProfile
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterWorkerProfile>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#id RedhatOpenshiftCluster#id}.</summary>
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

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#identity RedhatOpenshiftCluster#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIdentity\"}", isOptional: true)]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIdentity?>();
            }

            /// <summary>platform_workload_identity_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#platform_workload_identity_profile RedhatOpenshiftCluster#platform_workload_identity_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "platformWorkloadIdentityProfile", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfile\"}", isOptional: true)]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile? PlatformWorkloadIdentityProfile
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile?>();
            }

            /// <summary>service_principal block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#service_principal RedhatOpenshiftCluster#service_principal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterServicePrincipal\"}", isOptional: true)]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterServicePrincipal? ServicePrincipal
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterServicePrincipal?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#tags RedhatOpenshiftCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/redhat_openshift_cluster#timeouts RedhatOpenshiftCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterTimeouts\"}", isOptional: true)]
            public azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
