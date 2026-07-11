using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackManagedDisk
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackManagedDiskTimeouts), fullyQualifiedName: "azurestack.dataAzurestackManagedDisk.DataAzurestackManagedDiskTimeouts")]
    public interface IDataAzurestackManagedDiskTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/managed_disk#read DataAzurestackManagedDisk#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackManagedDiskTimeouts), fullyQualifiedName: "azurestack.dataAzurestackManagedDisk.DataAzurestackManagedDiskTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackManagedDisk.IDataAzurestackManagedDiskTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/managed_disk#read DataAzurestackManagedDisk#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
