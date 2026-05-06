using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalyzerTest
{
    [JsiiInterface(nativeType: typeof(IVnMonitoringPathAnalyzerTestQueryOptions), fullyQualifiedName: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptions")]
    public interface IVnMonitoringPathAnalyzerTestQueryOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#is_bi_directional_analysis VnMonitoringPathAnalyzerTest#is_bi_directional_analysis}.</summary>
        [JsiiProperty(name: "isBiDirectionalAnalysis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsBiDirectionalAnalysis
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVnMonitoringPathAnalyzerTestQueryOptions), fullyQualifiedName: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestQueryOptions")]
        internal sealed class _Proxy : DeputyBase, oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestQueryOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#is_bi_directional_analysis VnMonitoringPathAnalyzerTest#is_bi_directional_analysis}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isBiDirectionalAnalysis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsBiDirectionalAnalysis
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
