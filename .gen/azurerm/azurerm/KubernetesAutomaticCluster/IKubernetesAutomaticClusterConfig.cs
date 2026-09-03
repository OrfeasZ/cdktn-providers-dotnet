using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesAutomaticClusterConfig), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterConfig")]
    public interface IKubernetesAutomaticClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#identity KubernetesAutomaticCluster#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterIdentity\"}")]
        azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterIdentity Identity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#location KubernetesAutomaticCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#name KubernetesAutomaticCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#resource_group_name KubernetesAutomaticCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>api_server_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#api_server_access KubernetesAutomaticCluster#api_server_access}
        /// </remarks>
        [JsiiProperty(name: "apiServerAccess", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterApiServerAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterApiServerAccess? ApiServerAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>hosted_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#hosted_system KubernetesAutomaticCluster#hosted_system}
        /// </remarks>
        [JsiiProperty(name: "hostedSystem", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem? HostedSystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#id KubernetesAutomaticCluster#id}.</summary>
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

        /// <summary>private_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#private_cluster KubernetesAutomaticCluster#private_cluster}
        /// </remarks>
        [JsiiProperty(name: "privateCluster", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterPrivateCluster? PrivateCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_mesh block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#service_mesh KubernetesAutomaticCluster#service_mesh}
        /// </remarks>
        [JsiiProperty(name: "serviceMesh", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMesh\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMesh? ServiceMesh
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#tags KubernetesAutomaticCluster#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#timeouts KubernetesAutomaticCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>web_app_routing_ingress block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#web_app_routing_ingress KubernetesAutomaticCluster#web_app_routing_ingress}
        /// </remarks>
        [JsiiProperty(name: "webAppRoutingIngress", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterWebAppRoutingIngress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterWebAppRoutingIngress? WebAppRoutingIngress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesAutomaticClusterConfig), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#identity KubernetesAutomaticCluster#identity}
            /// </remarks>
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterIdentity\"}")]
            public azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterIdentity Identity
            {
                get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterIdentity>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#location KubernetesAutomaticCluster#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#name KubernetesAutomaticCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#resource_group_name KubernetesAutomaticCluster#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>api_server_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#api_server_access KubernetesAutomaticCluster#api_server_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiServerAccess", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterApiServerAccess\"}", isOptional: true)]
            public azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterApiServerAccess? ApiServerAccess
            {
                get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterApiServerAccess?>();
            }

            /// <summary>hosted_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#hosted_system KubernetesAutomaticCluster#hosted_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostedSystem", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystem\"}", isOptional: true)]
            public azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem? HostedSystem
            {
                get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#id KubernetesAutomaticCluster#id}.</summary>
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

            /// <summary>private_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#private_cluster KubernetesAutomaticCluster#private_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateCluster", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateCluster\"}", isOptional: true)]
            public azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterPrivateCluster? PrivateCluster
            {
                get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterPrivateCluster?>();
            }

            /// <summary>service_mesh block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#service_mesh KubernetesAutomaticCluster#service_mesh}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceMesh", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMesh\"}", isOptional: true)]
            public azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMesh? ServiceMesh
            {
                get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMesh?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#tags KubernetesAutomaticCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#timeouts KubernetesAutomaticCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterTimeouts\"}", isOptional: true)]
            public azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterTimeouts?>();
            }

            /// <summary>web_app_routing_ingress block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#web_app_routing_ingress KubernetesAutomaticCluster#web_app_routing_ingress}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webAppRoutingIngress", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterWebAppRoutingIngress\"}", isOptional: true)]
            public azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterWebAppRoutingIngress? WebAppRoutingIngress
            {
                get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterWebAppRoutingIngress?>();
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
