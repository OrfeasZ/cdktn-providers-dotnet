using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingPersonalizationDesign
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignPreferences")]
    public class IssuingPersonalizationDesignPreferences : stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignPreferences
    {
        private object _isDefault;

        /// <summary>Whether we use this personalization design to create cards when one isn't specified.</summary>
        /// <remarks>
        /// A connected account uses the Connect platform's default design if no personalization design is set as the default design.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#is_default IssuingPersonalizationDesign#is_default}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsDefault
        {
            get => _isDefault;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isDefault = value;
            }
        }
    }
}
