using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineClusterPublicApiEndpointDecommissionManager
{
    [JsiiByValue(fqn: "oci.containerengineClusterPublicApiEndpointDecommissionManager.ContainerengineClusterPublicApiEndpointDecommissionManagerTimeouts")]
    public class ContainerengineClusterPublicApiEndpointDecommissionManagerTimeouts : oci.ContainerengineClusterPublicApiEndpointDecommissionManager.IContainerengineClusterPublicApiEndpointDecommissionManagerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/containerengine_cluster_public_api_endpoint_decommission_manager#create ContainerengineClusterPublicApiEndpointDecommissionManager#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/containerengine_cluster_public_api_endpoint_decommission_manager#delete ContainerengineClusterPublicApiEndpointDecommissionManager#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/containerengine_cluster_public_api_endpoint_decommission_manager#update ContainerengineClusterPublicApiEndpointDecommissionManager#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
