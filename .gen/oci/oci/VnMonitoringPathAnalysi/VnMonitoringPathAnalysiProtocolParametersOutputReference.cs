using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalysi
{
    [JsiiClass(nativeType: typeof(oci.VnMonitoringPathAnalysi.VnMonitoringPathAnalysiProtocolParametersOutputReference), fullyQualifiedName: "oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiProtocolParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VnMonitoringPathAnalysiProtocolParametersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VnMonitoringPathAnalysiProtocolParametersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VnMonitoringPathAnalysiProtocolParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VnMonitoringPathAnalysiProtocolParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDestinationPort")]
        public virtual void ResetDestinationPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpCode")]
        public virtual void ResetIcmpCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpType")]
        public virtual void ResetIcmpType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePort")]
        public virtual void ResetSourcePort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DestinationPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpCodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IcmpCodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpTypeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IcmpTypeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SourcePortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "destinationPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DestinationPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IcmpCode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "icmpType", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IcmpType
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourcePort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SourcePort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiProtocolParameters\"}", isOptional: true)]
        public virtual oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiProtocolParameters? InternalValue
        {
            get => GetInstanceProperty<oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiProtocolParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
