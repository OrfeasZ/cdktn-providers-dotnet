using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperSourceVpc), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperSourceVpc")]
    public interface IPrometheusScraperSourceVpc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/prometheus_scraper#security_group_ids PrometheusScraper#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/prometheus_scraper#subnet_ids PrometheusScraper#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperSourceVpc), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperSourceVpc")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraper.IPrometheusScraperSourceVpc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/prometheus_scraper#security_group_ids PrometheusScraper#security_group_ids}.</summary>
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/prometheus_scraper#subnet_ids PrometheusScraper#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
