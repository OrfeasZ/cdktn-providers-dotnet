using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DocdbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.docdbCluster.DocdbClusterServerlessV2ScalingConfiguration")]
    public class DocdbClusterServerlessV2ScalingConfiguration : aws.DocdbCluster.IDocdbClusterServerlessV2ScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/docdb_cluster#max_capacity DocdbCluster#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/docdb_cluster#min_capacity DocdbCluster#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double MinCapacity
        {
            get;
            set;
        }
    }
}
