using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperDestinationCloudwatch")]
    public class PrometheusScraperDestinationCloudwatch : aws.PrometheusScraper.IPrometheusScraperDestinationCloudwatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_scraper#dataset_arn PrometheusScraper#dataset_arn}.</summary>
        [JsiiProperty(name: "datasetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DatasetArn
        {
            get;
            set;
        }
    }
}
