using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccCapacityRequest
{
    [JsiiInterface(nativeType: typeof(ICapacityManagementOccCapacityRequestPatchOperations), fullyQualifiedName: "oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestPatchOperations")]
    public interface ICapacityManagementOccCapacityRequestPatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#from CapacityManagementOccCapacityRequest#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
        string From
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#operation CapacityManagementOccCapacityRequest#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        string Operation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#selection CapacityManagementOccCapacityRequest#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#value CapacityManagementOccCapacityRequest#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#position CapacityManagementOccCapacityRequest#position}.</summary>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Position
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#selected_item CapacityManagementOccCapacityRequest#selected_item}.</summary>
        [JsiiProperty(name: "selectedItem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelectedItem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICapacityManagementOccCapacityRequestPatchOperations), fullyQualifiedName: "oci.capacityManagementOccCapacityRequest.CapacityManagementOccCapacityRequestPatchOperations")]
        internal sealed class _Proxy : DeputyBase, oci.CapacityManagementOccCapacityRequest.ICapacityManagementOccCapacityRequestPatchOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#from CapacityManagementOccCapacityRequest#from}.</summary>
            [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
            public string From
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#operation CapacityManagementOccCapacityRequest#operation}.</summary>
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
            public string Operation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#selection CapacityManagementOccCapacityRequest#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#value CapacityManagementOccCapacityRequest#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Value
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#position CapacityManagementOccCapacityRequest#position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Position
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_capacity_request#selected_item CapacityManagementOccCapacityRequest#selected_item}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selectedItem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelectedItem
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
