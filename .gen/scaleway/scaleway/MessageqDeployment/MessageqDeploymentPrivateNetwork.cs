using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MessageqDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.messageqDeployment.MessageqDeploymentPrivateNetwork")]
    public class MessageqDeploymentPrivateNetwork : scaleway.MessageqDeployment.IMessageqDeploymentPrivateNetwork
    {
        /// <summary>UUID of the Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/messageq_deployment#private_network_id MessageqDeployment#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateNetworkId
        {
            get;
            set;
        }
    }
}
