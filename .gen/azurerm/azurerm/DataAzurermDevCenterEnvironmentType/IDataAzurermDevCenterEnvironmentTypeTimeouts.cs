using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterEnvironmentType
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDevCenterEnvironmentTypeTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterEnvironmentType.DataAzurermDevCenterEnvironmentTypeTimeouts")]
    public interface IDataAzurermDevCenterEnvironmentTypeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/dev_center_environment_type#read DataAzurermDevCenterEnvironmentType#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDevCenterEnvironmentTypeTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterEnvironmentType.DataAzurermDevCenterEnvironmentTypeTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDevCenterEnvironmentType.IDataAzurermDevCenterEnvironmentTypeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/dev_center_environment_type#read DataAzurermDevCenterEnvironmentType#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
