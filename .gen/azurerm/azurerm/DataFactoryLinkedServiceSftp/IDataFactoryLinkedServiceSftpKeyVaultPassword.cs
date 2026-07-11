using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceSftp
{
    [JsiiInterface(nativeType: typeof(IDataFactoryLinkedServiceSftpKeyVaultPassword), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftpKeyVaultPassword")]
    public interface IDataFactoryLinkedServiceSftpKeyVaultPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_factory_linked_service_sftp#linked_service_name DataFactoryLinkedServiceSftp#linked_service_name}.</summary>
        [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
        string LinkedServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_factory_linked_service_sftp#secret_name DataFactoryLinkedServiceSftp#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryLinkedServiceSftpKeyVaultPassword), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftpKeyVaultPassword")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryLinkedServiceSftp.IDataFactoryLinkedServiceSftpKeyVaultPassword
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_factory_linked_service_sftp#linked_service_name DataFactoryLinkedServiceSftp#linked_service_name}.</summary>
            [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
            public string LinkedServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_factory_linked_service_sftp#secret_name DataFactoryLinkedServiceSftp#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
