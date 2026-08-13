using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    [JsiiClass(nativeType: typeof(stripe.IssuingDispute.IssuingDisputeEvidenceOutputReference), fullyQualifiedName: "stripe.issuingDispute.IssuingDisputeEvidenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IssuingDisputeEvidenceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IssuingDisputeEvidenceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IssuingDisputeEvidenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingDisputeEvidenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCanceled", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceCanceled\"}}]")]
        public virtual void PutCanceled(stripe.IssuingDispute.IIssuingDisputeEvidenceCanceled @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingDispute.IIssuingDisputeEvidenceCanceled)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDuplicate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceDuplicate\"}}]")]
        public virtual void PutDuplicate(stripe.IssuingDispute.IIssuingDisputeEvidenceDuplicate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingDispute.IIssuingDisputeEvidenceDuplicate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFraudulent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceFraudulent\"}}]")]
        public virtual void PutFraudulent(stripe.IssuingDispute.IIssuingDisputeEvidenceFraudulent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingDispute.IIssuingDisputeEvidenceFraudulent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMerchandiseNotAsDescribed", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribed\"}}]")]
        public virtual void PutMerchandiseNotAsDescribed(stripe.IssuingDispute.IIssuingDisputeEvidenceMerchandiseNotAsDescribed @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingDispute.IIssuingDisputeEvidenceMerchandiseNotAsDescribed)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotReceived", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceNotReceived\"}}]")]
        public virtual void PutNotReceived(stripe.IssuingDispute.IIssuingDisputeEvidenceNotReceived @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingDispute.IIssuingDisputeEvidenceNotReceived)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoValidAuthorization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceNoValidAuthorization\"}}]")]
        public virtual void PutNoValidAuthorization(stripe.IssuingDispute.IIssuingDisputeEvidenceNoValidAuthorization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingDispute.IIssuingDisputeEvidenceNoValidAuthorization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOther", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceOther\"}}]")]
        public virtual void PutOther(stripe.IssuingDispute.IIssuingDisputeEvidenceOther @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingDispute.IIssuingDisputeEvidenceOther)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceNotAsDescribed", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceServiceNotAsDescribed\"}}]")]
        public virtual void PutServiceNotAsDescribed(stripe.IssuingDispute.IIssuingDisputeEvidenceServiceNotAsDescribed @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingDispute.IIssuingDisputeEvidenceServiceNotAsDescribed)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCanceled")]
        public virtual void ResetCanceled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDuplicate")]
        public virtual void ResetDuplicate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFraudulent")]
        public virtual void ResetFraudulent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMerchandiseNotAsDescribed")]
        public virtual void ResetMerchandiseNotAsDescribed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotReceived")]
        public virtual void ResetNotReceived()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoValidAuthorization")]
        public virtual void ResetNoValidAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOther")]
        public virtual void ResetOther()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReason")]
        public virtual void ResetReason()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceNotAsDescribed")]
        public virtual void ResetServiceNotAsDescribed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "canceled", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceCanceledOutputReference\"}")]
        public virtual stripe.IssuingDispute.IssuingDisputeEvidenceCanceledOutputReference Canceled
        {
            get => GetInstanceProperty<stripe.IssuingDispute.IssuingDisputeEvidenceCanceledOutputReference>()!;
        }

        [JsiiProperty(name: "duplicate", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceDuplicateOutputReference\"}")]
        public virtual stripe.IssuingDispute.IssuingDisputeEvidenceDuplicateOutputReference Duplicate
        {
            get => GetInstanceProperty<stripe.IssuingDispute.IssuingDisputeEvidenceDuplicateOutputReference>()!;
        }

        [JsiiProperty(name: "fraudulent", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceFraudulentOutputReference\"}")]
        public virtual stripe.IssuingDispute.IssuingDisputeEvidenceFraudulentOutputReference Fraudulent
        {
            get => GetInstanceProperty<stripe.IssuingDispute.IssuingDisputeEvidenceFraudulentOutputReference>()!;
        }

        [JsiiProperty(name: "merchandiseNotAsDescribed", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribedOutputReference\"}")]
        public virtual stripe.IssuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribedOutputReference MerchandiseNotAsDescribed
        {
            get => GetInstanceProperty<stripe.IssuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribedOutputReference>()!;
        }

        [JsiiProperty(name: "notReceived", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceNotReceivedOutputReference\"}")]
        public virtual stripe.IssuingDispute.IssuingDisputeEvidenceNotReceivedOutputReference NotReceived
        {
            get => GetInstanceProperty<stripe.IssuingDispute.IssuingDisputeEvidenceNotReceivedOutputReference>()!;
        }

        [JsiiProperty(name: "noValidAuthorization", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceNoValidAuthorizationOutputReference\"}")]
        public virtual stripe.IssuingDispute.IssuingDisputeEvidenceNoValidAuthorizationOutputReference NoValidAuthorization
        {
            get => GetInstanceProperty<stripe.IssuingDispute.IssuingDisputeEvidenceNoValidAuthorizationOutputReference>()!;
        }

        [JsiiProperty(name: "other", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceOtherOutputReference\"}")]
        public virtual stripe.IssuingDispute.IssuingDisputeEvidenceOtherOutputReference Other
        {
            get => GetInstanceProperty<stripe.IssuingDispute.IssuingDisputeEvidenceOtherOutputReference>()!;
        }

        [JsiiProperty(name: "serviceNotAsDescribed", typeJson: "{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceServiceNotAsDescribedOutputReference\"}")]
        public virtual stripe.IssuingDispute.IssuingDisputeEvidenceServiceNotAsDescribedOutputReference ServiceNotAsDescribed
        {
            get => GetInstanceProperty<stripe.IssuingDispute.IssuingDisputeEvidenceServiceNotAsDescribedOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidenceCanceled" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "canceledInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceCanceled\"}]}}", isOptional: true)]
        public virtual object? CanceledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidenceDuplicate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "duplicateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceDuplicate\"}]}}", isOptional: true)]
        public virtual object? DuplicateInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidenceFraudulent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fraudulentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceFraudulent\"}]}}", isOptional: true)]
        public virtual object? FraudulentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidenceMerchandiseNotAsDescribed" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "merchandiseNotAsDescribedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceMerchandiseNotAsDescribed\"}]}}", isOptional: true)]
        public virtual object? MerchandiseNotAsDescribedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidenceNotReceived" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notReceivedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceNotReceived\"}]}}", isOptional: true)]
        public virtual object? NotReceivedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidenceNoValidAuthorization" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noValidAuthorizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceNoValidAuthorization\"}]}}", isOptional: true)]
        public virtual object? NoValidAuthorizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidenceOther" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "otherInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceOther\"}]}}", isOptional: true)]
        public virtual object? OtherInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reasonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReasonInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidenceServiceNotAsDescribed" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceNotAsDescribedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidenceServiceNotAsDescribed\"}]}}", isOptional: true)]
        public virtual object? ServiceNotAsDescribedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingDispute.IIssuingDisputeEvidence" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingDispute.IssuingDisputeEvidence\"}]}}", isOptional: true)]
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
                        case stripe.IssuingDispute.IIssuingDisputeEvidence cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.IssuingDispute.IIssuingDisputeEvidence).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
