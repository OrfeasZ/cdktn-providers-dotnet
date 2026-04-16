using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperSource")]
    public class PrometheusScraperSource : aws.PrometheusScraper.IPrometheusScraperSource
    {
        private object? _eks;

        /// <summary>eks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/prometheus_scraper#eks PrometheusScraper#eks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperSourceEks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Eks
        {
            get => _eks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusScraper.IPrometheusScraperSourceEks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusScraper.IPrometheusScraperSourceEks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _eks = value;
            }
        }

        private object? _vpc;

        /// <summary>vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/prometheus_scraper#vpc PrometheusScraper#vpc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperSourceVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Vpc
        {
            get => _vpc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusScraper.IPrometheusScraperSourceVpc[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusScraper.IPrometheusScraperSourceVpc).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpc = value;
            }
        }
    }
}
