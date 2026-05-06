using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BastionSession
{
    [JsiiClass(nativeType: typeof(oci.BastionSession.BastionSessionTargetResourceDetailsOutputReference), fullyQualifiedName: "oci.bastionSession.BastionSessionTargetResourceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BastionSessionTargetResourceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BastionSessionTargetResourceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BastionSessionTargetResourceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BastionSessionTargetResourceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTargetResourceFqdn")]
        public virtual void ResetTargetResourceFqdn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResourceId")]
        public virtual void ResetTargetResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResourceOperatingSystemUserName")]
        public virtual void ResetTargetResourceOperatingSystemUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResourcePort")]
        public virtual void ResetTargetResourcePort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResourcePrivateIpAddress")]
        public virtual void ResetTargetResourcePrivateIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "targetResourceDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SessionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceFqdnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceFqdnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceOperatingSystemUserNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceOperatingSystemUserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourcePortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetResourcePortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourcePrivateIpAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourcePrivateIpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "sessionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetResourceFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceFqdn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetResourceOperatingSystemUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceOperatingSystemUserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetResourcePort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetResourcePort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetResourcePrivateIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourcePrivateIpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bastionSession.BastionSessionTargetResourceDetails\"}", isOptional: true)]
        public virtual oci.BastionSession.IBastionSessionTargetResourceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.BastionSession.IBastionSessionTargetResourceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
