using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalysi
{
    [JsiiInterface(nativeType: typeof(IVnMonitoringPathAnalysiQueryOptions), fullyQualifiedName: "oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiQueryOptions")]
    public interface IVnMonitoringPathAnalysiQueryOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#is_bi_directional_analysis VnMonitoringPathAnalysi#is_bi_directional_analysis}.</summary>
        [JsiiProperty(name: "isBiDirectionalAnalysis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsBiDirectionalAnalysis
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVnMonitoringPathAnalysiQueryOptions), fullyQualifiedName: "oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiQueryOptions")]
        internal sealed class _Proxy : DeputyBase, oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiQueryOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#is_bi_directional_analysis VnMonitoringPathAnalysi#is_bi_directional_analysis}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isBiDirectionalAnalysis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsBiDirectionalAnalysis
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
