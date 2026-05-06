using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiClass(nativeType: typeof(oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationPortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRange\"}}]")]
        public virtual void PutDestinationPortRange(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourcePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRange\"}}]")]
        public virtual void PutSourcePortRange(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationPortRange")]
        public virtual void ResetDestinationPortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePortRange")]
        public virtual void ResetSourcePortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRangeOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRangeOutputReference DestinationPortRange
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRangeOutputReference>()!;
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRangeOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRangeOutputReference SourcePortRange
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRangeInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRange\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRange? DestinationPortRangeInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsDestinationPortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRange? SourcePortRangeInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptionsSourcePortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions? InternalValue
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
