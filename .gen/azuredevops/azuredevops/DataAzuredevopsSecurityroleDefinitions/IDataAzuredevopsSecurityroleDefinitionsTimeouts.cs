using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsSecurityroleDefinitions
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsSecurityroleDefinitionsTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsSecurityroleDefinitions.DataAzuredevopsSecurityroleDefinitionsTimeouts")]
    public interface IDataAzuredevopsSecurityroleDefinitionsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/securityrole_definitions#read DataAzuredevopsSecurityroleDefinitions#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsSecurityroleDefinitionsTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsSecurityroleDefinitions.DataAzuredevopsSecurityroleDefinitionsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsSecurityroleDefinitions.IDataAzuredevopsSecurityroleDefinitionsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/securityrole_definitions#read DataAzuredevopsSecurityroleDefinitions#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
