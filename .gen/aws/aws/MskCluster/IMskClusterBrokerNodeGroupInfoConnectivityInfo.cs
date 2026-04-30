using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterBrokerNodeGroupInfoConnectivityInfo), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfo")]
    public interface IMskClusterBrokerNodeGroupInfoConnectivityInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/msk_cluster#network_type MskCluster#network_type}.</summary>
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkType
        {
            get
            {
                return null;
            }
        }

        /// <summary>public_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/msk_cluster#public_access MskCluster#public_access}
        /// </remarks>
        [JsiiProperty(name: "publicAccess", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_connectivity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/msk_cluster#vpc_connectivity MskCluster#vpc_connectivity}
        /// </remarks>
        [JsiiProperty(name: "vpcConnectivity", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterBrokerNodeGroupInfoConnectivityInfo), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfo")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/msk_cluster#network_type MskCluster#network_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>public_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/msk_cluster#public_access MskCluster#public_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicAccess", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess?>();
            }

            /// <summary>vpc_connectivity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/msk_cluster#vpc_connectivity MskCluster#vpc_connectivity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConnectivity", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivity
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity?>();
            }
        }
    }
}
