using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotDevice
{
    [JsiiClass(nativeType: typeof(scaleway.IotDevice.IotDeviceMessageFiltersOutputReference), fullyQualifiedName: "scaleway.iotDevice.IotDeviceMessageFiltersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotDeviceMessageFiltersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotDeviceMessageFiltersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotDeviceMessageFiltersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotDeviceMessageFiltersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPublish", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersPublish\"}}]")]
        public virtual void PutPublish(scaleway.IotDevice.IIotDeviceMessageFiltersPublish @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.IotDevice.IIotDeviceMessageFiltersPublish)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubscribe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersSubscribe\"}}]")]
        public virtual void PutSubscribe(scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPublish")]
        public virtual void ResetPublish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscribe")]
        public virtual void ResetSubscribe()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "publish", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersPublishOutputReference\"}")]
        public virtual scaleway.IotDevice.IotDeviceMessageFiltersPublishOutputReference Publish
        {
            get => GetInstanceProperty<scaleway.IotDevice.IotDeviceMessageFiltersPublishOutputReference>()!;
        }

        [JsiiProperty(name: "subscribe", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersSubscribeOutputReference\"}")]
        public virtual scaleway.IotDevice.IotDeviceMessageFiltersSubscribeOutputReference Subscribe
        {
            get => GetInstanceProperty<scaleway.IotDevice.IotDeviceMessageFiltersSubscribeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishInput", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersPublish\"}", isOptional: true)]
        public virtual scaleway.IotDevice.IIotDeviceMessageFiltersPublish? PublishInput
        {
            get => GetInstanceProperty<scaleway.IotDevice.IIotDeviceMessageFiltersPublish?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscribeInput", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFiltersSubscribe\"}", isOptional: true)]
        public virtual scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe? SubscribeInput
        {
            get => GetInstanceProperty<scaleway.IotDevice.IIotDeviceMessageFiltersSubscribe?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.iotDevice.IotDeviceMessageFilters\"}", isOptional: true)]
        public virtual scaleway.IotDevice.IIotDeviceMessageFilters? InternalValue
        {
            get => GetInstanceProperty<scaleway.IotDevice.IIotDeviceMessageFilters?>();
            set => SetInstanceProperty(value);
        }
    }
}
