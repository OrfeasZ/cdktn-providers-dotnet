using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiClass(nativeType: typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceOutputReference), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ThreeDSecureAuthenticationFlowPreferenceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ThreeDSecureAuthenticationFlowPreferenceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ThreeDSecureAuthenticationFlowPreferenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ThreeDSecureAuthenticationFlowPreferenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceChallenge\"}}]")]
        public virtual void PutChallenge(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataShare", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceDataShare\"}}]")]
        public virtual void PutDataShare(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceDataShare @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceDataShare)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrictionless", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionless\"}}]")]
        public virtual void PutFrictionless(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceFrictionless @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceFrictionless)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetChallenge")]
        public virtual void ResetChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataShare")]
        public virtual void ResetDataShare()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrictionless")]
        public virtual void ResetFrictionless()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "challenge", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceChallengeOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceChallengeOutputReference Challenge
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "dataShare", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceDataShareOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceDataShareOutputReference DataShare
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceDataShareOutputReference>()!;
        }

        [JsiiProperty(name: "frictionless", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionlessOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionlessOutputReference Frictionless
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionlessOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceChallenge" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "challengeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceChallenge\"}]}}", isOptional: true)]
        public virtual object? ChallengeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceDataShare" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataShareInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceDataShare\"}]}}", isOptional: true)]
        public virtual object? DataShareInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceFrictionless" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frictionlessInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionless\"}]}}", isOptional: true)]
        public virtual object? FrictionlessInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreference\"}]}}", isOptional: true)]
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
                        case stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
