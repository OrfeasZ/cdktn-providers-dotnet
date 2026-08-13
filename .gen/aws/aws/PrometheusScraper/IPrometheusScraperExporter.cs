using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperExporter), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperExporter")]
    public interface IPrometheusScraperExporter
    {
        /// <summary>opensearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_scraper#opensearch PrometheusScraper#opensearch}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusScraper.IPrometheusScraperExporterOpensearch" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "opensearch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperExporterOpensearch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Opensearch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperExporter), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperExporter")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraper.IPrometheusScraperExporter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>opensearch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_scraper#opensearch PrometheusScraper#opensearch}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusScraper.IPrometheusScraperExporterOpensearch" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opensearch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperExporterOpensearch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Opensearch
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
