using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiClass(nativeType: typeof(oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsOutputReference), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAttachmentDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails\"}}]")]
        public virtual void PutAttachmentDetails(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMountDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetails\"}}]")]
        public virtual void PutMountDetails(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttachmentDetails")]
        public virtual void ResetAttachmentDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockVolumeId")]
        public virtual void ResetBlockVolumeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountDetails")]
        public virtual void ResetMountDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "attachmentDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetailsOutputReference\"}")]
        public virtual oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetailsOutputReference AttachmentDetails
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "mountDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetailsOutputReference\"}")]
        public virtual oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetailsOutputReference MountDetails
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attachmentDetailsInput", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails? AttachmentDetailsInput
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsAttachmentDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockVolumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockVolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountDetailsInput", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetails\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetails? MountDetailsInput
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperationsMountDetails?>();
        }

        [JsiiProperty(name: "blockVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockVolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeOperations).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
