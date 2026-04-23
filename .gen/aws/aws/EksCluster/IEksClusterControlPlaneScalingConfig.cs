using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterControlPlaneScalingConfig), fullyQualifiedName: "aws.eksCluster.EksClusterControlPlaneScalingConfig")]
    public interface IEksClusterControlPlaneScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_cluster#tier EksCluster#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterControlPlaneScalingConfig), fullyQualifiedName: "aws.eksCluster.EksClusterControlPlaneScalingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterControlPlaneScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_cluster#tier EksCluster#tier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
