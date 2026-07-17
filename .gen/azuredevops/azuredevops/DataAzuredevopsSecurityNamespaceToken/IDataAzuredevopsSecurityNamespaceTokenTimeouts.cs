using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsSecurityNamespaceToken
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsSecurityNamespaceTokenTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsSecurityNamespaceToken.DataAzuredevopsSecurityNamespaceTokenTimeouts")]
    public interface IDataAzuredevopsSecurityNamespaceTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/security_namespace_token#read DataAzuredevopsSecurityNamespaceToken#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsSecurityNamespaceTokenTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsSecurityNamespaceToken.DataAzuredevopsSecurityNamespaceTokenTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsSecurityNamespaceToken.IDataAzuredevopsSecurityNamespaceTokenTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/security_namespace_token#read DataAzuredevopsSecurityNamespaceToken#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
