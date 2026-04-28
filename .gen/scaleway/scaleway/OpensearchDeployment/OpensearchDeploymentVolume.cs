using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.OpensearchDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.opensearchDeployment.OpensearchDeploymentVolume")]
    public class OpensearchDeploymentVolume : scaleway.OpensearchDeployment.IOpensearchDeploymentVolume
    {
        /// <summary>Volume size in GB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/opensearch_deployment#size_in_gb OpensearchDeployment#size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeInGb
        {
            get;
            set;
        }

        /// <summary>Volume type (sbs_5k, sbs_15k).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/opensearch_deployment#type OpensearchDeployment#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
