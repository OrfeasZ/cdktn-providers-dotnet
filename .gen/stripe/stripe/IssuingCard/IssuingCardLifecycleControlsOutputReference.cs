using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiClass(nativeType: typeof(stripe.IssuingCard.IssuingCardLifecycleControlsOutputReference), fullyQualifiedName: "stripe.issuingCard.IssuingCardLifecycleControlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IssuingCardLifecycleControlsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IssuingCardLifecycleControlsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IssuingCardLifecycleControlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCardLifecycleControlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCancelAfter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControlsCancelAfter\"}}]")]
        public virtual void PutCancelAfter(stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter)}, new object[]{@value});
        }

        [JsiiProperty(name: "cancelAfter", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControlsCancelAfterOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardLifecycleControlsCancelAfterOutputReference CancelAfter
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardLifecycleControlsCancelAfterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cancelAfterInput", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControlsCancelAfter\"}", isOptional: true)]
        public virtual stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter? CancelAfterInput
        {
            get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCard.IIssuingCardLifecycleControls" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControls\"}]}}", isOptional: true)]
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
                        case stripe.IssuingCard.IIssuingCardLifecycleControls cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.IssuingCard.IIssuingCardLifecycleControls).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
