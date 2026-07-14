using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IDataAzurermManagedDevopsPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolTimeouts")]
    public interface IDataAzurermManagedDevopsPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/managed_devops_pool#read DataAzurermManagedDevopsPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermManagedDevopsPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/managed_devops_pool#read DataAzurermManagedDevopsPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
