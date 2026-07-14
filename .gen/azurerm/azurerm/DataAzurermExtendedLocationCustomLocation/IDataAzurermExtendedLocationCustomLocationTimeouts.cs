using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExtendedLocationCustomLocation
{
    [JsiiInterface(nativeType: typeof(IDataAzurermExtendedLocationCustomLocationTimeouts), fullyQualifiedName: "azurerm.dataAzurermExtendedLocationCustomLocation.DataAzurermExtendedLocationCustomLocationTimeouts")]
    public interface IDataAzurermExtendedLocationCustomLocationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/extended_location_custom_location#read DataAzurermExtendedLocationCustomLocation#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermExtendedLocationCustomLocationTimeouts), fullyQualifiedName: "azurerm.dataAzurermExtendedLocationCustomLocation.DataAzurermExtendedLocationCustomLocationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermExtendedLocationCustomLocation.IDataAzurermExtendedLocationCustomLocationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/extended_location_custom_location#read DataAzurermExtendedLocationCustomLocation#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
