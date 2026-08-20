using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterProjectPool
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDevCenterProjectPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterProjectPool.DataAzurermDevCenterProjectPoolTimeouts")]
    public interface IDataAzurermDevCenterProjectPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/dev_center_project_pool#read DataAzurermDevCenterProjectPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDevCenterProjectPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterProjectPool.DataAzurermDevCenterProjectPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDevCenterProjectPool.IDataAzurermDevCenterProjectPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/dev_center_project_pool#read DataAzurermDevCenterProjectPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
