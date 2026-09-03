using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperExporterOpensearch")]
    public class PrometheusScraperExporterOpensearch : aws.PrometheusScraper.IPrometheusScraperExporterOpensearch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/prometheus_scraper#domain_arn PrometheusScraper#domain_arn}.</summary>
        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainArn
        {
            get;
            set;
        }
    }
}
