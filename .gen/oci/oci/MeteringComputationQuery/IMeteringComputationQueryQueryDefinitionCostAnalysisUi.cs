using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationQueryQueryDefinitionCostAnalysisUi), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUi")]
    public interface IMeteringComputationQueryQueryDefinitionCostAnalysisUi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/metering_computation_query#graph MeteringComputationQuery#graph}.</summary>
        [JsiiProperty(name: "graph", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Graph
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/metering_computation_query#is_cumulative_graph MeteringComputationQuery#is_cumulative_graph}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isCumulativeGraph", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCumulativeGraph
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationQueryQueryDefinitionCostAnalysisUi), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUi")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionCostAnalysisUi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/metering_computation_query#graph MeteringComputationQuery#graph}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "graph", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Graph
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/metering_computation_query#is_cumulative_graph MeteringComputationQuery#is_cumulative_graph}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isCumulativeGraph", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCumulativeGraph
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
