using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiClass(nativeType: typeof(stripe.PaymentLink.PaymentLinkCustomFieldsOutputReference), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFieldsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class PaymentLinkCustomFieldsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public PaymentLinkCustomFieldsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLinkCustomFieldsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLinkCustomFieldsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDropdown", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdown\"}}]")]
        public virtual void PutDropdown(stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLabel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsLabel\"}}]")]
        public virtual void PutLabel(stripe.PaymentLink.IPaymentLinkCustomFieldsLabel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomFieldsLabel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumeric", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsNumeric\"}}]")]
        public virtual void PutNumeric(stripe.PaymentLink.IPaymentLinkCustomFieldsNumeric @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomFieldsNumeric)}, new object[]{@value});
        }

        [JsiiMethod(name: "putText", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsText\"}}]")]
        public virtual void PutText(stripe.PaymentLink.IPaymentLinkCustomFieldsText @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomFieldsText)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDropdown")]
        public virtual void ResetDropdown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumeric")]
        public virtual void ResetNumeric()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptional")]
        public virtual void ResetOptional()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetText")]
        public virtual void ResetText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dropdown", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdownOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomFieldsDropdownOutputReference Dropdown
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomFieldsDropdownOutputReference>()!;
        }

        [JsiiProperty(name: "label", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsLabelOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomFieldsLabelOutputReference Label
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomFieldsLabelOutputReference>()!;
        }

        [JsiiProperty(name: "numeric", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsNumericOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomFieldsNumericOutputReference Numeric
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomFieldsNumericOutputReference>()!;
        }

        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsTextOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomFieldsTextOutputReference Text
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomFieldsTextOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomFieldsDropdown" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dropdownInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsDropdown\"}]}}", isOptional: true)]
        public virtual object? DropdownInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelInput", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsLabel\"}", isOptional: true)]
        public virtual stripe.PaymentLink.IPaymentLinkCustomFieldsLabel? LabelInput
        {
            get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomFieldsLabel?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomFieldsNumeric" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numericInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsNumeric\"}]}}", isOptional: true)]
        public virtual object? NumericInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optionalInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OptionalInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomFieldsText" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "textInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsText\"}]}}", isOptional: true)]
        public virtual object? TextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "optional", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Optional
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomFields" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFields\"}]}}", isOptional: true)]
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
                        case stripe.PaymentLink.IPaymentLinkCustomFields cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkCustomFields).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
