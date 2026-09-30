using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsetData
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsetDataTargetCredentials), fullyQualifiedName: "oci.dataSafeSubsetData.DataSafeSubsetDataTargetCredentials")]
    public interface IDataSafeSubsetDataTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subset_data#password DataSafeSubsetData#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subset_data#user_name DataSafeSubsetData#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsetDataTargetCredentials), fullyQualifiedName: "oci.dataSafeSubsetData.DataSafeSubsetDataTargetCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsetData.IDataSafeSubsetDataTargetCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subset_data#password DataSafeSubsetData#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subset_data#user_name DataSafeSubsetData#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
