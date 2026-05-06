using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NosqlTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.nosqlTable.NosqlTableTableLimits")]
    public class NosqlTableTableLimits : oci.NosqlTable.INosqlTableTableLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_read_units NosqlTable#max_read_units}.</summary>
        [JsiiProperty(name: "maxReadUnits", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxReadUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_storage_in_gbs NosqlTable#max_storage_in_gbs}.</summary>
        [JsiiProperty(name: "maxStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxStorageInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_write_units NosqlTable#max_write_units}.</summary>
        [JsiiProperty(name: "maxWriteUnits", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxWriteUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#capacity_mode NosqlTable#capacity_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityMode
        {
            get;
            set;
        }
    }
}
