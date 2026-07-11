using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsIdentityGroups
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsIdentityGroupsTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsIdentityGroups.DataAzuredevopsIdentityGroupsTimeouts")]
    public interface IDataAzuredevopsIdentityGroupsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/identity_groups#read DataAzuredevopsIdentityGroups#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsIdentityGroupsTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsIdentityGroups.DataAzuredevopsIdentityGroupsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsIdentityGroups.IDataAzuredevopsIdentityGroupsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/identity_groups#read DataAzuredevopsIdentityGroups#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
