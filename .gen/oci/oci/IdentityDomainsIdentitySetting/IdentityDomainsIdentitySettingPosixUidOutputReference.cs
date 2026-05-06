using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentitySetting
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUidOutputReference), fullyQualifiedName: "oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUidOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsIdentitySettingPosixUidOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsIdentitySettingPosixUidOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsIdentitySettingPosixUidOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentitySettingPosixUidOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetManualAssignmentEndsAt")]
        public virtual void ResetManualAssignmentEndsAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManualAssignmentStartsFrom")]
        public virtual void ResetManualAssignmentStartsFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "manualAssignmentEndsAtInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ManualAssignmentEndsAtInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "manualAssignmentStartsFromInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ManualAssignmentStartsFromInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "manualAssignmentEndsAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ManualAssignmentEndsAt
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "manualAssignmentStartsFrom", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ManualAssignmentStartsFrom
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUid\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixUid? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixUid?>();
            set => SetInstanceProperty(value);
        }
    }
}
