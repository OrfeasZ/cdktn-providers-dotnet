using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadDirectoryObject
{
    [JsiiInterface(nativeType: typeof(IDataAzureadDirectoryObjectTimeouts), fullyQualifiedName: "azuread.dataAzureadDirectoryObject.DataAzureadDirectoryObjectTimeouts")]
    public interface IDataAzureadDirectoryObjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_object#read DataAzureadDirectoryObject#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadDirectoryObjectTimeouts), fullyQualifiedName: "azuread.dataAzureadDirectoryObject.DataAzureadDirectoryObjectTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadDirectoryObject.IDataAzureadDirectoryObjectTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_object#read DataAzureadDirectoryObject#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
