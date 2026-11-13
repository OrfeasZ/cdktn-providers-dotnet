using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiClass(nativeType: typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationChannelOutputReference), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ThreeDSecureAuthenticationChannelOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ThreeDSecureAuthenticationChannelOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ThreeDSecureAuthenticationChannelOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ThreeDSecureAuthenticationChannelOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBrowser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowser\"}}]")]
        public virtual void PutBrowser(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelBrowser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelBrowser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreeRI", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRI\"}}]")]
        public virtual void PutThreeRI(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelThreeRI @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelThreeRI)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBrowser")]
        public virtual void ResetBrowser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreeRI")]
        public virtual void ResetThreeRI()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "browser", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowserOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowserOutputReference Browser
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowserOutputReference>()!;
        }

        [JsiiProperty(name: "threeRI", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRIOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRIOutputReference ThreeRI
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRIOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelBrowser" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "browserInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowser\"}]}}", isOptional: true)]
        public virtual object? BrowserInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelThreeRI" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threeRIInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRI\"}]}}", isOptional: true)]
        public virtual object? ThreeRIInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannel\"}]}}", isOptional: true)]
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
                        case stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
