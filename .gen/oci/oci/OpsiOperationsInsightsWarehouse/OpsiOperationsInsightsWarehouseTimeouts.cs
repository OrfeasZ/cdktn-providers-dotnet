using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiOperationsInsightsWarehouse
{
    [JsiiByValue(fqn: "oci.opsiOperationsInsightsWarehouse.OpsiOperationsInsightsWarehouseTimeouts")]
    public class OpsiOperationsInsightsWarehouseTimeouts : oci.OpsiOperationsInsightsWarehouse.IOpsiOperationsInsightsWarehouseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse#create OpsiOperationsInsightsWarehouse#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse#delete OpsiOperationsInsightsWarehouse#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_operations_insights_warehouse#update OpsiOperationsInsightsWarehouse#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
