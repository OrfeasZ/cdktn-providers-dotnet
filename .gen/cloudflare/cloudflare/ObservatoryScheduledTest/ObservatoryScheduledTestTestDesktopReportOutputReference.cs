using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ObservatoryScheduledTest
{
    [JsiiClass(nativeType: typeof(cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestDesktopReportOutputReference), fullyQualifiedName: "cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestDesktopReportOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ObservatoryScheduledTestTestDesktopReportOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ObservatoryScheduledTestTestDesktopReportOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ObservatoryScheduledTestTestDesktopReportOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObservatoryScheduledTestTestDesktopReportOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cls
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "error", typeJson: "{\"fqn\":\"cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestDesktopReportErrorOutputReference\"}")]
        public virtual cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestDesktopReportErrorOutputReference Error
        {
            get => GetInstanceProperty<cloudflare.ObservatoryScheduledTest.ObservatoryScheduledTestTestDesktopReportErrorOutputReference>()!;
        }

        [JsiiProperty(name: "fcp", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Fcp
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "jsonReportUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JsonReportUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lcp", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Lcp
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "performanceScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PerformanceScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "si", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Si
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tbt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tbt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ttfb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttfb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tti", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tti
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.observatoryScheduledTest.ObservatoryScheduledTestTestDesktopReport\"}", isOptional: true)]
        public virtual cloudflare.ObservatoryScheduledTest.IObservatoryScheduledTestTestDesktopReport? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ObservatoryScheduledTest.IObservatoryScheduledTestTestDesktopReport?>();
            set => SetInstanceProperty(value);
        }
    }
}
