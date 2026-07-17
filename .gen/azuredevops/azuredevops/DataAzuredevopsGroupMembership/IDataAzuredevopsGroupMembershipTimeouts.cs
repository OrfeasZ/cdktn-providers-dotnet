using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsGroupMembership
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsGroupMembershipTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsGroupMembership.DataAzuredevopsGroupMembershipTimeouts")]
    public interface IDataAzuredevopsGroupMembershipTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/group_membership#read DataAzuredevopsGroupMembership#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsGroupMembershipTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsGroupMembership.DataAzuredevopsGroupMembershipTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsGroupMembership.IDataAzuredevopsGroupMembershipTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/group_membership#read DataAzuredevopsGroupMembership#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
