using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsubUsageComputedUsageAggregateds
{
    [JsiiInterface(nativeType: typeof(IDataOciOsubUsageComputedUsageAggregatedsFilter), fullyQualifiedName: "oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsFilter")]
    public interface IDataOciOsubUsageComputedUsageAggregatedsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osub_usage_computed_usage_aggregateds#name DataOciOsubUsageComputedUsageAggregateds#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osub_usage_computed_usage_aggregateds#values DataOciOsubUsageComputedUsageAggregateds#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osub_usage_computed_usage_aggregateds#regex DataOciOsubUsageComputedUsageAggregateds#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciOsubUsageComputedUsageAggregatedsFilter), fullyQualifiedName: "oci.dataOciOsubUsageComputedUsageAggregateds.DataOciOsubUsageComputedUsageAggregatedsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciOsubUsageComputedUsageAggregateds.IDataOciOsubUsageComputedUsageAggregatedsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osub_usage_computed_usage_aggregateds#name DataOciOsubUsageComputedUsageAggregateds#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osub_usage_computed_usage_aggregateds#values DataOciOsubUsageComputedUsageAggregateds#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/osub_usage_computed_usage_aggregateds#regex DataOciOsubUsageComputedUsageAggregateds#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
