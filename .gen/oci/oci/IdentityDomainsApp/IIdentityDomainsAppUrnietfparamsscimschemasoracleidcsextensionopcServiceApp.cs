using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_instance_identifier IdentityDomainsApp#service_instance_identifier}.</summary>
        [JsiiProperty(name: "serviceInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceInstanceIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_instance_identifier IdentityDomainsApp#service_instance_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceInstanceIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
