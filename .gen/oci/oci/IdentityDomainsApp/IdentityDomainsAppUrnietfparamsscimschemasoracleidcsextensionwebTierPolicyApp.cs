using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp
    {
        private object? _resourceRef;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#resource_ref IdentityDomainsApp#resource_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRef", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ResourceRef
        {
            get => _resourceRef;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceRef = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#web_tier_policy_az_control IdentityDomainsApp#web_tier_policy_az_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webTierPolicyAzControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebTierPolicyAzControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#web_tier_policy_json IdentityDomainsApp#web_tier_policy_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webTierPolicyJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebTierPolicyJson
        {
            get;
            set;
        }
    }
}
