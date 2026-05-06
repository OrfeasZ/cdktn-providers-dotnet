using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterConfig")]
    public interface IOpensearchOpensearchClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#compartment_id OpensearchOpensearchCluster#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_count OpensearchOpensearchCluster#data_node_count}.</summary>
        [JsiiProperty(name: "dataNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double DataNodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_memory_gb OpensearchOpensearchCluster#data_node_host_memory_gb}.</summary>
        [JsiiProperty(name: "dataNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        double DataNodeHostMemoryGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_ocpu_count OpensearchOpensearchCluster#data_node_host_ocpu_count}.</summary>
        [JsiiProperty(name: "dataNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        double DataNodeHostOcpuCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_type OpensearchOpensearchCluster#data_node_host_type}.</summary>
        [JsiiProperty(name: "dataNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
        string DataNodeHostType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_storage_gb OpensearchOpensearchCluster#data_node_storage_gb}.</summary>
        [JsiiProperty(name: "dataNodeStorageGb", typeJson: "{\"primitive\":\"number\"}")]
        double DataNodeStorageGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#display_name OpensearchOpensearchCluster#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_count OpensearchOpensearchCluster#master_node_count}.</summary>
        [JsiiProperty(name: "masterNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double MasterNodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_memory_gb OpensearchOpensearchCluster#master_node_host_memory_gb}.</summary>
        [JsiiProperty(name: "masterNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        double MasterNodeHostMemoryGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_ocpu_count OpensearchOpensearchCluster#master_node_host_ocpu_count}.</summary>
        [JsiiProperty(name: "masterNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        double MasterNodeHostOcpuCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_type OpensearchOpensearchCluster#master_node_host_type}.</summary>
        [JsiiProperty(name: "masterNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
        string MasterNodeHostType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_node_count OpensearchOpensearchCluster#opendashboard_node_count}.</summary>
        [JsiiProperty(name: "opendashboardNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double OpendashboardNodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_node_host_memory_gb OpensearchOpensearchCluster#opendashboard_node_host_memory_gb}.</summary>
        [JsiiProperty(name: "opendashboardNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
        double OpendashboardNodeHostMemoryGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_node_host_ocpu_count OpensearchOpensearchCluster#opendashboard_node_host_ocpu_count}.</summary>
        [JsiiProperty(name: "opendashboardNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        double OpendashboardNodeHostOcpuCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#software_version OpensearchOpensearchCluster#software_version}.</summary>
        [JsiiProperty(name: "softwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SoftwareVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#subnet_compartment_id OpensearchOpensearchCluster#subnet_compartment_id}.</summary>
        [JsiiProperty(name: "subnetCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetCompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#subnet_id OpensearchOpensearchCluster#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#vcn_compartment_id OpensearchOpensearchCluster#vcn_compartment_id}.</summary>
        [JsiiProperty(name: "vcnCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string VcnCompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#vcn_id OpensearchOpensearchCluster#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        string VcnId
        {
            get;
        }

        /// <summary>certificate_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#certificate_config OpensearchOpensearchCluster#certificate_config}
        /// </remarks>
        [JsiiProperty(name: "certificateConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig? CertificateConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#configure_outbound_cluster_trigger OpensearchOpensearchCluster#configure_outbound_cluster_trigger}.</summary>
        [JsiiProperty(name: "configureOutboundClusterTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConfigureOutboundClusterTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_bare_metal_shape OpensearchOpensearchCluster#data_node_host_bare_metal_shape}.</summary>
        [JsiiProperty(name: "dataNodeHostBareMetalShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataNodeHostBareMetalShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_shape OpensearchOpensearchCluster#data_node_host_shape}.</summary>
        [JsiiProperty(name: "dataNodeHostShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataNodeHostShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#defined_tags OpensearchOpensearchCluster#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#freeform_tags OpensearchOpensearchCluster#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#id OpensearchOpensearchCluster#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#inbound_cluster_ids OpensearchOpensearchCluster#inbound_cluster_ids}.</summary>
        [JsiiProperty(name: "inboundClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InboundClusterIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#maintenance_details OpensearchOpensearchCluster#maintenance_details}
        /// </remarks>
        [JsiiProperty(name: "maintenanceDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterMaintenanceDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterMaintenanceDetails? MaintenanceDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_bare_metal_shape OpensearchOpensearchCluster#master_node_host_bare_metal_shape}.</summary>
        [JsiiProperty(name: "masterNodeHostBareMetalShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterNodeHostBareMetalShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_shape OpensearchOpensearchCluster#master_node_host_shape}.</summary>
        [JsiiProperty(name: "masterNodeHostShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterNodeHostShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#nsg_id OpensearchOpensearchCluster#nsg_id}.</summary>
        [JsiiProperty(name: "nsgId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NsgId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_node_host_shape OpensearchOpensearchCluster#opendashboard_node_host_shape}.</summary>
        [JsiiProperty(name: "opendashboardNodeHostShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpendashboardNodeHostShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>outbound_cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#outbound_cluster_config OpensearchOpensearchCluster#outbound_cluster_config}
        /// </remarks>
        [JsiiProperty(name: "outboundClusterConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig? OutboundClusterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#reverse_connection_endpoint_customer_ips OpensearchOpensearchCluster#reverse_connection_endpoint_customer_ips}.</summary>
        [JsiiProperty(name: "reverseConnectionEndpointCustomerIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReverseConnectionEndpointCustomerIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_count OpensearchOpensearchCluster#search_node_count}.</summary>
        [JsiiProperty(name: "searchNodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SearchNodeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_host_memory_gb OpensearchOpensearchCluster#search_node_host_memory_gb}.</summary>
        [JsiiProperty(name: "searchNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SearchNodeHostMemoryGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_host_ocpu_count OpensearchOpensearchCluster#search_node_host_ocpu_count}.</summary>
        [JsiiProperty(name: "searchNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SearchNodeHostOcpuCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_host_shape OpensearchOpensearchCluster#search_node_host_shape}.</summary>
        [JsiiProperty(name: "searchNodeHostShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SearchNodeHostShape
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_host_type OpensearchOpensearchCluster#search_node_host_type}.</summary>
        [JsiiProperty(name: "searchNodeHostType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SearchNodeHostType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_storage_gb OpensearchOpensearchCluster#search_node_storage_gb}.</summary>
        [JsiiProperty(name: "searchNodeStorageGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SearchNodeStorageGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_attributes OpensearchOpensearchCluster#security_attributes}.</summary>
        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SecurityAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_master_user_name OpensearchOpensearchCluster#security_master_user_name}.</summary>
        [JsiiProperty(name: "securityMasterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityMasterUserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_master_user_password_hash OpensearchOpensearchCluster#security_master_user_password_hash}.</summary>
        [JsiiProperty(name: "securityMasterUserPasswordHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityMasterUserPasswordHash
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_mode OpensearchOpensearchCluster#security_mode}.</summary>
        [JsiiProperty(name: "securityMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>security_saml_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_saml_config OpensearchOpensearchCluster#security_saml_config}
        /// </remarks>
        [JsiiProperty(name: "securitySamlConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig? SecuritySamlConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#system_tags OpensearchOpensearchCluster#system_tags}.</summary>
        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SystemTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#timeouts OpensearchOpensearchCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#upgrade_major_version_trigger OpensearchOpensearchCluster#upgrade_major_version_trigger}.</summary>
        [JsiiProperty(name: "upgradeMajorVersionTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UpgradeMajorVersionTrigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#compartment_id OpensearchOpensearchCluster#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_count OpensearchOpensearchCluster#data_node_count}.</summary>
            [JsiiProperty(name: "dataNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double DataNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_memory_gb OpensearchOpensearchCluster#data_node_host_memory_gb}.</summary>
            [JsiiProperty(name: "dataNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
            public double DataNodeHostMemoryGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_ocpu_count OpensearchOpensearchCluster#data_node_host_ocpu_count}.</summary>
            [JsiiProperty(name: "dataNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
            public double DataNodeHostOcpuCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_type OpensearchOpensearchCluster#data_node_host_type}.</summary>
            [JsiiProperty(name: "dataNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
            public string DataNodeHostType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_storage_gb OpensearchOpensearchCluster#data_node_storage_gb}.</summary>
            [JsiiProperty(name: "dataNodeStorageGb", typeJson: "{\"primitive\":\"number\"}")]
            public double DataNodeStorageGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#display_name OpensearchOpensearchCluster#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_count OpensearchOpensearchCluster#master_node_count}.</summary>
            [JsiiProperty(name: "masterNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MasterNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_memory_gb OpensearchOpensearchCluster#master_node_host_memory_gb}.</summary>
            [JsiiProperty(name: "masterNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
            public double MasterNodeHostMemoryGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_ocpu_count OpensearchOpensearchCluster#master_node_host_ocpu_count}.</summary>
            [JsiiProperty(name: "masterNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MasterNodeHostOcpuCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_type OpensearchOpensearchCluster#master_node_host_type}.</summary>
            [JsiiProperty(name: "masterNodeHostType", typeJson: "{\"primitive\":\"string\"}")]
            public string MasterNodeHostType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_node_count OpensearchOpensearchCluster#opendashboard_node_count}.</summary>
            [JsiiProperty(name: "opendashboardNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double OpendashboardNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_node_host_memory_gb OpensearchOpensearchCluster#opendashboard_node_host_memory_gb}.</summary>
            [JsiiProperty(name: "opendashboardNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}")]
            public double OpendashboardNodeHostMemoryGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_node_host_ocpu_count OpensearchOpensearchCluster#opendashboard_node_host_ocpu_count}.</summary>
            [JsiiProperty(name: "opendashboardNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
            public double OpendashboardNodeHostOcpuCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#software_version OpensearchOpensearchCluster#software_version}.</summary>
            [JsiiProperty(name: "softwareVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SoftwareVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#subnet_compartment_id OpensearchOpensearchCluster#subnet_compartment_id}.</summary>
            [JsiiProperty(name: "subnetCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetCompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#subnet_id OpensearchOpensearchCluster#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#vcn_compartment_id OpensearchOpensearchCluster#vcn_compartment_id}.</summary>
            [JsiiProperty(name: "vcnCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string VcnCompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#vcn_id OpensearchOpensearchCluster#vcn_id}.</summary>
            [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
            public string VcnId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>certificate_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#certificate_config OpensearchOpensearchCluster#certificate_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfig\"}", isOptional: true)]
            public oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig? CertificateConfig
            {
                get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#configure_outbound_cluster_trigger OpensearchOpensearchCluster#configure_outbound_cluster_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureOutboundClusterTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConfigureOutboundClusterTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_bare_metal_shape OpensearchOpensearchCluster#data_node_host_bare_metal_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataNodeHostBareMetalShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataNodeHostBareMetalShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#data_node_host_shape OpensearchOpensearchCluster#data_node_host_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataNodeHostShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataNodeHostShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#defined_tags OpensearchOpensearchCluster#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#freeform_tags OpensearchOpensearchCluster#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#id OpensearchOpensearchCluster#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#inbound_cluster_ids OpensearchOpensearchCluster#inbound_cluster_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inboundClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InboundClusterIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>maintenance_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#maintenance_details OpensearchOpensearchCluster#maintenance_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterMaintenanceDetails\"}", isOptional: true)]
            public oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterMaintenanceDetails? MaintenanceDetails
            {
                get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterMaintenanceDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_bare_metal_shape OpensearchOpensearchCluster#master_node_host_bare_metal_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterNodeHostBareMetalShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterNodeHostBareMetalShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#master_node_host_shape OpensearchOpensearchCluster#master_node_host_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterNodeHostShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterNodeHostShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#nsg_id OpensearchOpensearchCluster#nsg_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nsgId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NsgId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#opendashboard_node_host_shape OpensearchOpensearchCluster#opendashboard_node_host_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opendashboardNodeHostShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpendashboardNodeHostShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>outbound_cluster_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#outbound_cluster_config OpensearchOpensearchCluster#outbound_cluster_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outboundClusterConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterOutboundClusterConfig\"}", isOptional: true)]
            public oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig? OutboundClusterConfig
            {
                get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterOutboundClusterConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#reverse_connection_endpoint_customer_ips OpensearchOpensearchCluster#reverse_connection_endpoint_customer_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reverseConnectionEndpointCustomerIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReverseConnectionEndpointCustomerIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_count OpensearchOpensearchCluster#search_node_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchNodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SearchNodeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_host_memory_gb OpensearchOpensearchCluster#search_node_host_memory_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchNodeHostMemoryGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SearchNodeHostMemoryGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_host_ocpu_count OpensearchOpensearchCluster#search_node_host_ocpu_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchNodeHostOcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SearchNodeHostOcpuCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_host_shape OpensearchOpensearchCluster#search_node_host_shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchNodeHostShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SearchNodeHostShape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_host_type OpensearchOpensearchCluster#search_node_host_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchNodeHostType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SearchNodeHostType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#search_node_storage_gb OpensearchOpensearchCluster#search_node_storage_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchNodeStorageGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SearchNodeStorageGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_attributes OpensearchOpensearchCluster#security_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SecurityAttributes
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_master_user_name OpensearchOpensearchCluster#security_master_user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityMasterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityMasterUserName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_master_user_password_hash OpensearchOpensearchCluster#security_master_user_password_hash}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityMasterUserPasswordHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityMasterUserPasswordHash
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_mode OpensearchOpensearchCluster#security_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>security_saml_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#security_saml_config OpensearchOpensearchCluster#security_saml_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securitySamlConfig", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecuritySamlConfig\"}", isOptional: true)]
            public oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig? SecuritySamlConfig
            {
                get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecuritySamlConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#system_tags OpensearchOpensearchCluster#system_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SystemTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#timeouts OpensearchOpensearchCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterTimeouts\"}", isOptional: true)]
            public oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#upgrade_major_version_trigger OpensearchOpensearchCluster#upgrade_major_version_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeMajorVersionTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UpgradeMajorVersionTrigger
            {
                get => GetInstanceProperty<double?>();
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
