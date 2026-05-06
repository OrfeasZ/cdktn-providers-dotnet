using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityPropagationTrust
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsIdentityPropagationTrustKeytab), fullyQualifiedName: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustKeytab")]
    public interface IIdentityDomainsIdentityPropagationTrustKeytab
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#secret_ocid IdentityDomainsIdentityPropagationTrust#secret_ocid}.</summary>
        [JsiiProperty(name: "secretOcid", typeJson: "{\"primitive\":\"string\"}")]
        string SecretOcid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#secret_version IdentityDomainsIdentityPropagationTrust#secret_version}.</summary>
        [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SecretVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsIdentityPropagationTrustKeytab), fullyQualifiedName: "oci.identityDomainsIdentityPropagationTrust.IdentityDomainsIdentityPropagationTrustKeytab")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsIdentityPropagationTrust.IIdentityDomainsIdentityPropagationTrustKeytab
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#secret_ocid IdentityDomainsIdentityPropagationTrust#secret_ocid}.</summary>
            [JsiiProperty(name: "secretOcid", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretOcid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_propagation_trust#secret_version IdentityDomainsIdentityPropagationTrust#secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SecretVersion
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
