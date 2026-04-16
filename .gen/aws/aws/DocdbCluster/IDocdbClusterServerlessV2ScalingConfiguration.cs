using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DocdbCluster
{
    [JsiiInterface(nativeType: typeof(IDocdbClusterServerlessV2ScalingConfiguration), fullyQualifiedName: "aws.docdbCluster.DocdbClusterServerlessV2ScalingConfiguration")]
    public interface IDocdbClusterServerlessV2ScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/docdb_cluster#max_capacity DocdbCluster#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MaxCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/docdb_cluster#min_capacity DocdbCluster#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MinCapacity
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDocdbClusterServerlessV2ScalingConfiguration), fullyQualifiedName: "aws.docdbCluster.DocdbClusterServerlessV2ScalingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.DocdbCluster.IDocdbClusterServerlessV2ScalingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/docdb_cluster#max_capacity DocdbCluster#max_capacity}.</summary>
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/docdb_cluster#min_capacity DocdbCluster#min_capacity}.</summary>
            [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MinCapacity
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
