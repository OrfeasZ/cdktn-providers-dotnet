using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiClass(nativeType: typeof(oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationPortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRange\"}}]")]
        public virtual void PutDestinationPortRange(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourcePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange\"}}]")]
        public virtual void PutSourcePortRange(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange)}, new object[]{@value});
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

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRangeOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRangeOutputReference DestinationPortRange
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRangeOutputReference>()!;
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRangeOutputReference\"}")]
        public virtual oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRangeOutputReference SourcePortRange
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRangeInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRange\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRange? DestinationPortRangeInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsDestinationPortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange? SourcePortRangeInput
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptions\"}", isOptional: true)]
        public virtual oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions? InternalValue
        {
            get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
