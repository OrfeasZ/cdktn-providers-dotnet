using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    [JsiiClass(nativeType: typeof(oci.KmsKey.KmsKeyAutoKeyRotationDetailsOutputReference), fullyQualifiedName: "oci.kmsKey.KmsKeyAutoKeyRotationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KmsKeyAutoKeyRotationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KmsKeyAutoKeyRotationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KmsKeyAutoKeyRotationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsKeyAutoKeyRotationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLastRotationMessage")]
        public virtual void ResetLastRotationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastRotationStatus")]
        public virtual void ResetLastRotationStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRotationIntervalInDays")]
        public virtual void ResetRotationIntervalInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeOfLastRotation")]
        public virtual void ResetTimeOfLastRotation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeOfNextRotation")]
        public virtual void ResetTimeOfNextRotation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeOfScheduleStart")]
        public virtual void ResetTimeOfScheduleStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastRotationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastRotationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastRotationStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastRotationStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rotationIntervalInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RotationIntervalInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeOfLastRotationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeOfLastRotationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeOfNextRotationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeOfNextRotationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeOfScheduleStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeOfScheduleStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "lastRotationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastRotationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastRotationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastRotationStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rotationIntervalInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RotationIntervalInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeOfLastRotation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastRotation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeOfNextRotation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfNextRotation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeOfScheduleStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfScheduleStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyAutoKeyRotationDetails\"}", isOptional: true)]
        public virtual oci.KmsKey.IKmsKeyAutoKeyRotationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.KmsKey.IKmsKeyAutoKeyRotationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
