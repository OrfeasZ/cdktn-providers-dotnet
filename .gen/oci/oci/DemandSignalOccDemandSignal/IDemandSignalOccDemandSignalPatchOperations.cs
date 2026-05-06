using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccDemandSignal
{
    [JsiiInterface(nativeType: typeof(IDemandSignalOccDemandSignalPatchOperations), fullyQualifiedName: "oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalPatchOperations")]
    public interface IDemandSignalOccDemandSignalPatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#from DemandSignalOccDemandSignal#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
        string From
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#operation DemandSignalOccDemandSignal#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        string Operation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#selection DemandSignalOccDemandSignal#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#value DemandSignalOccDemandSignal#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#position DemandSignalOccDemandSignal#position}.</summary>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Position
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#selected_item DemandSignalOccDemandSignal#selected_item}.</summary>
        [JsiiProperty(name: "selectedItem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelectedItem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDemandSignalOccDemandSignalPatchOperations), fullyQualifiedName: "oci.demandSignalOccDemandSignal.DemandSignalOccDemandSignalPatchOperations")]
        internal sealed class _Proxy : DeputyBase, oci.DemandSignalOccDemandSignal.IDemandSignalOccDemandSignalPatchOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#from DemandSignalOccDemandSignal#from}.</summary>
            [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
            public string From
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#operation DemandSignalOccDemandSignal#operation}.</summary>
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
            public string Operation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#selection DemandSignalOccDemandSignal#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#value DemandSignalOccDemandSignal#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Value
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#position DemandSignalOccDemandSignal#position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Position
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/demand_signal_occ_demand_signal#selected_item DemandSignalOccDemandSignal#selected_item}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selectedItem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelectedItem
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
