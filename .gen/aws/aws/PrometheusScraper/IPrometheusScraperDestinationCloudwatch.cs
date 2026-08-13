using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperDestinationCloudwatch), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperDestinationCloudwatch")]
    public interface IPrometheusScraperDestinationCloudwatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_scraper#dataset_arn PrometheusScraper#dataset_arn}.</summary>
        [JsiiProperty(name: "datasetArn", typeJson: "{\"primitive\":\"string\"}")]
        string DatasetArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperDestinationCloudwatch), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperDestinationCloudwatch")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraper.IPrometheusScraperDestinationCloudwatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_scraper#dataset_arn PrometheusScraper#dataset_arn}.</summary>
            [JsiiProperty(name: "datasetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DatasetArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
