using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubScheduledJob
{
    [JsiiClass(nativeType: typeof(oci.OsManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference), fullyQualifiedName: "oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubScheduledJobOperationsSwitchSnapChannelDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetChannel")]
        public virtual void ResetChannel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "channelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChannelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Channel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.osManagementHubScheduledJob.OsManagementHubScheduledJobOperationsSwitchSnapChannelDetails\"}", isOptional: true)]
        public virtual oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails? InternalValue
        {
            get => GetInstanceProperty<oci.OsManagementHubScheduledJob.IOsManagementHubScheduledJobOperationsSwitchSnapChannelDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
