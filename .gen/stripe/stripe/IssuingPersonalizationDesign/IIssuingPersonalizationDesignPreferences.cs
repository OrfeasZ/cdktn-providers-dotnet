using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingPersonalizationDesign
{
    [JsiiInterface(nativeType: typeof(IIssuingPersonalizationDesignPreferences), fullyQualifiedName: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignPreferences")]
    public interface IIssuingPersonalizationDesignPreferences
    {
        /// <summary>Whether we use this personalization design to create cards when one isn't specified.</summary>
        /// <remarks>
        /// A connected account uses the Connect platform's default design if no personalization design is set as the default design.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#is_default IssuingPersonalizationDesign#is_default}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsDefault
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingPersonalizationDesignPreferences), fullyQualifiedName: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignPreferences")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignPreferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
