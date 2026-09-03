using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HealthcareDicomService
{
    [JsiiInterface(nativeType: typeof(IHealthcareDicomServiceStorage), fullyQualifiedName: "azurerm.healthcareDicomService.HealthcareDicomServiceStorage")]
    public interface IHealthcareDicomServiceStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/healthcare_dicom_service#file_system_name HealthcareDicomService#file_system_name}.</summary>
        [JsiiProperty(name: "fileSystemName", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/healthcare_dicom_service#storage_account_id HealthcareDicomService#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHealthcareDicomServiceStorage), fullyQualifiedName: "azurerm.healthcareDicomService.HealthcareDicomServiceStorage")]
        internal sealed class _Proxy : DeputyBase, azurerm.HealthcareDicomService.IHealthcareDicomServiceStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/healthcare_dicom_service#file_system_name HealthcareDicomService#file_system_name}.</summary>
            [JsiiProperty(name: "fileSystemName", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/healthcare_dicom_service#storage_account_id HealthcareDicomService#storage_account_id}.</summary>
            [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
