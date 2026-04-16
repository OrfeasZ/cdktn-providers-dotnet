using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecServiceTerminationOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecServiceTerminationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppSpecServiceTerminationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppSpecServiceTerminationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppSpecServiceTerminationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecServiceTerminationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDrainSeconds")]
        public virtual void ResetDrainSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGracePeriodSeconds")]
        public virtual void ResetGracePeriodSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "drainSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DrainSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gracePeriodSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GracePeriodSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "drainSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DrainSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GracePeriodSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceTermination\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceTermination? InternalValue
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceTermination?>();
            set => SetInstanceProperty(value);
        }
    }
}
