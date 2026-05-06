using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    [JsiiClass(nativeType: typeof(oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreSecurityListEgressSecurityRulesUdpOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSourcePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRange\"}}]")]
        public virtual void PutSourcePortRange(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMax")]
        public virtual void ResetMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMin")]
        public virtual void ResetMin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePortRange")]
        public virtual void ResetSourcePortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRangeOutputReference\"}")]
        public virtual oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRangeOutputReference SourcePortRange
        {
            get => GetInstanceProperty<oci.CoreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
        public virtual oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRange? SourcePortRangeInput
        {
            get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptionsSourcePortRange?>();
        }

        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Max
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Min
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
        public virtual oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions? InternalValue
        {
            get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
