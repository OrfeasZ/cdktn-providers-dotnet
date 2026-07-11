using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadGroups
{
    [JsiiInterface(nativeType: typeof(IDataAzureadGroupsTimeouts), fullyQualifiedName: "azuread.dataAzureadGroups.DataAzureadGroupsTimeouts")]
    public interface IDataAzureadGroupsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/groups#read DataAzureadGroups#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadGroupsTimeouts), fullyQualifiedName: "azuread.dataAzureadGroups.DataAzureadGroupsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadGroups.IDataAzureadGroupsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/groups#read DataAzureadGroups#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
