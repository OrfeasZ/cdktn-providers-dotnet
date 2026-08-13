using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperExporter")]
    public class PrometheusScraperExporter : aws.PrometheusScraper.IPrometheusScraperExporter
    {
        private object? _opensearch;

        /// <summary>opensearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_scraper#opensearch PrometheusScraper#opensearch}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusScraper.IPrometheusScraperExporterOpensearch" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "opensearch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperExporterOpensearch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Opensearch
        {
            get => _opensearch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusScraper.IPrometheusScraperExporterOpensearch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusScraper.IPrometheusScraperExporterOpensearch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _opensearch = value;
            }
        }
    }
}
