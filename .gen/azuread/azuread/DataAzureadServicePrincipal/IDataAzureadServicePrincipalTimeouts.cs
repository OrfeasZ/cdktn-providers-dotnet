using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadServicePrincipal
{
    [JsiiInterface(nativeType: typeof(IDataAzureadServicePrincipalTimeouts), fullyQualifiedName: "azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalTimeouts")]
    public interface IDataAzureadServicePrincipalTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/service_principal#read DataAzureadServicePrincipal#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadServicePrincipalTimeouts), fullyQualifiedName: "azuread.dataAzureadServicePrincipal.DataAzureadServicePrincipalTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadServicePrincipal.IDataAzureadServicePrincipalTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/service_principal#read DataAzureadServicePrincipal#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
