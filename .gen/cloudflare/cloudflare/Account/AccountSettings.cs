using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Account
{
    [JsiiByValue(fqn: "cloudflare.account.AccountSettings")]
    public class AccountSettings : cloudflare.Account.IAccountSettings
    {
        /// <summary>Sets an abuse contact email to notify for abuse reports.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account#abuse_contact_email Account#abuse_contact_email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "abuseContactEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AbuseContactEmail
        {
            get;
            set;
        }

        private object? _enforceTwofactor;

        /// <summary>Indicates whether membership in this account requires that Two-Factor Authentication is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account#enforce_twofactor Account#enforce_twofactor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enforceTwofactor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnforceTwofactor
        {
            get => _enforceTwofactor;
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
                _enforceTwofactor = value;
            }
        }
    }
}
