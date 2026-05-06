using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter), fullyQualifiedName: "oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter")]
    public interface IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#name DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#values DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#regex DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter), fullyQualifiedName: "oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#name DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#values DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#regex DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
