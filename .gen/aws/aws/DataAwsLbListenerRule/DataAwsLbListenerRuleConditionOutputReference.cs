using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionOutputReference), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsLbListenerRuleConditionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsLbListenerRuleConditionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsLbListenerRuleConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerRuleConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHostHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHostHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHostHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHostHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHttpHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHttpHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHttpHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHttpHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpRequestMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHttpRequestMethod(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHttpRequestMethod[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHttpRequestMethod).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionHttpRequestMethod).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPathPattern", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPathPattern(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionPathPattern[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionPathPattern).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionPathPattern).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionQueryString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionQueryString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionQueryString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSourceIp(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionSourceIp[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionSourceIp).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionSourceIp).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostHeader")]
        public virtual void ResetHostHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpHeader")]
        public virtual void ResetHttpHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRequestMethod")]
        public virtual void ResetHttpRequestMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPathPattern")]
        public virtual void ResetPathPattern()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryString")]
        public virtual void ResetQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceIp")]
        public virtual void ResetSourceIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHostHeaderList\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionHostHeaderList HostHeader
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionHostHeaderList>()!;
        }

        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpHeaderList\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpHeaderList HttpHeader
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpHeaderList>()!;
        }

        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpRequestMethodList\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpRequestMethodList HttpRequestMethod
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpRequestMethodList>()!;
        }

        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionPathPatternList\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionPathPatternList PathPattern
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionPathPatternList>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryStringList\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryStringList QueryString
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryStringList>()!;
        }

        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionSourceIpList\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionSourceIpList SourceIp
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConditionSourceIpList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HttpHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HttpRequestMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathPatternInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PathPatternInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourceIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleCondition\"}]}}", isOptional: true)]
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
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleCondition cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleCondition).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
