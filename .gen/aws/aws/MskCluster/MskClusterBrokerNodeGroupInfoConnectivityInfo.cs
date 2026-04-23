using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfo")]
    public class MskClusterBrokerNodeGroupInfoConnectivityInfo : aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/msk_cluster#network_type MskCluster#network_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkType
        {
            get;
            set;
        }

        /// <summary>public_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/msk_cluster#public_access MskCluster#public_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicAccess", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess
        {
            get;
            set;
        }

        /// <summary>vpc_connectivity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/msk_cluster#vpc_connectivity MskCluster#vpc_connectivity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConnectivity", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity
        {
            get;
            set;
        }
    }
}
