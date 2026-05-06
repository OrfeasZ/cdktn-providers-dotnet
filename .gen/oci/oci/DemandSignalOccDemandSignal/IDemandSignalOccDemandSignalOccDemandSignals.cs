using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccDemandSignal
{
    [JsiiInterface(nativeType: typeof(IDemandSignalOccDemandSignalOccDemandSignals), fullyQualifiedName: "oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignals")]
    public interface IDemandSignalOccDemandSignalOccDemandSignals
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#resource_type DemandSignalOccDemandSignal#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#units DemandSignalOccDemandSignal#units}.</summary>
        [JsiiProperty(name: "units", typeJson: "{\"primitive\":\"string\"}")]
        string Units
        {
            get;
        }

        /// <summary>values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#values DemandSignalOccDemandSignal#values}
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignalsValues\"},\"kind\":\"array\"}}]}}")]
        object Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDemandSignalOccDemandSignalOccDemandSignals), fullyQualifiedName: "oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignals")]
        internal sealed class _Proxy : DeputyBase, oci.DemandSignalOccDemandSignal.IDemandSignalOccDemandSignalOccDemandSignals
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#resource_type DemandSignalOccDemandSignal#resource_type}.</summary>
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#units DemandSignalOccDemandSignal#units}.</summary>
            [JsiiProperty(name: "units", typeJson: "{\"primitive\":\"string\"}")]
            public string Units
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#values DemandSignalOccDemandSignal#values}
            /// </remarks>
            [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalOccDemandSignalsValues\"},\"kind\":\"array\"}}]}}")]
            public object Values
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
