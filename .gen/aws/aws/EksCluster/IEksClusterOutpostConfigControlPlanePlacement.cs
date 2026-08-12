using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterOutpostConfigControlPlanePlacement), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement")]
    public interface IEksClusterOutpostConfigControlPlanePlacement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/eks_cluster#group_name EksCluster#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/eks_cluster#spread_level EksCluster#spread_level}.</summary>
        [JsiiProperty(name: "spreadLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpreadLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterOutpostConfigControlPlanePlacement), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/eks_cluster#group_name EksCluster#group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/eks_cluster#spread_level EksCluster#spread_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spreadLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpreadLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
