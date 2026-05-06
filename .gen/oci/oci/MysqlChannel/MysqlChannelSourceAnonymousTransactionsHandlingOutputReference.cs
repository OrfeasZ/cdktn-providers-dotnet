using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlChannel
{
    [JsiiClass(nativeType: typeof(oci.MysqlChannel.MysqlChannelSourceAnonymousTransactionsHandlingOutputReference), fullyQualifiedName: "oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandlingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlChannelSourceAnonymousTransactionsHandlingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlChannelSourceAnonymousTransactionsHandlingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlChannelSourceAnonymousTransactionsHandlingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlChannelSourceAnonymousTransactionsHandlingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLastConfiguredLogFilename")]
        public virtual void ResetLastConfiguredLogFilename()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastConfiguredLogOffset")]
        public virtual void ResetLastConfiguredLogOffset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUuid")]
        public virtual void ResetUuid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastConfiguredLogFilenameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastConfiguredLogFilenameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastConfiguredLogOffsetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastConfiguredLogOffsetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "lastConfiguredLogFilename", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastConfiguredLogFilename
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastConfiguredLogOffset", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastConfiguredLogOffset
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlChannel.MysqlChannelSourceAnonymousTransactionsHandling\"}", isOptional: true)]
        public virtual oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlChannel.IMysqlChannelSourceAnonymousTransactionsHandling?>();
            set => SetInstanceProperty(value);
        }
    }
}
