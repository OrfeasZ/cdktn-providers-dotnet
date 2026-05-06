using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSecurityQuestion
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSecurityQuestionTags), fullyQualifiedName: "oci.identityDomainsSecurityQuestion.IdentityDomainsSecurityQuestionTags")]
    public interface IIdentityDomainsSecurityQuestionTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_security_question#key IdentityDomainsSecurityQuestion#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_security_question#value IdentityDomainsSecurityQuestion#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSecurityQuestionTags), fullyQualifiedName: "oci.identityDomainsSecurityQuestion.IdentityDomainsSecurityQuestionTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSecurityQuestion.IIdentityDomainsSecurityQuestionTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_security_question#key IdentityDomainsSecurityQuestion#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_security_question#value IdentityDomainsSecurityQuestion#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
