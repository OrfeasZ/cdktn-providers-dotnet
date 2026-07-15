using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCostadCostAnomalyMonitors
{
    [JsiiInterface(nativeType: typeof(IDataOciCostadCostAnomalyMonitorsFilter), fullyQualifiedName: "oci.dataOciCostadCostAnomalyMonitors.DataOciCostadCostAnomalyMonitorsFilter")]
    public interface IDataOciCostadCostAnomalyMonitorsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/costad_cost_anomaly_monitors#name DataOciCostadCostAnomalyMonitors#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/costad_cost_anomaly_monitors#values DataOciCostadCostAnomalyMonitors#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/costad_cost_anomaly_monitors#regex DataOciCostadCostAnomalyMonitors#regex}.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IDataOciCostadCostAnomalyMonitorsFilter), fullyQualifiedName: "oci.dataOciCostadCostAnomalyMonitors.DataOciCostadCostAnomalyMonitorsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciCostadCostAnomalyMonitors.IDataOciCostadCostAnomalyMonitorsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/costad_cost_anomaly_monitors#name DataOciCostadCostAnomalyMonitors#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/costad_cost_anomaly_monitors#values DataOciCostadCostAnomalyMonitors#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/costad_cost_anomaly_monitors#regex DataOciCostadCostAnomalyMonitors#regex}.</summary>
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
