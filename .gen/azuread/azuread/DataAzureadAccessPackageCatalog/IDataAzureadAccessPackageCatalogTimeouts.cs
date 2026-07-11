using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadAccessPackageCatalog
{
    [JsiiInterface(nativeType: typeof(IDataAzureadAccessPackageCatalogTimeouts), fullyQualifiedName: "azuread.dataAzureadAccessPackageCatalog.DataAzureadAccessPackageCatalogTimeouts")]
    public interface IDataAzureadAccessPackageCatalogTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package_catalog#read DataAzureadAccessPackageCatalog#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadAccessPackageCatalogTimeouts), fullyQualifiedName: "azuread.dataAzureadAccessPackageCatalog.DataAzureadAccessPackageCatalogTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadAccessPackageCatalog.IDataAzureadAccessPackageCatalogTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package_catalog#read DataAzureadAccessPackageCatalog#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
