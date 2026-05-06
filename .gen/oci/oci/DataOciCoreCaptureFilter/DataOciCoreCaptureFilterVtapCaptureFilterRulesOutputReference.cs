using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreCaptureFilter
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesOutputReference), fullyQualifiedName: "oci.dataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreCaptureFilterVtapCaptureFilterRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreCaptureFilterVtapCaptureFilterRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreCaptureFilterVtapCaptureFilterRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreCaptureFilterVtapCaptureFilterRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesIcmpOptionsList\"}")]
        public virtual oci.DataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesIcmpOptionsList IcmpOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesIcmpOptionsList>()!;
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

        [JsiiProperty(name: "sourceCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesTcpOptionsList\"}")]
        public virtual oci.DataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesTcpOptionsList TcpOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesTcpOptionsList>()!;
        }

        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficDirection
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesUdpOptionsList\"}")]
        public virtual oci.DataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesUdpOptionsList UdpOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRulesUdpOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreCaptureFilter.DataOciCoreCaptureFilterVtapCaptureFilterRules\"}", isOptional: true)]
        public virtual oci.DataOciCoreCaptureFilter.IDataOciCoreCaptureFilterVtapCaptureFilterRules? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreCaptureFilter.IDataOciCoreCaptureFilterVtapCaptureFilterRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
