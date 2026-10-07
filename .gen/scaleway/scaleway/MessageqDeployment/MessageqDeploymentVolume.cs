using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MessageqDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.messageqDeployment.MessageqDeploymentVolume")]
    public class MessageqDeploymentVolume : scaleway.MessageqDeployment.IMessageqDeploymentVolume
    {
        /// <summary>Volume size in GB. Can be updated via Upgrade without recreating the deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/messageq_deployment#size_in_gb MessageqDeployment#size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeInGb
        {
            get;
            set;
        }

        /// <summary>Volume type (sbs_5k, sbs_15k).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs/resources/messageq_deployment#type MessageqDeployment#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
