using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerScope
{
    [JsiiClass(nativeType: typeof(aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOutputReference), fullyQualifiedName: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAnd" />)[]</param>
        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAnd\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnd(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAnd[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAnd).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAnd).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteria" />)[]</param>
        [JsiiMethod(name: "putCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteria\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCriteria(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteria[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteria).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteria).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNot" />)[]</param>
        [JsiiMethod(name: "putNot", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNot\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNot(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNot[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNot).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNot).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOr" />)[]</param>
        [JsiiMethod(name: "putOr", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOr\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOr(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOr[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOr).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOr).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnd")]
        public virtual void ResetAnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCriteria")]
        public virtual void ResetCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNot")]
        public virtual void ResetNot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOr")]
        public virtual void ResetOr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAndList\"}")]
        public virtual aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAndList And
        {
            get => GetInstanceProperty<aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAndList>()!;
        }

        [JsiiProperty(name: "criteria", typeJson: "{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteriaList\"}")]
        public virtual aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteriaList Criteria
        {
            get => GetInstanceProperty<aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteriaList>()!;
        }

        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNotList\"}")]
        public virtual aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNotList Not
        {
            get => GetInstanceProperty<aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNotList>()!;
        }

        [JsiiProperty(name: "or", typeJson: "{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOrList\"}")]
        public virtual aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOrList Or
        {
            get => GetInstanceProperty<aws.NetworksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOrList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAnd" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AndInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteria" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "criteriaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CriteriaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNot" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionNot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NotInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOr" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpressionOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpression" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpression\"}]}}", isOptional: true)]
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
                        case aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpression cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeExcludeExpression).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
