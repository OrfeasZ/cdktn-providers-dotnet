using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterOutpostConfigEtcdPlacement")]
    public class EksClusterOutpostConfigEtcdPlacement : aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/eks_cluster#spread_level EksCluster#spread_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spreadLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpreadLevel
        {
            get;
            set;
        }
    }
}
