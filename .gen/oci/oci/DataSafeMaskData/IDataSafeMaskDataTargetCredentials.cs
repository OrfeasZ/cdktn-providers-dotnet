using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeMaskData
{
    [JsiiInterface(nativeType: typeof(IDataSafeMaskDataTargetCredentials), fullyQualifiedName: "oci.dataSafeMaskData.DataSafeMaskDataTargetCredentials")]
    public interface IDataSafeMaskDataTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/data_safe_mask_data#password DataSafeMaskData#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/data_safe_mask_data#user_name DataSafeMaskData#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeMaskDataTargetCredentials), fullyQualifiedName: "oci.dataSafeMaskData.DataSafeMaskDataTargetCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeMaskData.IDataSafeMaskDataTargetCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/data_safe_mask_data#password DataSafeMaskData#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/data_safe_mask_data#user_name DataSafeMaskData#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
