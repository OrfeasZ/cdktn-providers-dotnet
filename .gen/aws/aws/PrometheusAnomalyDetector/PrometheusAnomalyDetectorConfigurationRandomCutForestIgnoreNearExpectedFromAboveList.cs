using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusAnomalyDetector
{
    [JsiiClass(nativeType: typeof(aws.PrometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList), fullyQualifiedName: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"wrapsSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList : Io.Cdktn.ComplexList
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="wrapsSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, wrapsSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, wrapsSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveList(DeputyProps props): base(props)
        {
        }

        /// <param name="index">the index of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the index of the item to return.\"},\"name\":\"index\",\"type\":{\"primitive\":\"number\"}}]")]
        public virtual aws.PrometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveOutputReference Get(double index)
        {
            return InvokeInstanceMethod<aws.PrometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAboveOutputReference>(new System.Type[]{typeof(double)}, new object[]{index})!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
