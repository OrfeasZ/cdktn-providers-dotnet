using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiInterface(nativeType: typeof(IContainerengineClusterOptions), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptions")]
    public interface IContainerengineClusterOptions
    {
        /// <summary>add_ons block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#add_ons ContainerengineCluster#add_ons}
        /// </remarks>
        [JsiiProperty(name: "addOns", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAddOns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns? AddOns
        {
            get
            {
                return null;
            }
        }

        /// <summary>admission_controller_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#admission_controller_options ContainerengineCluster#admission_controller_options}
        /// </remarks>
        [JsiiProperty(name: "admissionControllerOptions", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions? AdmissionControllerOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#ip_families ContainerengineCluster#ip_families}.</summary>
        [JsiiProperty(name: "ipFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpFamilies
        {
            get
            {
                return null;
            }
        }

        /// <summary>kubernetes_network_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#kubernetes_network_config ContainerengineCluster#kubernetes_network_config}
        /// </remarks>
        [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig? KubernetesNetworkConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>open_id_connect_discovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#open_id_connect_discovery ContainerengineCluster#open_id_connect_discovery}
        /// </remarks>
        [JsiiProperty(name: "openIdConnectDiscovery", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscovery\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery? OpenIdConnectDiscovery
        {
            get
            {
                return null;
            }
        }

        /// <summary>open_id_connect_token_authentication_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#open_id_connect_token_authentication_config ContainerengineCluster#open_id_connect_token_authentication_config}
        /// </remarks>
        [JsiiProperty(name: "openIdConnectTokenAuthenticationConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig? OpenIdConnectTokenAuthenticationConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>persistent_volume_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#persistent_volume_config ContainerengineCluster#persistent_volume_config}
        /// </remarks>
        [JsiiProperty(name: "persistentVolumeConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsPersistentVolumeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerengineCluster.IContainerengineClusterOptionsPersistentVolumeConfig? PersistentVolumeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_lb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#service_lb_config ContainerengineCluster#service_lb_config}
        /// </remarks>
        [JsiiProperty(name: "serviceLbConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsServiceLbConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ContainerengineCluster.IContainerengineClusterOptionsServiceLbConfig? ServiceLbConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#service_lb_subnet_ids ContainerengineCluster#service_lb_subnet_ids}.</summary>
        [JsiiProperty(name: "serviceLbSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ServiceLbSubnetIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineClusterOptions), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptions")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineCluster.IContainerengineClusterOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>add_ons block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#add_ons ContainerengineCluster#add_ons}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addOns", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAddOns\"}", isOptional: true)]
            public oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns? AddOns
            {
                get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns?>();
            }

            /// <summary>admission_controller_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#admission_controller_options ContainerengineCluster#admission_controller_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "admissionControllerOptions", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptions\"}", isOptional: true)]
            public oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions? AdmissionControllerOptions
            {
                get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#ip_families ContainerengineCluster#ip_families}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpFamilies
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>kubernetes_network_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#kubernetes_network_config ContainerengineCluster#kubernetes_network_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig\"}", isOptional: true)]
            public oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig? KubernetesNetworkConfig
            {
                get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig?>();
            }

            /// <summary>open_id_connect_discovery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#open_id_connect_discovery ContainerengineCluster#open_id_connect_discovery}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openIdConnectDiscovery", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscovery\"}", isOptional: true)]
            public oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery? OpenIdConnectDiscovery
            {
                get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery?>();
            }

            /// <summary>open_id_connect_token_authentication_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#open_id_connect_token_authentication_config ContainerengineCluster#open_id_connect_token_authentication_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openIdConnectTokenAuthenticationConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig\"}", isOptional: true)]
            public oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig? OpenIdConnectTokenAuthenticationConfig
            {
                get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig?>();
            }

            /// <summary>persistent_volume_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#persistent_volume_config ContainerengineCluster#persistent_volume_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistentVolumeConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsPersistentVolumeConfig\"}", isOptional: true)]
            public oci.ContainerengineCluster.IContainerengineClusterOptionsPersistentVolumeConfig? PersistentVolumeConfig
            {
                get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsPersistentVolumeConfig?>();
            }

            /// <summary>service_lb_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#service_lb_config ContainerengineCluster#service_lb_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceLbConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsServiceLbConfig\"}", isOptional: true)]
            public oci.ContainerengineCluster.IContainerengineClusterOptionsServiceLbConfig? ServiceLbConfig
            {
                get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsServiceLbConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#service_lb_subnet_ids ContainerengineCluster#service_lb_subnet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceLbSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ServiceLbSubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
