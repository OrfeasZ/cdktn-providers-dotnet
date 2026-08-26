using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationEks")]
    public class Resiliencehubv2InputSourceResourceConfigurationEks : aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationEks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_input_source#cluster_arn Resiliencehubv2InputSource#cluster_arn}.</summary>
        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_input_source#namespaces Resiliencehubv2InputSource#namespaces}.</summary>
        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Namespaces
        {
            get;
            set;
        }
    }
}
