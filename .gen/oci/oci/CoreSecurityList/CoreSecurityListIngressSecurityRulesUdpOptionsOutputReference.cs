using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    [JsiiClass(nativeType: typeof(oci.CoreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsOutputReference), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreSecurityListIngressSecurityRulesUdpOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreSecurityListIngressSecurityRulesUdpOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreSecurityListIngressSecurityRulesUdpOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreSecurityListIngressSecurityRulesUdpOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSourcePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange\"}}]")]
        public virtual void PutSourcePortRange(oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange)}, new object[]{@value});
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

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRangeOutputReference\"}")]
        public virtual oci.CoreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRangeOutputReference SourcePortRange
        {
            get => GetInstanceProperty<oci.CoreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRangeOutputReference>()!;
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
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
        public virtual oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange? SourcePortRangeInput
        {
            get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptionsSourcePortRange?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptions\"}", isOptional: true)]
        public virtual oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptions? InternalValue
        {
            get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
