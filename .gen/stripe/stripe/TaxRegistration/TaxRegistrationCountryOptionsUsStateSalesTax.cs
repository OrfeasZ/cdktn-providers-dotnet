using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TaxRegistration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTax")]
    public class TaxRegistrationCountryOptionsUsStateSalesTax : stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTax
    {
        private object _elections;

        /// <summary>Elections for the state sales tax registration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/tax_registration#elections TaxRegistration#elections}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTaxElections" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "elections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.taxRegistration.TaxRegistrationCountryOptionsUsStateSalesTaxElections\"},\"kind\":\"array\"}}]}}")]
        public object Elections
        {
            get => _elections;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTaxElections[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTaxElections).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TaxRegistration.ITaxRegistrationCountryOptionsUsStateSalesTaxElections).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _elections = value;
            }
        }
    }
}
