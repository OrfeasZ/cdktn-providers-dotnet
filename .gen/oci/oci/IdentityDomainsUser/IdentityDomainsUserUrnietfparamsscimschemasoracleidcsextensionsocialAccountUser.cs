using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUser
    {
        private object? _socialAccounts;

        /// <summary>social_accounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#social_accounts IdentityDomainsUser#social_accounts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "socialAccounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserSocialAccounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SocialAccounts
        {
            get => _socialAccounts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserSocialAccounts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionsocialAccountUserSocialAccounts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _socialAccounts = value;
            }
        }
    }
}
