using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#resource_ref IdentityDomainsApp#resource_ref}.</summary>
        [JsiiProperty(name: "resourceRef", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#web_tier_policy_az_control IdentityDomainsApp#web_tier_policy_az_control}.</summary>
        [JsiiProperty(name: "webTierPolicyAzControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebTierPolicyAzControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#web_tier_policy_json IdentityDomainsApp#web_tier_policy_json}.</summary>
        [JsiiProperty(name: "webTierPolicyJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebTierPolicyJson
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#resource_ref IdentityDomainsApp#resource_ref}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRef", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ResourceRef
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#web_tier_policy_az_control IdentityDomainsApp#web_tier_policy_az_control}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webTierPolicyAzControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebTierPolicyAzControl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#web_tier_policy_json IdentityDomainsApp#web_tier_policy_json}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webTierPolicyJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebTierPolicyJson
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
