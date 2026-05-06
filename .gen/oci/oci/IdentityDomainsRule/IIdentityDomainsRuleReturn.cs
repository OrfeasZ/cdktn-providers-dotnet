using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsRule
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsRuleReturn), fullyQualifiedName: "oci.identityDomainsRule.IdentityDomainsRuleReturn")]
    public interface IIdentityDomainsRuleReturn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#name IdentityDomainsRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#value IdentityDomainsRule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#return_groovy IdentityDomainsRule#return_groovy}.</summary>
        [JsiiProperty(name: "returnGroovy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReturnGroovy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsRuleReturn), fullyQualifiedName: "oci.identityDomainsRule.IdentityDomainsRuleReturn")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsRule.IIdentityDomainsRuleReturn
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#name IdentityDomainsRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#value IdentityDomainsRule#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_rule#return_groovy IdentityDomainsRule#return_groovy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "returnGroovy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReturnGroovy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
