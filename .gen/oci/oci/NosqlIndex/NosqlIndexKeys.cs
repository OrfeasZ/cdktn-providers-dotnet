using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NosqlIndex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.nosqlIndex.NosqlIndexKeys")]
    public class NosqlIndexKeys : oci.NosqlIndex.INosqlIndexKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#column_name NosqlIndex#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public string ColumnName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#json_field_type NosqlIndex#json_field_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jsonFieldType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JsonFieldType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#json_path NosqlIndex#json_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JsonPath
        {
            get;
            set;
        }
    }
}
