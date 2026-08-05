using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusAnomalyDetector
{
    [JsiiClass(nativeType: typeof(aws.PrometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestOutputReference), fullyQualifiedName: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class PrometheusAnomalyDetectorConfigurationRandomCutForestOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public PrometheusAnomalyDetectorConfigurationRandomCutForestOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected PrometheusAnomalyDetectorConfigurationRandomCutForestOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrometheusAnomalyDetectorConfigurationRandomCutForestOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove" />)[]</param>
        [JsiiMethod(name: "putIgnoreNearExpectedFromAbove", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIgnoreNearExpectedFromAbove(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow" />)[]</param>
        [JsiiMethod(name: "putIgnoreNearExpectedFromBelow", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIgnoreNearExpectedFromBelow(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIgnoreNearExpectedFromAbove")]
        public virtual void ResetIgnoreNearExpectedFromAbove()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreNearExpectedFromBelow")]
        public virtual void ResetIgnoreNearExpectedFromBelow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSampleSize")]
        public virtual void ResetSampleSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShingleSize")]
        public virtual void ResetShingleSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ignoreNearExpectedFromAbove", typeJson: "{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList\"}")]
        public virtual aws.PrometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList IgnoreNearExpectedFromAbove
        {
            get => GetInstanceProperty<aws.PrometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList>()!;
        }

        [JsiiProperty(name: "ignoreNearExpectedFromBelow", typeJson: "{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelowList\"}")]
        public virtual aws.PrometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelowList IgnoreNearExpectedFromBelow
        {
            get => GetInstanceProperty<aws.PrometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelowList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreNearExpectedFromAboveInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IgnoreNearExpectedFromAboveInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreNearExpectedFromBelowInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IgnoreNearExpectedFromBelowInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sampleSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SampleSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shingleSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ShingleSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SampleSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shingleSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ShingleSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForest\"}]}}", isOptional: true)]
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
                        case aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
