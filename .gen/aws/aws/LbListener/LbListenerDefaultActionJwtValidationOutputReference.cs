using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListener
{
    [JsiiClass(nativeType: typeof(aws.LbListener.LbListenerDefaultActionJwtValidationOutputReference), fullyQualifiedName: "aws.lbListener.LbListenerDefaultActionJwtValidationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LbListenerDefaultActionJwtValidationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LbListenerDefaultActionJwtValidationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LbListenerDefaultActionJwtValidationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerDefaultActionJwtValidationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdditionalClaim", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdditionalClaim(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.LbListener.ILbListenerDefaultActionJwtValidationAdditionalClaim[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LbListener.ILbListenerDefaultActionJwtValidationAdditionalClaim).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LbListener.ILbListenerDefaultActionJwtValidationAdditionalClaim).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalClaim")]
        public virtual void ResetAdditionalClaim()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "additionalClaim", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionJwtValidationAdditionalClaimList\"}")]
        public virtual aws.LbListener.LbListenerDefaultActionJwtValidationAdditionalClaimList AdditionalClaim
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerDefaultActionJwtValidationAdditionalClaimList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalClaimInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdditionalClaimInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwksEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JwksEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwksEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwksEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionJwtValidation\"}", isOptional: true)]
        public virtual aws.LbListener.ILbListenerDefaultActionJwtValidation? InternalValue
        {
            get => GetInstanceProperty<aws.LbListener.ILbListenerDefaultActionJwtValidation?>();
            set => SetInstanceProperty(value);
        }
    }
}
