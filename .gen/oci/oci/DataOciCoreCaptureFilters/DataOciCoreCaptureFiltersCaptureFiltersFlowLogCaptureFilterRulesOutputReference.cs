using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreCaptureFilters
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesOutputReference), fullyQualifiedName: "oci.dataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flowLogType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowLogType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesIcmpOptionsList\"}")]
        public virtual oci.DataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesIcmpOptionsList IcmpOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesIcmpOptionsList>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "samplingRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SamplingRate
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesTcpOptionsList\"}")]
        public virtual oci.DataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesTcpOptionsList TcpOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesTcpOptionsList>()!;
        }

        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesUdpOptionsList\"}")]
        public virtual oci.DataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesUdpOptionsList UdpOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRulesUdpOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreCaptureFilters.DataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRules\"}", isOptional: true)]
        public virtual oci.DataOciCoreCaptureFilters.IDataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRules? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreCaptureFilters.IDataOciCoreCaptureFiltersCaptureFiltersFlowLogCaptureFilterRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
