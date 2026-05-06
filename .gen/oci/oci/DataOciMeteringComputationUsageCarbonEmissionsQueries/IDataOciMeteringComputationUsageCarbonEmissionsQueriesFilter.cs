using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMeteringComputationUsageCarbonEmissionsQueries
{
    [JsiiInterface(nativeType: typeof(IDataOciMeteringComputationUsageCarbonEmissionsQueriesFilter), fullyQualifiedName: "oci.dataOciMeteringComputationUsageCarbonEmissionsQueries.DataOciMeteringComputationUsageCarbonEmissionsQueriesFilter")]
    public interface IDataOciMeteringComputationUsageCarbonEmissionsQueriesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/metering_computation_usage_carbon_emissions_queries#name DataOciMeteringComputationUsageCarbonEmissionsQueries#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/metering_computation_usage_carbon_emissions_queries#values DataOciMeteringComputationUsageCarbonEmissionsQueries#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/metering_computation_usage_carbon_emissions_queries#regex DataOciMeteringComputationUsageCarbonEmissionsQueries#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciMeteringComputationUsageCarbonEmissionsQueriesFilter), fullyQualifiedName: "oci.dataOciMeteringComputationUsageCarbonEmissionsQueries.DataOciMeteringComputationUsageCarbonEmissionsQueriesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciMeteringComputationUsageCarbonEmissionsQueries.IDataOciMeteringComputationUsageCarbonEmissionsQueriesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/metering_computation_usage_carbon_emissions_queries#name DataOciMeteringComputationUsageCarbonEmissionsQueries#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/metering_computation_usage_carbon_emissions_queries#values DataOciMeteringComputationUsageCarbonEmissionsQueries#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/metering_computation_usage_carbon_emissions_queries#regex DataOciMeteringComputationUsageCarbonEmissionsQueries#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
