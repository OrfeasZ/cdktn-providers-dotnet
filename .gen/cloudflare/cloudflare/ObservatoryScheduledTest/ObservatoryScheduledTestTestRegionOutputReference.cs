using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ObservatoryScheduledTest
{
    [JsiiClass(nativeType: typeof(cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestRegionOutputReference), fullyQualifiedName: "cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestRegionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ObservatoryScheduledTestTestRegionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ObservatoryScheduledTestTestRegionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ObservatoryScheduledTestTestRegionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObservatoryScheduledTestTestRegionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Label
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestRegion\"}", isOptional: true)]
        public virtual cloudflare.ObservatoryScheduledTest.IObservatoryScheduledTestTestRegion? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ObservatoryScheduledTest.IObservatoryScheduledTestTestRegion?>();
            set => SetInstanceProperty(value);
        }
    }
}
