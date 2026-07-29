using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement")]
    public class EksClusterOutpostConfigControlPlanePlacement : aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/eks_cluster#group_name EksCluster#group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/eks_cluster#spread_level EksCluster#spread_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spreadLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpreadLevel
        {
            get;
            set;
        }
    }
}
