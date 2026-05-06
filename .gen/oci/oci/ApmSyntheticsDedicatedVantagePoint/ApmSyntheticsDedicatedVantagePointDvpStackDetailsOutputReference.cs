using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsDedicatedVantagePoint
{
    [JsiiClass(nativeType: typeof(oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference), fullyQualifiedName: "oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvpStackIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DvpStackIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvpStackTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DvpStackTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvpStreamIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DvpStreamIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvpVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DvpVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dvpStackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DvpStackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dvpStackType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DvpStackType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dvpStreamId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DvpStreamId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dvpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DvpVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointDvpStackDetails? InternalValue
        {
            get => GetInstanceProperty<oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointDvpStackDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
