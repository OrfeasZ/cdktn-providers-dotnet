using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PageRule
{
    [JsiiClass(nativeType: typeof(cloudflare.PageRule.PageRuleActionsCacheKeyFieldsOutputReference), fullyQualifiedName: "cloudflare.pageRule.PageRuleActionsCacheKeyFieldsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PageRuleActionsCacheKeyFieldsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PageRuleActionsCacheKeyFieldsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PageRuleActionsCacheKeyFieldsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PageRuleActionsCacheKeyFieldsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsCookie\"}}]")]
        public virtual void PutCookie(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsCookie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsCookie)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHeader\"}}]")]
        public virtual void PutHeader(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHost", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHost\"}}]")]
        public virtual void PutHost(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHost @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsHost)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsQueryString\"}}]")]
        public virtual void PutQueryString(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsQueryString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsQueryString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsUser\"}}]")]
        public virtual void PutUser(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PageRule.IPageRuleActionsCacheKeyFieldsUser)}, new object[]{@value});
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

        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsCookieOutputReference\"}")]
        public virtual cloudflare.PageRule.PageRuleActionsCacheKeyFieldsCookieOutputReference Cookie
        {
            get => GetInstanceProperty<cloudflare.PageRule.PageRuleActionsCacheKeyFieldsCookieOutputReference>()!;
        }

        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHeaderOutputReference\"}")]
        public virtual cloudflare.PageRule.PageRuleActionsCacheKeyFieldsHeaderOutputReference Header
        {
            get => GetInstanceProperty<cloudflare.PageRule.PageRuleActionsCacheKeyFieldsHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHostOutputReference\"}")]
        public virtual cloudflare.PageRule.PageRuleActionsCacheKeyFieldsHostOutputReference Host
        {
            get => GetInstanceProperty<cloudflare.PageRule.PageRuleActionsCacheKeyFieldsHostOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsQueryStringOutputReference\"}")]
        public virtual cloudflare.PageRule.PageRuleActionsCacheKeyFieldsQueryStringOutputReference QueryString
        {
            get => GetInstanceProperty<cloudflare.PageRule.PageRuleActionsCacheKeyFieldsQueryStringOutputReference>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsUserOutputReference\"}")]
        public virtual cloudflare.PageRule.PageRuleActionsCacheKeyFieldsUserOutputReference User
        {
            get => GetInstanceProperty<cloudflare.PageRule.PageRuleActionsCacheKeyFieldsUserOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookieInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsCookie\"}]}}", isOptional: true)]
        public virtual object? CookieInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHeader\"}]}}", isOptional: true)]
        public virtual object? HeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsHost\"}]}}", isOptional: true)]
        public virtual object? HostInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsQueryString\"}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFieldsUser\"}]}}", isOptional: true)]
        public virtual object? UserInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pageRule.PageRuleActionsCacheKeyFields\"}]}}", isOptional: true)]
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
                        case cloudflare.PageRule.IPageRuleActionsCacheKeyFields cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.PageRule.IPageRuleActionsCacheKeyFields).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
