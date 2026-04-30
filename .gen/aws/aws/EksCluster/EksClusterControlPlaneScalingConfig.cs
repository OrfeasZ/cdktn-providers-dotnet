using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterControlPlaneScalingConfig")]
    public class EksClusterControlPlaneScalingConfig : aws.EksCluster.IEksClusterControlPlaneScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_cluster#tier EksCluster#tier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tier
        {
            get;
            set;
        }
    }
}
