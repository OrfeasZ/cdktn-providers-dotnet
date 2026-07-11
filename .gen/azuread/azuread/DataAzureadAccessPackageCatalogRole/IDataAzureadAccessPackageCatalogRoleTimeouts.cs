using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadAccessPackageCatalogRole
{
    [JsiiInterface(nativeType: typeof(IDataAzureadAccessPackageCatalogRoleTimeouts), fullyQualifiedName: "azuread.dataAzureadAccessPackageCatalogRole.DataAzureadAccessPackageCatalogRoleTimeouts")]
    public interface IDataAzureadAccessPackageCatalogRoleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package_catalog_role#read DataAzureadAccessPackageCatalogRole#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadAccessPackageCatalogRoleTimeouts), fullyQualifiedName: "azuread.dataAzureadAccessPackageCatalogRole.DataAzureadAccessPackageCatalogRoleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadAccessPackageCatalogRole.IDataAzureadAccessPackageCatalogRoleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package_catalog_role#read DataAzureadAccessPackageCatalogRole#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
