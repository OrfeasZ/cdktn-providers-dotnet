using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadApplicationTemplate
{
    [JsiiInterface(nativeType: typeof(IDataAzureadApplicationTemplateTimeouts), fullyQualifiedName: "azuread.dataAzureadApplicationTemplate.DataAzureadApplicationTemplateTimeouts")]
    public interface IDataAzureadApplicationTemplateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application_template#read DataAzureadApplicationTemplate#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadApplicationTemplateTimeouts), fullyQualifiedName: "azuread.dataAzureadApplicationTemplate.DataAzureadApplicationTemplateTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadApplicationTemplate.IDataAzureadApplicationTemplateTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application_template#read DataAzureadApplicationTemplate#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
