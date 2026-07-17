using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsIdentityGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsIdentityGroupTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsIdentityGroup.DataAzuredevopsIdentityGroupTimeouts")]
    public interface IDataAzuredevopsIdentityGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/identity_group#read DataAzuredevopsIdentityGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsIdentityGroupTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsIdentityGroup.DataAzuredevopsIdentityGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsIdentityGroup.IDataAzuredevopsIdentityGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/identity_group#read DataAzuredevopsIdentityGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
