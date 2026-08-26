using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRange")]
    public class EksClusterKubeApiServerConfigServiceNodePortRange : aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/eks_cluster#max_port EksCluster#max_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/eks_cluster#min_port EksCluster#min_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinPort
        {
            get;
            set;
        }
    }
}
