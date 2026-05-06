using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeMaskingPoliciesApplyDifferenceToMaskingColumns
{
    [JsiiByValue(fqn: "oci.dataSafeMaskingPoliciesApplyDifferenceToMaskingColumns.DataSafeMaskingPoliciesApplyDifferenceToMaskingColumnsTimeouts")]
    public class DataSafeMaskingPoliciesApplyDifferenceToMaskingColumnsTimeouts : oci.DataSafeMaskingPoliciesApplyDifferenceToMaskingColumns.IDataSafeMaskingPoliciesApplyDifferenceToMaskingColumnsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policies_apply_difference_to_masking_columns#create DataSafeMaskingPoliciesApplyDifferenceToMaskingColumns#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policies_apply_difference_to_masking_columns#delete DataSafeMaskingPoliciesApplyDifferenceToMaskingColumns#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policies_apply_difference_to_masking_columns#update DataSafeMaskingPoliciesApplyDifferenceToMaskingColumns#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
