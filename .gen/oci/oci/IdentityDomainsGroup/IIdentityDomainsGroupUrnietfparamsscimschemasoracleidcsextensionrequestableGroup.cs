using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGroup
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroup), fullyQualifiedName: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroup")]
    public interface IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#requestable IdentityDomainsGroup#requestable}.</summary>
        [JsiiProperty(name: "requestable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Requestable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroup), fullyQualifiedName: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroup")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#requestable IdentityDomainsGroup#requestable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Requestable
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
