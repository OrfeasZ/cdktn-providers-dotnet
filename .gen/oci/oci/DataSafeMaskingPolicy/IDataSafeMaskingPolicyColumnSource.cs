using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeMaskingPolicy
{
    [JsiiInterface(nativeType: typeof(IDataSafeMaskingPolicyColumnSource), fullyQualifiedName: "oci.dataSafeMaskingPolicy.DataSafeMaskingPolicyColumnSource")]
    public interface IDataSafeMaskingPolicyColumnSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#column_source DataSafeMaskingPolicy#column_source}.</summary>
        [JsiiProperty(name: "columnSource", typeJson: "{\"primitive\":\"string\"}")]
        string ColumnSource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#sensitive_data_model_id DataSafeMaskingPolicy#sensitive_data_model_id}.</summary>
        [JsiiProperty(name: "sensitiveDataModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SensitiveDataModelId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#target_id DataSafeMaskingPolicy#target_id}.</summary>
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeMaskingPolicyColumnSource), fullyQualifiedName: "oci.dataSafeMaskingPolicy.DataSafeMaskingPolicyColumnSource")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeMaskingPolicy.IDataSafeMaskingPolicyColumnSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#column_source DataSafeMaskingPolicy#column_source}.</summary>
            [JsiiProperty(name: "columnSource", typeJson: "{\"primitive\":\"string\"}")]
            public string ColumnSource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#sensitive_data_model_id DataSafeMaskingPolicy#sensitive_data_model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveDataModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SensitiveDataModelId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy#target_id DataSafeMaskingPolicy#target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
