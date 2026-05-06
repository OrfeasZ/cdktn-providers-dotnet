using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    [JsiiByValue(fqn: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUi")]
    public class MeteringComputationQueryQueryDefinitionCostAnalysisUi : oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionCostAnalysisUi
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#graph MeteringComputationQuery#graph}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "graph", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Graph
        {
            get;
            set;
        }

        private object? _isCumulativeGraph;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#is_cumulative_graph MeteringComputationQuery#is_cumulative_graph}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isCumulativeGraph", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCumulativeGraph
        {
            get => _isCumulativeGraph;
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
                _isCumulativeGraph = value;
            }
        }
    }
}
