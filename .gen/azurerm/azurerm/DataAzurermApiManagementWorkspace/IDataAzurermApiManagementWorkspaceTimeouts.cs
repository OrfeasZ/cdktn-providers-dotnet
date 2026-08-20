using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementWorkspace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermApiManagementWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementWorkspace.DataAzurermApiManagementWorkspaceTimeouts")]
    public interface IDataAzurermApiManagementWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/api_management_workspace#read DataAzurermApiManagementWorkspace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermApiManagementWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementWorkspace.DataAzurermApiManagementWorkspaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermApiManagementWorkspace.IDataAzurermApiManagementWorkspaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/api_management_workspace#read DataAzurermApiManagementWorkspace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
