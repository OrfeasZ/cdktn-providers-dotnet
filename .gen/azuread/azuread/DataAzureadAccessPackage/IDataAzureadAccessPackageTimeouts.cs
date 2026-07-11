using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadAccessPackage
{
    [JsiiInterface(nativeType: typeof(IDataAzureadAccessPackageTimeouts), fullyQualifiedName: "azuread.dataAzureadAccessPackage.DataAzureadAccessPackageTimeouts")]
    public interface IDataAzureadAccessPackageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package#read DataAzureadAccessPackage#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadAccessPackageTimeouts), fullyQualifiedName: "azuread.dataAzureadAccessPackage.DataAzureadAccessPackageTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadAccessPackage.IDataAzureadAccessPackageTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package#read DataAzureadAccessPackage#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
