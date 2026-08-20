using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterProject
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDevCenterProjectTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterProject.DataAzurermDevCenterProjectTimeouts")]
    public interface IDataAzurermDevCenterProjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/dev_center_project#read DataAzurermDevCenterProject#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDevCenterProjectTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterProject.DataAzurermDevCenterProjectTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDevCenterProject.IDataAzurermDevCenterProjectTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/dev_center_project#read DataAzurermDevCenterProject#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
