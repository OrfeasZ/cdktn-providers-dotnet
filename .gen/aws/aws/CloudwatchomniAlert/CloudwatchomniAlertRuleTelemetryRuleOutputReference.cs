using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleOutputReference), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudwatchomniAlertRuleTelemetryRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudwatchomniAlertRuleTelemetryRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CloudwatchomniAlertRuleTelemetryRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchomniAlertRuleTelemetryRuleOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition" />)[]</param>
        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation" />)[]</param>
        [JsiiMethod(name: "putEvaluation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEvaluation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData" />)[]</param>
        [JsiiMethod(name: "putNoData", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoData\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoData(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery" />)[]</param>
        [JsiiMethod(name: "putQuery", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQuery\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQuery(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCondition")]
        public virtual void ResetCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEvaluation")]
        public virtual void ResetEvaluation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoData")]
        public virtual void ResetNoData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuery")]
        public virtual void ResetQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleConditionList\"}")]
        public virtual aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleConditionList Condition
        {
            get => GetInstanceProperty<aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleConditionList>()!;
        }

        [JsiiProperty(name: "evaluation", typeJson: "{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluationList\"}")]
        public virtual aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluationList Evaluation
        {
            get => GetInstanceProperty<aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluationList>()!;
        }

        [JsiiProperty(name: "noData", typeJson: "{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoDataList\"}")]
        public virtual aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoDataList NoData
        {
            get => GetInstanceProperty<aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoDataList>()!;
        }

        [JsiiProperty(name: "query", typeJson: "{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQueryList\"}")]
        public virtual aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQueryList Query
        {
            get => GetInstanceProperty<aws.CloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQueryList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evaluationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EvaluationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRule\"}]}}", isOptional: true)]
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
                        case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
