using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalyzerTest
{
    [JsiiByValue(fqn: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptions")]
    public class VnMonitoringPathAnalyzerTestQueryOptions : oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions
    {
        private object? _isBiDirectionalAnalysis;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#is_bi_directional_analysis VnMonitoringPathAnalyzerTest#is_bi_directional_analysis}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isBiDirectionalAnalysis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsBiDirectionalAnalysis
        {
            get => _isBiDirectionalAnalysis;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isBiDirectionalAnalysis = value;
            }
        }
    }
}
