using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiClass(nativeType: typeof(aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessOutputReference), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AccessanalyzerAnalyzerConfigurationInternalAccessOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AccessanalyzerAnalyzerConfigurationInternalAccessOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AccessanalyzerAnalyzerConfigurationInternalAccessOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessanalyzerAnalyzerConfigurationInternalAccessOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnalysisRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule\"}}]")]
        public virtual void PutAnalysisRule(aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnalysisRule")]
        public virtual void ResetAnalysisRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "analysisRule", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference\"}")]
        public virtual aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference AnalysisRule
        {
            get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "analysisRuleInput", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule\"}", isOptional: true)]
        public virtual aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule? AnalysisRuleInput
        {
            get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccess\"}", isOptional: true)]
        public virtual aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccess? InternalValue
        {
            get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccess?>();
            set => SetInstanceProperty(value);
        }
    }
}
