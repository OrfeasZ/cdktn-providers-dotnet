using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveTypeGroupGroupedSensitiveType
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations")]
    public class DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations : oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#operation DataSafeSensitiveTypeGroupGroupedSensitiveType#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public string Operation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#selection DataSafeSensitiveTypeGroupGroupedSensitiveType#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#value DataSafeSensitiveTypeGroupGroupedSensitiveType#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Value
        {
            get;
            set;
        }
    }
}
