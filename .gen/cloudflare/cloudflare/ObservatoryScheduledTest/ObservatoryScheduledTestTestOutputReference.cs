using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ObservatoryScheduledTest
{
    [JsiiClass(nativeType: typeof(cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestOutputReference), fullyQualifiedName: "cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ObservatoryScheduledTestTestOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ObservatoryScheduledTestTestOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ObservatoryScheduledTestTestOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObservatoryScheduledTestTestOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Date
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "desktopReport", typeJson: "{\"fqn\":\"cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestDesktopReportOutputReference\"}")]
        public virtual cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestDesktopReportOutputReference DesktopReport
        {
            get => GetInstanceProperty<cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestDesktopReportOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mobileReport", typeJson: "{\"fqn\":\"cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestMobileReportOutputReference\"}")]
        public virtual cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestMobileReportOutputReference MobileReport
        {
            get => GetInstanceProperty<cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestMobileReportOutputReference>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestRegionOutputReference\"}")]
        public virtual cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestRegionOutputReference Region
        {
            get => GetInstanceProperty<cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestRegionOutputReference>()!;
        }

        [JsiiProperty(name: "scheduleFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduleFrequency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTest\"}", isOptional: true)]
        public virtual cloudflare.ObservatoryScheduledTest.IObservatoryScheduledTestTest? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ObservatoryScheduledTest.IObservatoryScheduledTestTest?>();
            set => SetInstanceProperty(value);
        }
    }
}
