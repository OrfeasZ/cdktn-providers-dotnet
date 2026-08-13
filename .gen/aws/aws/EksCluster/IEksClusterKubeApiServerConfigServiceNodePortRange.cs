using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubeApiServerConfigServiceNodePortRange), fullyQualifiedName: "aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRange")]
    public interface IEksClusterKubeApiServerConfigServiceNodePortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/eks_cluster#max_port EksCluster#max_port}.</summary>
        [JsiiProperty(name: "maxPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/eks_cluster#min_port EksCluster#min_port}.</summary>
        [JsiiProperty(name: "minPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubeApiServerConfigServiceNodePortRange), fullyQualifiedName: "aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRange")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/eks_cluster#max_port EksCluster#max_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/eks_cluster#min_port EksCluster#min_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
