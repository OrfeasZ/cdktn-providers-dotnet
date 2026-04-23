using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiClass(nativeType: typeof(aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesOutputReference), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerHyperParameterTuningJobConfigParameterRangesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SagemakerHyperParameterTuningJobConfigParameterRangesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SagemakerHyperParameterTuningJobConfigParameterRangesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerHyperParameterTuningJobConfigParameterRangesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesAutoParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAutoParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesAutoParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesAutoParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesAutoParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCategoricalParameterRanges", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCategoricalParameterRanges(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContinuousParameterRanges", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContinuousParameterRanges(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIntegerParameterRanges", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIntegerParameterRanges(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoParameters")]
        public virtual void ResetAutoParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCategoricalParameterRanges")]
        public virtual void ResetCategoricalParameterRanges()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContinuousParameterRanges")]
        public virtual void ResetContinuousParameterRanges()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntegerParameterRanges")]
        public virtual void ResetIntegerParameterRanges()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoParameters", typeJson: "{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesAutoParametersList\"}")]
        public virtual aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesAutoParametersList AutoParameters
        {
            get => GetInstanceProperty<aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesAutoParametersList>()!;
        }

        [JsiiProperty(name: "categoricalParameterRanges", typeJson: "{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRangesList\"}")]
        public virtual aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRangesList CategoricalParameterRanges
        {
            get => GetInstanceProperty<aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRangesList>()!;
        }

        [JsiiProperty(name: "continuousParameterRanges", typeJson: "{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRangesList\"}")]
        public virtual aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRangesList ContinuousParameterRanges
        {
            get => GetInstanceProperty<aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRangesList>()!;
        }

        [JsiiProperty(name: "integerParameterRanges", typeJson: "{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRangesList\"}")]
        public virtual aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRangesList IntegerParameterRanges
        {
            get => GetInstanceProperty<aws.SagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRangesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesAutoParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AutoParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoricalParameterRangesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CategoricalParameterRangesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "continuousParameterRangesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContinuousParameterRangesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integerParameterRangesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IntegerParameterRangesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRanges\"}]}}", isOptional: true)]
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
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRanges cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRanges).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
