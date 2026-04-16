using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiClass(nativeType: typeof(cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyOutputReference), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RulesetRulesActionParametersCacheKeyCustomKeyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RulesetRulesActionParametersCacheKeyCustomKeyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RulesetRulesActionParametersCacheKeyCustomKeyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RulesetRulesActionParametersCacheKeyCustomKeyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookie\"}}]")]
        public virtual void PutCookie(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyCookie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyCookie)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeader\"}}]")]
        public virtual void PutHeader(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHost", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHost\"}}]")]
        public virtual void PutHost(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyHost @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyHost)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryString\"}}]")]
        public virtual void PutQueryString(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyQueryString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyUser\"}}]")]
        public virtual void PutUser(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKeyUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCookie")]
        public virtual void ResetCookie()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeader")]
        public virtual void ResetHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHost")]
        public virtual void ResetHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryString")]
        public virtual void ResetQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUser")]
        public virtual void ResetUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookieOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookieOutputReference Cookie
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookieOutputReference>()!;
        }

        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeaderOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeaderOutputReference Header
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHostOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHostOutputReference Host
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHostOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference QueryString
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference\"}")]
        public virtual cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference User
        {
            get => GetInstanceProperty<cloudflare.Ruleset.RulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookieInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyCookie\"}]}}", isOptional: true)]
        public virtual object? CookieInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHeader\"}]}}", isOptional: true)]
        public virtual object? HeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyHost\"}]}}", isOptional: true)]
        public virtual object? HostInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyQueryString\"}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKeyUser\"}]}}", isOptional: true)]
        public virtual object? UserInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersCacheKeyCustomKey\"}]}}", isOptional: true)]
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
                        case cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKey cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Ruleset.IRulesetRulesActionParametersCacheKeyCustomKey).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
