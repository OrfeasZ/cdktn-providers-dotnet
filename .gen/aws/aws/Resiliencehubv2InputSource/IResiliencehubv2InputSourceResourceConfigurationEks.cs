using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2InputSourceResourceConfigurationEks), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks")]
    public interface IResiliencehubv2InputSourceResourceConfigurationEks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#cluster_arn Resiliencehubv2InputSource#cluster_arn}.</summary>
        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#namespaces Resiliencehubv2InputSource#namespaces}.</summary>
        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Namespaces
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2InputSourceResourceConfigurationEks), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#cluster_arn Resiliencehubv2InputSource#cluster_arn}.</summary>
            [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#namespaces Resiliencehubv2InputSource#namespaces}.</summary>
            [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Namespaces
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
