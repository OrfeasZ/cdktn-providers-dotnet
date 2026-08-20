using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenter
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDevCenterTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenter.DataAzurermDevCenterTimeouts")]
    public interface IDataAzurermDevCenterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/dev_center#read DataAzurermDevCenter#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDevCenterTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenter.DataAzurermDevCenterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDevCenter.IDataAzurermDevCenterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/dev_center#read DataAzurermDevCenter#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
