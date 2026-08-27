using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDemandSignalOccMetricAlarms
{
    [JsiiInterface(nativeType: typeof(IDataOciDemandSignalOccMetricAlarmsFilter), fullyQualifiedName: "oci.dataOciDemandSignalOccMetricAlarms.DataOciDemandSignalOccMetricAlarmsFilter")]
    public interface IDataOciDemandSignalOccMetricAlarmsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/demand_signal_occ_metric_alarms#name DataOciDemandSignalOccMetricAlarms#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/demand_signal_occ_metric_alarms#values DataOciDemandSignalOccMetricAlarms#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/demand_signal_occ_metric_alarms#regex DataOciDemandSignalOccMetricAlarms#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDemandSignalOccMetricAlarmsFilter), fullyQualifiedName: "oci.dataOciDemandSignalOccMetricAlarms.DataOciDemandSignalOccMetricAlarmsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDemandSignalOccMetricAlarms.IDataOciDemandSignalOccMetricAlarmsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/demand_signal_occ_metric_alarms#name DataOciDemandSignalOccMetricAlarms#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/demand_signal_occ_metric_alarms#values DataOciDemandSignalOccMetricAlarms#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/demand_signal_occ_metric_alarms#regex DataOciDemandSignalOccMetricAlarms#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
