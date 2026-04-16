using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.OpensearchDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.opensearchDeployment.OpensearchDeploymentPrivateNetwork")]
    public class OpensearchDeploymentPrivateNetwork : scaleway.OpensearchDeployment.IOpensearchDeploymentPrivateNetwork
    {
        /// <summary>UUID of the Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/opensearch_deployment#private_network_id OpensearchDeployment#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateNetworkId
        {
            get;
            set;
        }
    }
}
