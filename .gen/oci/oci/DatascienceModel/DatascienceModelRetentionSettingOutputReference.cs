using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModel
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModel.DatascienceModelRetentionSettingOutputReference), fullyQualifiedName: "oci.datascienceModel.DatascienceModelRetentionSettingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelRetentionSettingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelRetentionSettingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceModelRetentionSettingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelRetentionSettingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomerNotificationType")]
        public virtual void ResetCustomerNotificationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteAfterDays")]
        public virtual void ResetDeleteAfterDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "archiveAfterDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ArchiveAfterDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerNotificationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerNotificationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAfterDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeleteAfterDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "archiveAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ArchiveAfterDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerNotificationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerNotificationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeleteAfterDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModel.DatascienceModelRetentionSetting\"}", isOptional: true)]
        public virtual oci.DatascienceModel.IDatascienceModelRetentionSetting? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModel.IDatascienceModelRetentionSetting?>();
            set => SetInstanceProperty(value);
        }
    }
}
