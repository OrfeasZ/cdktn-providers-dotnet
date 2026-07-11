using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadDirectoryRoleTemplates
{
    [JsiiInterface(nativeType: typeof(IDataAzureadDirectoryRoleTemplatesTimeouts), fullyQualifiedName: "azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesTimeouts")]
    public interface IDataAzureadDirectoryRoleTemplatesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_role_templates#read DataAzureadDirectoryRoleTemplates#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadDirectoryRoleTemplatesTimeouts), fullyQualifiedName: "azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadDirectoryRoleTemplates.IDataAzureadDirectoryRoleTemplatesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_role_templates#read DataAzureadDirectoryRoleTemplates#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
