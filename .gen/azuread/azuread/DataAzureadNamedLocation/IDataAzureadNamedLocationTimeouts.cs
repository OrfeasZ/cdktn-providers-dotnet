using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadNamedLocation
{
    [JsiiInterface(nativeType: typeof(IDataAzureadNamedLocationTimeouts), fullyQualifiedName: "azuread.dataAzureadNamedLocation.DataAzureadNamedLocationTimeouts")]
    public interface IDataAzureadNamedLocationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/named_location#read DataAzureadNamedLocation#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadNamedLocationTimeouts), fullyQualifiedName: "azuread.dataAzureadNamedLocation.DataAzureadNamedLocationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadNamedLocation.IDataAzureadNamedLocationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/named_location#read DataAzureadNamedLocation#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
