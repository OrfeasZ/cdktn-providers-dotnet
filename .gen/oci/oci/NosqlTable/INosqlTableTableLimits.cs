using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NosqlTable
{
    [JsiiInterface(nativeType: typeof(INosqlTableTableLimits), fullyQualifiedName: "oci.nosqlTable.NosqlTableTableLimits")]
    public interface INosqlTableTableLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_read_units NosqlTable#max_read_units}.</summary>
        [JsiiProperty(name: "maxReadUnits", typeJson: "{\"primitive\":\"number\"}")]
        double MaxReadUnits
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_storage_in_gbs NosqlTable#max_storage_in_gbs}.</summary>
        [JsiiProperty(name: "maxStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double MaxStorageInGbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_write_units NosqlTable#max_write_units}.</summary>
        [JsiiProperty(name: "maxWriteUnits", typeJson: "{\"primitive\":\"number\"}")]
        double MaxWriteUnits
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#capacity_mode NosqlTable#capacity_mode}.</summary>
        [JsiiProperty(name: "capacityMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INosqlTableTableLimits), fullyQualifiedName: "oci.nosqlTable.NosqlTableTableLimits")]
        internal sealed class _Proxy : DeputyBase, oci.NosqlTable.INosqlTableTableLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_read_units NosqlTable#max_read_units}.</summary>
            [JsiiProperty(name: "maxReadUnits", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxReadUnits
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_storage_in_gbs NosqlTable#max_storage_in_gbs}.</summary>
            [JsiiProperty(name: "maxStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxStorageInGbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#max_write_units NosqlTable#max_write_units}.</summary>
            [JsiiProperty(name: "maxWriteUnits", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxWriteUnits
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_table#capacity_mode NosqlTable#capacity_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
