using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_app#requestable IdentityDomainsApp#requestable}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requestable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Requestable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/identity_domains_app#requestable IdentityDomainsApp#requestable}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Requestable
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
