using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiClass(nativeType: typeof(stripe.IssuingCardholder.IssuingCardholderIndividualCardIssuingOutputReference), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IssuingCardholderIndividualCardIssuingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IssuingCardholderIndividualCardIssuingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IssuingCardholderIndividualCardIssuingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCardholderIndividualCardIssuingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putUserTermsAcceptance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptance\"}}]")]
        public virtual void PutUserTermsAcceptance(stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuingUserTermsAcceptance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuingUserTermsAcceptance)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetUserTermsAcceptance")]
        public virtual void ResetUserTermsAcceptance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "userTermsAcceptance", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptanceOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptanceOutputReference UserTermsAcceptance
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptanceOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuingUserTermsAcceptance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userTermsAcceptanceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptance\"}]}}", isOptional: true)]
        public virtual object? UserTermsAcceptanceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuing\"}]}}", isOptional: true)]
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
                        case stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
