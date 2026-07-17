using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsProjects
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsProjectsTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsProjects.DataAzuredevopsProjectsTimeouts")]
    public interface IDataAzuredevopsProjectsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/projects#read DataAzuredevopsProjects#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsProjectsTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsProjects.DataAzuredevopsProjectsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsProjects.IDataAzuredevopsProjectsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/projects#read DataAzuredevopsProjects#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
