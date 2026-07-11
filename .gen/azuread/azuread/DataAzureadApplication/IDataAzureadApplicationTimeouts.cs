using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadApplication
{
    [JsiiInterface(nativeType: typeof(IDataAzureadApplicationTimeouts), fullyQualifiedName: "azuread.dataAzureadApplication.DataAzureadApplicationTimeouts")]
    public interface IDataAzureadApplicationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application#read DataAzureadApplication#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadApplicationTimeouts), fullyQualifiedName: "azuread.dataAzureadApplication.DataAzureadApplicationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadApplication.IDataAzureadApplicationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application#read DataAzureadApplication#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
