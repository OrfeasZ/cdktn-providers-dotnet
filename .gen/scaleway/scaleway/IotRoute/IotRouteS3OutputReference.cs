using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotRoute
{
    [JsiiClass(nativeType: typeof(scaleway.IotRoute.IotRouteS3OutputReference), fullyQualifiedName: "scaleway.iotRoute.IotRouteS3OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotRouteS3OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotRouteS3OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotRouteS3OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotRouteS3OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetObjectPrefix")]
        public virtual void ResetObjectPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "strategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Strategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteS3\"}", isOptional: true)]
        public virtual scaleway.IotRoute.IIotRouteS3? InternalValue
        {
            get => GetInstanceProperty<scaleway.IotRoute.IIotRouteS3?>();
            set => SetInstanceProperty(value);
        }
    }
}
