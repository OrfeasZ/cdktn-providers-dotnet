using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeMaskingPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeMaskingPolicy.DataSafeMaskingPolicyColumnSource")]
    public class DataSafeMaskingPolicyColumnSource : oci.DataSafeMaskingPolicy.IDataSafeMaskingPolicyColumnSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#column_source DataSafeMaskingPolicy#column_source}.</summary>
        [JsiiProperty(name: "columnSource", typeJson: "{\"primitive\":\"string\"}")]
        public string ColumnSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#sensitive_data_model_id DataSafeMaskingPolicy#sensitive_data_model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sensitiveDataModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SensitiveDataModelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#target_id DataSafeMaskingPolicy#target_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetId
        {
            get;
            set;
        }
    }
}
