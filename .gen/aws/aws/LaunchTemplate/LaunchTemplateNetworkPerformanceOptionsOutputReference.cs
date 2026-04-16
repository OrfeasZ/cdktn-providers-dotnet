using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiClass(nativeType: typeof(aws.LaunchTemplate.LaunchTemplateNetworkPerformanceOptionsOutputReference), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkPerformanceOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LaunchTemplateNetworkPerformanceOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LaunchTemplateNetworkPerformanceOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LaunchTemplateNetworkPerformanceOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateNetworkPerformanceOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBandwidthWeighting")]
        public virtual void ResetBandwidthWeighting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bandwidthWeightingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BandwidthWeightingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bandwidthWeighting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BandwidthWeighting
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkPerformanceOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateNetworkPerformanceOptions? InternalValue
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateNetworkPerformanceOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
