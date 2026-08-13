using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperExporterOpensearch), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperExporterOpensearch")]
    public interface IPrometheusScraperExporterOpensearch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_scraper#domain_arn PrometheusScraper#domain_arn}.</summary>
        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
        string DomainArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperExporterOpensearch), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperExporterOpensearch")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraper.IPrometheusScraperExporterOpensearch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_scraper#domain_arn PrometheusScraper#domain_arn}.</summary>
            [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
