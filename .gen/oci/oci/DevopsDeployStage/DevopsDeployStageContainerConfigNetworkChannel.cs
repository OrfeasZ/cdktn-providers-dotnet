using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsDeployStage.DevopsDeployStageContainerConfigNetworkChannel")]
    public class DevopsDeployStageContainerConfigNetworkChannel : oci.DevopsDeployStage.IDevopsDeployStageContainerConfigNetworkChannel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#network_channel_type DevopsDeployStage#network_channel_type}.</summary>
        [JsiiProperty(name: "networkChannelType", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkChannelType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#subnet_id DevopsDeployStage#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#nsg_ids DevopsDeployStage#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }
    }
}
