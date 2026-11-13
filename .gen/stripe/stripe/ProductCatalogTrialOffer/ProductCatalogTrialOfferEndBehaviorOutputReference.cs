using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    [JsiiClass(nativeType: typeof(stripe.ProductCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorOutputReference), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ProductCatalogTrialOfferEndBehaviorOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ProductCatalogTrialOfferEndBehaviorOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProductCatalogTrialOfferEndBehaviorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProductCatalogTrialOfferEndBehaviorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTransition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransition\"}}]")]
        public virtual void PutTransition(stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition)}, new object[]{@value});
        }

        [JsiiProperty(name: "transition", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransitionOutputReference\"}")]
        public virtual stripe.ProductCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransitionOutputReference Transition
        {
            get => GetInstanceProperty<stripe.ProductCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransitionOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehaviorTransition" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorTransition\"}]}}", isOptional: true)]
        public virtual object? TransitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehavior\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
