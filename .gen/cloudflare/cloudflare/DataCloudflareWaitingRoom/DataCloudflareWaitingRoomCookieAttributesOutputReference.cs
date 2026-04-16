using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWaitingRoom
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWaitingRoom.DataCloudflareWaitingRoomCookieAttributesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWaitingRoom.DataCloudflareWaitingRoomCookieAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWaitingRoomCookieAttributesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWaitingRoomCookieAttributesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWaitingRoomCookieAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWaitingRoomCookieAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "samesite", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Samesite
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Secure
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWaitingRoom.DataCloudflareWaitingRoomCookieAttributes\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWaitingRoom.IDataCloudflareWaitingRoomCookieAttributes? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWaitingRoom.IDataCloudflareWaitingRoomCookieAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
