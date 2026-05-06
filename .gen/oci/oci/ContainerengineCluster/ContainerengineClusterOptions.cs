using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiByValue(fqn: "oci.containerengineCluster.ContainerengineClusterOptions")]
    public class ContainerengineClusterOptions : oci.ContainerengineCluster.IContainerengineClusterOptions
    {
        /// <summary>add_ons block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#add_ons ContainerengineCluster#add_ons}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addOns", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAddOns\"}", isOptional: true)]
        public oci.ContainerengineCluster.IContainerengineClusterOptionsAddOns? AddOns
        {
            get;
            set;
        }

        /// <summary>admission_controller_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#admission_controller_options ContainerengineCluster#admission_controller_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "admissionControllerOptions", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsAdmissionControllerOptions\"}", isOptional: true)]
        public oci.ContainerengineCluster.IContainerengineClusterOptionsAdmissionControllerOptions? AdmissionControllerOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#ip_families ContainerengineCluster#ip_families}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpFamilies
        {
            get;
            set;
        }

        /// <summary>kubernetes_network_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#kubernetes_network_config ContainerengineCluster#kubernetes_network_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsKubernetesNetworkConfig\"}", isOptional: true)]
        public oci.ContainerengineCluster.IContainerengineClusterOptionsKubernetesNetworkConfig? KubernetesNetworkConfig
        {
            get;
            set;
        }

        /// <summary>open_id_connect_discovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#open_id_connect_discovery ContainerengineCluster#open_id_connect_discovery}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openIdConnectDiscovery", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectDiscovery\"}", isOptional: true)]
        public oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectDiscovery? OpenIdConnectDiscovery
        {
            get;
            set;
        }

        /// <summary>open_id_connect_token_authentication_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#open_id_connect_token_authentication_config ContainerengineCluster#open_id_connect_token_authentication_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openIdConnectTokenAuthenticationConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig\"}", isOptional: true)]
        public oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig? OpenIdConnectTokenAuthenticationConfig
        {
            get;
            set;
        }

        /// <summary>persistent_volume_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#persistent_volume_config ContainerengineCluster#persistent_volume_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "persistentVolumeConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsPersistentVolumeConfig\"}", isOptional: true)]
        public oci.ContainerengineCluster.IContainerengineClusterOptionsPersistentVolumeConfig? PersistentVolumeConfig
        {
            get;
            set;
        }

        /// <summary>service_lb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#service_lb_config ContainerengineCluster#service_lb_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceLbConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsServiceLbConfig\"}", isOptional: true)]
        public oci.ContainerengineCluster.IContainerengineClusterOptionsServiceLbConfig? ServiceLbConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#service_lb_subnet_ids ContainerengineCluster#service_lb_subnet_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceLbSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ServiceLbSubnetIds
        {
            get;
            set;
        }
    }
}
