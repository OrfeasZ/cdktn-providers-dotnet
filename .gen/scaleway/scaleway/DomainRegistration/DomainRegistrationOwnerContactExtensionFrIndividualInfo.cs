using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfo")]
    public class DomainRegistrationOwnerContactExtensionFrIndividualInfo : scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo
    {
        private object? _whoisOptIn;

        /// <summary>Whether the individual contact has opted into WHOIS publishing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#whois_opt_in DomainRegistration#whois_opt_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "whoisOptIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? WhoisOptIn
        {
            get => _whoisOptIn;
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
                _whoisOptIn = value;
            }
        }
    }
}
