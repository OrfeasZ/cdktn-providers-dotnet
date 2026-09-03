using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterOutpostConfigEtcdPlacement), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfigEtcdPlacement")]
    public interface IEksClusterOutpostConfigEtcdPlacement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#spread_level EksCluster#spread_level}.</summary>
        [JsiiProperty(name: "spreadLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpreadLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterOutpostConfigEtcdPlacement), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfigEtcdPlacement")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#spread_level EksCluster#spread_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spreadLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpreadLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
