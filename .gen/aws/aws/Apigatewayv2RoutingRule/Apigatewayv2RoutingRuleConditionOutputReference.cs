using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2RoutingRule
{
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionOutputReference), fullyQualifiedName: "aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Apigatewayv2RoutingRuleConditionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Apigatewayv2RoutingRuleConditionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Apigatewayv2RoutingRuleConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2RoutingRuleConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMatchBasePaths", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePaths\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMatchBasePaths(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchBasePaths[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchBasePaths).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchBasePaths).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatchHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeaders\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMatchHeaders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeaders[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeaders).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleConditionMatchHeaders).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMatchBasePaths")]
        public virtual void ResetMatchBasePaths()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMatchHeaders")]
        public virtual void ResetMatchHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "matchBasePaths", typeJson: "{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePathsList\"}")]
        public virtual aws.Apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePathsList MatchBasePaths
        {
            get => GetInstanceProperty<aws.Apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePathsList>()!;
        }

        [JsiiProperty(name: "matchHeaders", typeJson: "{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersList\"}")]
        public virtual aws.Apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersList MatchHeaders
        {
            get => GetInstanceProperty<aws.Apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeadersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchBasePathsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchBasePaths\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MatchBasePathsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchHeadersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleConditionMatchHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MatchHeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.apigatewayv2RoutingRule.Apigatewayv2RoutingRuleCondition\"}]}}", isOptional: true)]
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
                        case aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleCondition cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Apigatewayv2RoutingRule.IApigatewayv2RoutingRuleCondition).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
