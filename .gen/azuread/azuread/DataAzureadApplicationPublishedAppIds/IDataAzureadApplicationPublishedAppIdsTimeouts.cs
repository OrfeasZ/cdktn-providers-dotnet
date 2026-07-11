using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadApplicationPublishedAppIds
{
    [JsiiInterface(nativeType: typeof(IDataAzureadApplicationPublishedAppIdsTimeouts), fullyQualifiedName: "azuread.dataAzureadApplicationPublishedAppIds.DataAzureadApplicationPublishedAppIdsTimeouts")]
    public interface IDataAzureadApplicationPublishedAppIdsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application_published_app_ids#read DataAzureadApplicationPublishedAppIds#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadApplicationPublishedAppIdsTimeouts), fullyQualifiedName: "azuread.dataAzureadApplicationPublishedAppIds.DataAzureadApplicationPublishedAppIdsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadApplicationPublishedAppIds.IDataAzureadApplicationPublishedAppIdsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application_published_app_ids#read DataAzureadApplicationPublishedAppIds#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
