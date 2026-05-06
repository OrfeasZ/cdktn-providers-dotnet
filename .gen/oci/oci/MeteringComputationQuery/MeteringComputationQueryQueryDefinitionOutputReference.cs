using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    [JsiiClass(nativeType: typeof(oci.MeteringComputationQuery.MeteringComputationQueryQueryDefinitionOutputReference), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MeteringComputationQueryQueryDefinitionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MeteringComputationQueryQueryDefinitionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MeteringComputationQueryQueryDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationQueryQueryDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostAnalysisUi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUi\"}}]")]
        public virtual void PutCostAnalysisUi(oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionCostAnalysisUi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionCostAnalysisUi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReportQuery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQuery\"}}]")]
        public virtual void PutReportQuery(oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQuery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQuery)}, new object[]{@value});
        }

        [JsiiProperty(name: "costAnalysisUi", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUiOutputReference\"}")]
        public virtual oci.MeteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUiOutputReference CostAnalysisUi
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUiOutputReference>()!;
        }

        [JsiiProperty(name: "reportQuery", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryOutputReference\"}")]
        public virtual oci.MeteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryOutputReference ReportQuery
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costAnalysisUiInput", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionCostAnalysisUi\"}", isOptional: true)]
        public virtual oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionCostAnalysisUi? CostAnalysisUiInput
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionCostAnalysisUi?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportQueryInput", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQuery\"}", isOptional: true)]
        public virtual oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQuery? ReportQueryInput
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQuery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinition\"}", isOptional: true)]
        public virtual oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinition? InternalValue
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinition?>();
            set => SetInstanceProperty(value);
        }
    }
}
