using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthToken
{
    [JsiiByValue(fqn: "oci.identityDomainsAuthToken.IdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser")]
    public class IdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser : oci.IdentityDomainsAuthToken.IIdentityDomainsAuthTokenUrnietfparamsscimschemasoracleidcsextensionselfChangeUser
    {
        private object? _allowSelfChange;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_auth_token#allow_self_change IdentityDomainsAuthToken#allow_self_change}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowSelfChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowSelfChange
        {
            get => _allowSelfChange;
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
                _allowSelfChange = value;
            }
        }
    }
}
