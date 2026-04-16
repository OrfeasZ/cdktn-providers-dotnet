using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiClass(nativeType: typeof(aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInclusion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInclusion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInclusion")]
        public virtual void ResetInclusion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inclusion", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusionList\"}")]
        public virtual aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusionList Inclusion
        {
            get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inclusionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InclusionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule\"}", isOptional: true)]
        public virtual aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule? InternalValue
        {
            get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
