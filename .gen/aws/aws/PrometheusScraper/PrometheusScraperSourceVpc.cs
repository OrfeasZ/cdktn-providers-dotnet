using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperSourceVpc")]
    public class PrometheusScraperSourceVpc : aws.PrometheusScraper.IPrometheusScraperSourceVpc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/prometheus_scraper#security_group_ids PrometheusScraper#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/prometheus_scraper#subnet_ids PrometheusScraper#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }
    }
}
