using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeEstimateTableSizes
{
    [JsiiInterface(nativeType: typeof(IDataSafeEstimateTableSizesTargetCredentials), fullyQualifiedName: "oci.dataSafeEstimateTableSizes.DataSafeEstimateTableSizesTargetCredentials")]
    public interface IDataSafeEstimateTableSizesTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_estimate_table_sizes#password DataSafeEstimateTableSizes#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_estimate_table_sizes#user_name DataSafeEstimateTableSizes#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeEstimateTableSizesTargetCredentials), fullyQualifiedName: "oci.dataSafeEstimateTableSizes.DataSafeEstimateTableSizesTargetCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeEstimateTableSizes.IDataSafeEstimateTableSizesTargetCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_estimate_table_sizes#password DataSafeEstimateTableSizes#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_estimate_table_sizes#user_name DataSafeEstimateTableSizes#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
