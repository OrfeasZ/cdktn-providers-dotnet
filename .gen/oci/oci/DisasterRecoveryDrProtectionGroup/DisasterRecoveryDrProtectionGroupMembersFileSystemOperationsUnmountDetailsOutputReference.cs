using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiClass(nativeType: typeof(oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMountTargetId")]
        public virtual void ResetMountTargetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountTargetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MountTargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MountTargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
