using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiClass(nativeType: typeof(cloudflare.AccountToken.AccountTokenConditionOutputReference), fullyQualifiedName: "cloudflare.accountToken.AccountTokenConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AccountTokenConditionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AccountTokenConditionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AccountTokenConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccountTokenConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRequestIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.accountToken.AccountTokenConditionRequestIp\"}}]")]
        public virtual void PutRequestIp(cloudflare.AccountToken.IAccountTokenConditionRequestIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AccountToken.IAccountTokenConditionRequestIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRequestIp")]
        public virtual void ResetRequestIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.accountToken.AccountTokenConditionRequestIpOutputReference\"}")]
        public virtual cloudflare.AccountToken.AccountTokenConditionRequestIpOutputReference RequestIp
        {
            get => GetInstanceProperty<cloudflare.AccountToken.AccountTokenConditionRequestIpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestIpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.accountToken.AccountTokenConditionRequestIp\"}]}}", isOptional: true)]
        public virtual object? RequestIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.accountToken.AccountTokenCondition\"}]}}", isOptional: true)]
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
                        case cloudflare.AccountToken.IAccountTokenCondition cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AccountToken.IAccountTokenCondition).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
