using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzureadGroupTimeouts), fullyQualifiedName: "azuread.dataAzureadGroup.DataAzureadGroupTimeouts")]
    public interface IDataAzureadGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/group#read DataAzureadGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadGroupTimeouts), fullyQualifiedName: "azuread.dataAzureadGroup.DataAzureadGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadGroup.IDataAzureadGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/group#read DataAzureadGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
