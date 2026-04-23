using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterRebalancing), fullyQualifiedName: "aws.mskCluster.MskClusterRebalancing")]
    public interface IMskClusterRebalancing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/msk_cluster#status MskCluster#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterRebalancing), fullyQualifiedName: "aws.mskCluster.MskClusterRebalancing")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterRebalancing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/msk_cluster#status MskCluster#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
