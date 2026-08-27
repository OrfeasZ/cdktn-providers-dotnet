using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HealthcareDicomService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.healthcareDicomService.HealthcareDicomServiceStorage")]
    public class HealthcareDicomServiceStorage : azurerm.HealthcareDicomService.IHealthcareDicomServiceStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/healthcare_dicom_service#file_system_name HealthcareDicomService#file_system_name}.</summary>
        [JsiiProperty(name: "fileSystemName", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/healthcare_dicom_service#storage_account_id HealthcareDicomService#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountId
        {
            get;
            set;
        }
    }
}
