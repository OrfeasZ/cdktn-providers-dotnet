using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDataSource
{
    [JsiiInterface(nativeType: typeof(ICloudGuardDataSourceDataSourceDetailsQueryStartTime), fullyQualifiedName: "oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTime")]
    public interface ICloudGuardDataSourceDataSourceDetailsQueryStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#start_policy_type CloudGuardDataSource#start_policy_type}.</summary>
        [JsiiProperty(name: "startPolicyType", typeJson: "{\"primitive\":\"string\"}")]
        string StartPolicyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#query_start_time CloudGuardDataSource#query_start_time}.</summary>
        [JsiiProperty(name: "queryStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardDataSourceDataSourceDetailsQueryStartTime), fullyQualifiedName: "oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTime")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsQueryStartTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#start_policy_type CloudGuardDataSource#start_policy_type}.</summary>
            [JsiiProperty(name: "startPolicyType", typeJson: "{\"primitive\":\"string\"}")]
            public string StartPolicyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#query_start_time CloudGuardDataSource#query_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryStartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
