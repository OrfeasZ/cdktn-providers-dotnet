using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPlaywrightWorkspace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPlaywrightWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermPlaywrightWorkspace.DataAzurermPlaywrightWorkspaceTimeouts")]
    public interface IDataAzurermPlaywrightWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/playwright_workspace#read DataAzurermPlaywrightWorkspace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPlaywrightWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermPlaywrightWorkspace.DataAzurermPlaywrightWorkspaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPlaywrightWorkspace.IDataAzurermPlaywrightWorkspaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/playwright_workspace#read DataAzurermPlaywrightWorkspace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
